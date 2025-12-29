using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace RogueResearcher
{
    class Program
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

            while (true)
            {
                string line = await Console.In.ReadLineAsync();
                if (string.IsNullOrEmpty(line)) continue;

                try
                {
                    await HandleRequest(line);
                }
                catch (Exception ex)
                {
                   Console.Error.WriteLine($"Error processing request: {ex.Message}");
                }
            }
        }

        static async Task HandleRequest(string json)
        {
            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                var root = doc.RootElement;
                if (!root.TryGetProperty("jsonrpc", out _)) return; 
                if (!root.TryGetProperty("method", out var methodProp)) return;
                
                string method = methodProp.GetString();
                bool hasId = root.TryGetProperty("id", out var idEl);

                if (method == "initialize")
                {
                     var response = new 
                     {
                         jsonrpc = "2.0",
                         id = hasId ? (object)idEl.GetInt32() : null,
                         result = new {
                             protocolVersion = "2024-11-05",
                             capabilities = new { tools = new { } },
                             serverInfo = new { name = "rogue-researcher", version = "1.0.0" }
                         }
                     };
                     Console.WriteLine(JsonSerializer.Serialize(response));
                }
                else if (method == "tools/list")
                {
                    var response = new
                    {
                        jsonrpc = "2.0",
                        id = hasId ? (object)idEl.GetInt32() : null,
                        result = new
                        {
                            tools = new[]
                            {
                                new {
                                    name = "search_web",
                                    description = "Search the web using DuckDuckGo HTML. Returns titles and URLs.",
                                    inputSchema = new {
                                        type = "object",
                                        properties = new {
                                            query = new { type = "string", description = "The search query" }
                                        },
                                        required = new[] { "query" }
                                    }
                                }
                            }
                        }
                    };
                    Console.WriteLine(JsonSerializer.Serialize(response));
                }
                else if (method == "tools/call")
                {
                    var paramsEl = root.GetProperty("params");
                    string name = paramsEl.GetProperty("name").GetString();
                    
                    if (name == "search_web")
                    {
                        var args = paramsEl.GetProperty("arguments");
                        string query = args.GetProperty("query").GetString();
                        
                        string result = await PerformSearch(query);
                        
                        var response = new
                        {
                            jsonrpc = "2.0",
                            id = hasId ? (object)idEl.GetInt32() : null,
                            result = new {
                                content = new[] {
                                    new { type = "text", text = result }
                                },
                                isError = false
                            }
                        };
                        Console.WriteLine(JsonSerializer.Serialize(response));
                    }
                    else 
                    {
                         // Basic empty response for unknown tools
                         if (hasId) {
                             Console.WriteLine(JsonSerializer.Serialize(new { jsonrpc = "2.0", id = idEl.GetInt32(), error = new { code = -32601, message = "Method not found" } }));
                         }
                    }
                }
                 else if (method == "ping")
                {
                     if (hasId) {
                         var response = new { jsonrpc = "2.0", id = idEl.GetInt32(), result = new { } };
                         Console.WriteLine(JsonSerializer.Serialize(response));
                     }
                }
            }
        }

        static async Task<string> PerformSearch(string query)
        {
            try
            {
                string url = $"https://html.duckduckgo.com/html/?q={Uri.EscapeDataString(query)}";
                string html = await _httpClient.GetStringAsync(url);
                return ParseResults(html);
            }
            catch (Exception ex)
            {
                return $"Search Failed: {ex.Message}";
            }
        }

        static string ParseResults(string html)
        {
            var results = new List<string>();
            var regex = new Regex(@"<a class=""result__a"" href=""([^""]+)""[^>]*>(.*?)</a>", RegexOptions.IgnoreCase);
            var matches = regex.Matches(html);

            int count = 0;
            foreach (Match match in matches)
            {
                if (count >= 5) break;
                string link = match.Groups[1].Value;
                string title = Regex.Replace(match.Groups[2].Value, "<.*?>", "");
                
                title = System.Net.WebUtility.HtmlDecode(title);
                link = System.Net.WebUtility.HtmlDecode(link);

                results.Add($"{count + 1}. {title}\n   Url: {link}");
                count++;
            }

            if (results.Count == 0) return "No results found or parsing failed. Content length: " + html.Length;
            return string.Join("\n\n", results);
        }
    }
}
