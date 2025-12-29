<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_EW1']/@gate_posX">
        <xsl:attribute name='gate_posX'>314.4291</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW1']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_EW4']/@posX">
        <xsl:attribute name='posX'>304.702</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW4']/@posY">
        <xsl:attribute name='posY'>331.418</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW4']/@gate_posX">
        <xsl:attribute name='gate_posX'>306.25</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW4']/@gate_posY">
        <xsl:attribute name='gate_posY'>334.59</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EW4_1']/@posX">
        <xsl:attribute name='posX'>293.13</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_1']/@posY">
        <xsl:attribute name='posY'>326.69</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW2}Arpotis</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.salt_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>125</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.salt_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>125</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EW4_3']/@posX">
        <xsl:attribute name='posX'>332.6294</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_3']/@posY">
        <xsl:attribute name='posY'>336.4061</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_3']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW3}Vinela</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_3']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>295</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW4_3']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>295</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EW1']/@gate_posX">
        <xsl:attribute name='gate_posX'>275.6199</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW1']/@gate_posY">
        <xsl:attribute name='gate_posY'>324.9102</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW1']/@name">
        <xsl:attribute name='name'>{=CE_NC_EW1}Garontor Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW1_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW4}Garontor</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW1_2']/@posX">
        <xsl:attribute name='posX'>258.943</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW1_2']/@posY">
        <xsl:attribute name='posY'>335.937</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW1_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW5}Lysia</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW1_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.date_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW1_2']/Components/Village/@bound">
        <xsl:attribute name='bound'>Settlement.town_EW4</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW1_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.date_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW1_2']/Components/Village/@bound">
        <xsl:attribute name='bound'>Settlement.town_EW4</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EW4']/@name">
        <xsl:attribute name='name'>{=CE_NC_EW2}Thractorae Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW4_1']/@posX">
        <xsl:attribute name='posX'>247.78</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW4_1']/@posY">
        <xsl:attribute name='posY'>371.86</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW4_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW6}Thractorae</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW4_2']/@posX">
        <xsl:attribute name='posX'>256.336</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW4_2']/@posY">
        <xsl:attribute name='posY'>359.741</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW4_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW7}Gamardan</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EW6']/@gate_posX">
        <xsl:attribute name='gate_posX'>346.0122</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW6']/@gate_posY">
        <xsl:attribute name='gate_posY'>390.3846</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW6_1']/@posX">
        <xsl:attribute name='posX'>340.499</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW6_1']/@posY">
        <xsl:attribute name='posY'>403.195</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW6_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW6_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW6_2']/@posX">
        <xsl:attribute name='posX'>331.201</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW6_2']/@posY">
        <xsl:attribute name='posY'>380.2</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.olive_trees</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.olive_trees</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_EW6']/@gate_posX">
        <xsl:attribute name='gate_posX'>389.72</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW6']/@gate_posY">
        <xsl:attribute name='gate_posY'>390.65</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EW6_3']/@posX">
        <xsl:attribute name='posX'>384.32</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW6_3']/@posY">
        <xsl:attribute name='posY'>380.52</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EW6_4']/@posX">
        <xsl:attribute name='posX'>376.4017</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW6_4']/@posY">
        <xsl:attribute name='posY'>402.205</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW6_4']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW9}Leblenion</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW6_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW6_4']/Components/Village/@bound">
        <xsl:attribute name='bound'>Settlement.castle_EW6</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW6_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW6_4']/Components/Village/@bound">
        <xsl:attribute name='bound'>Settlement.castle_EW6</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_EW3']/@posX">
        <xsl:attribute name='posX'>376.881</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW3']/@posY">
        <xsl:attribute name='posY'>341.654</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW3']/@gate_posX">
        <xsl:attribute name='gate_posX'>378.00</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW3']/@gate_posY">
        <xsl:attribute name='gate_posY'>343.88</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EW3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_EW2']/@posX">
        <xsl:attribute name='posX'>412.408</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW2']/@posY">
        <xsl:attribute name='posY'>287.626</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW2']/@gate_posX">
        <xsl:attribute name='gate_posX'>416.8959</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW2']/@gate_posY">
        <xsl:attribute name='gate_posY'>289.4483</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EW2_2']/@posX">
        <xsl:attribute name='posX'>434.224</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW2_2']/@posY">
        <xsl:attribute name='posY'>287.524</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW2_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW11}Tarcutis</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.vineyard</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW2_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>392</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.vineyard</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW2_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>392</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EW2_4']/@posY">
        <xsl:attribute name='posY'>309.283</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EW3']/@posX">
        <xsl:attribute name='posX'>461.32</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW3']/@posY">
        <xsl:attribute name='posY'>267.19</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW3']/@gate_posX">
        <xsl:attribute name='gate_posX'>464.41</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW3']/@gate_posY">
        <xsl:attribute name='gate_posY'>267.79</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW3_1']/@posX">
        <xsl:attribute name='posX'>460.607</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW3_1']/@posY">
        <xsl:attribute name='posY'>276.933</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.olive_trees</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.olive_trees</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW3_2']/@posX">
        <xsl:attribute name='posX'>446.874</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW3_2']/@posY">
        <xsl:attribute name='posY'>267.478</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW3_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW12}Carpans</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EW7']/@posX">
        <xsl:attribute name='posX'>341.51</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW7']/@posY">
        <xsl:attribute name='posY'>353</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW7']/@gate_posX">
        <xsl:attribute name='gate_posX'>344.57</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW7']/@gate_posY">
        <xsl:attribute name='gate_posY'>351.77</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW7']/@name">
        <xsl:attribute name='name'>{=CE_NC_EW3}Elvania Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW7']/@owner">
        <xsl:attribute name='owner'>Faction.clan_empire_west_1</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW7_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW7_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW7_2']/@posX">
        <xsl:attribute name='posX'>353.7437</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW7_2']/@posY">
        <xsl:attribute name='posY'>339.5327</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW7_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.olive_trees</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW7_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.olive_trees</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EW2']/@posX">
        <xsl:attribute name='posX'>444.60</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW2']/@posY">
        <xsl:attribute name='posY'>331.43</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW2']/@gate_posX">
        <xsl:attribute name='gate_posX'>447.53</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW2']/@gate_posY">
        <xsl:attribute name='gate_posY'>332.66</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW2']/@name">
        <xsl:attribute name='name'>{=CE_NC_EW4}Legnano Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW2_2']/@posX">
        <xsl:attribute name='posX'>467.196</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW2_2']/@posY">
        <xsl:attribute name='posY'>345.3646</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW2_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW21}Bergum</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW2_1']/@posX">
        <xsl:attribute name='posX'>450.344</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW2_1']/@posY">
        <xsl:attribute name='posY'>327.214</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW2_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW13}Legnano</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW2_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>187</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW2_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>187</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_EW5']/@name">
        <xsl:attribute name='name'>{=CE_NT_EW1}Amitatys</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EW5']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EW5_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW14}Elipa</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EW5_2']/@posX">
        <xsl:attribute name='posX'>421.12</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW5_2']/@posY">
        <xsl:attribute name='posY'>347.06</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EW5_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW15}Phasos</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EW5']/@name">
        <xsl:attribute name='name'>{=CE_NC_EW6}Goleryn Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW5_1']/@posX">
        <xsl:attribute name='posX'>289.31</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW5_1']/@posY">
        <xsl:attribute name='posY'>405.00</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW5_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW17}Veron</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW5_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW5_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW5_2']/@posX">
        <xsl:attribute name='posX'>254.282</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW5_2']/@posY">
        <xsl:attribute name='posY'>399.210</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW5_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW18}Goleryn</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EW8']/@posX">
        <xsl:attribute name='posX'>364.926</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW8']/@posY">
        <xsl:attribute name='posY'>457.624</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW8']/@gate_posX">
        <xsl:attribute name='gate_posX'>362.12</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW8']/@gate_posY">
        <xsl:attribute name='gate_posY'>457.56</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EW8']/@name">
        <xsl:attribute name='name'>{=CE_NC_EW5}Gersegos Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW8_1']/@posX">
        <xsl:attribute name='posX'>363.718</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW8_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW19}Gersegos</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW8_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW8_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EW8_2']/@posX">
        <xsl:attribute name='posX'>360.04</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW8_2']/@posY">
        <xsl:attribute name='posY'>441.11</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EW8_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EW20}Vathea</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_EN1']/@posX">
        <xsl:attribute name='posX'>407.606</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN1']/@posY">
        <xsl:attribute name='posY'>474.927</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN1']/@gate_posX">
        <xsl:attribute name='gate_posX'>404.8995</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN1']/@gate_posY">
        <xsl:attribute name='gate_posY'>474.3967</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EN1_3']/@posX">
        <xsl:attribute name='posX'>400.00</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN1_3']/@posY">
        <xsl:attribute name='posY'>482.57</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN1_3']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN1}Agalmon</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN1_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN1_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_EN2']/@posX">
        <xsl:attribute name='posX'>467.018</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN2']/@posY">
        <xsl:attribute name='posY'>475.64</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN2']/@gate_posX">
        <xsl:attribute name='gate_posX'>465.1465</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN2']/@gate_posY">
        <xsl:attribute name='gate_posY'>471.1724</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EN2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.europe_horse_ranch</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.europe_horse_ranch</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EN9']/@gate_posY">
        <xsl:attribute name='gate_posY'>482.2064</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN9']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_EN9}Palos Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN9_2']/@posX">
        <xsl:attribute name='posX'>418.696</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN9_2']/@posY">
        <xsl:attribute name='posY'>478.505</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN9_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN3}Palos</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN9_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN9_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>502</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN9_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN9_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>502</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EN3']/@posX">
        <xsl:attribute name='posX'>433.43</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN3']/@posY">
        <xsl:attribute name='posY'>440.25</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN3']/@gate_posX">
        <xsl:attribute name='gate_posX'>432.01</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN3']/@gate_posY">
        <xsl:attribute name='gate_posY'>438.04</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN3']/@owner">
        <xsl:attribute name='owner'>Faction.clan_empire_north_2</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN3_1']/@posX">
        <xsl:attribute name='posX'>446.606</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN3_1']/@posY">
        <xsl:attribute name='posY'>437.407</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN3_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN4}Rhesos</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN3_2']/@posX">
        <xsl:attribute name='posX'>463.498</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN3_2']/@posY">
        <xsl:attribute name='posY'>432.922</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN1_1']/@posX">
        <xsl:attribute name='posX'>493.570</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN1_1']/@posY">
        <xsl:attribute name='posY'>388.070</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN1_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN1_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN1_2']/@posX">
        <xsl:attribute name='posX'>485.544</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN1_2']/@posY">
        <xsl:attribute name='posY'>399.869</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN1_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN6}Eparaos</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EN6']/@posX">
        <xsl:attribute name='posX'>435.09</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN6']/@posY">
        <xsl:attribute name='posY'>400.41</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN6']/@gate_posX">
        <xsl:attribute name='gate_posX'>432.80</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN6']/@gate_posY">
        <xsl:attribute name='gate_posY'>401.89</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN6']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_EN6}Potamis Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN6_2']/@posX">
        <xsl:attribute name='posX'>441.77</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN6_2']/@posY">
        <xsl:attribute name='posY'>406.67</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EN3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EN7']/@posX">
        <xsl:attribute name='posX'>656.01</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN7']/@posY">
        <xsl:attribute name='posY'>512.87</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN7']/@gate_posX">
        <xsl:attribute name='gate_posX'>653.39</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN7']/@gate_posY">
        <xsl:attribute name='gate_posY'>512.08</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN7']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_EN7}Pons Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN7']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EN5']/@posX">
        <xsl:attribute name='posX'>519.80</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN5']/@posY">
        <xsl:attribute name='posY'>460.52</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN5']/@gate_posX">
        <xsl:attribute name='gate_posX'>522.69</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN5']/@gate_posY">
        <xsl:attribute name='gate_posY'>459.85</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN5']/@name">
        <xsl:attribute name='name'>{=CE_NC_EN1}Atrion Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN5_1']/@posX">
        <xsl:attribute name='posX'>538.406</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN5_1']/@posY">
        <xsl:attribute name='posY'>470.263</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN5_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN8}Masangara</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN5_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN5_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN5_2']/@posX">
        <xsl:attribute name='posX'>525.779</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN5_2']/@posY">
        <xsl:attribute name='posY'>450.962</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN5_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN9}Atrion</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_EN4']/@gate_posX">
        <xsl:attribute name='gate_posX'>532.46</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN4']/@gate_posY">
        <xsl:attribute name='gate_posY'>494.62</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN4']/@name">
        <xsl:attribute name='name'>{=CE_NT_EN1}Argoron</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EN4_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN10}Alatys</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN4_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>346</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN4_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>346</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EN4_4']/@posX">
        <xsl:attribute name='posX'>561.05</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN4_4']/@posY">
        <xsl:attribute name='posY'>489.98</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN4_4']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN12}Hetania</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN2_1']/@posX">
        <xsl:attribute name='posX'>588.58</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN2_1']/@posY">
        <xsl:attribute name='posY'>493.58</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN2_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN13}Lochana</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN2_2']/@posX">
        <xsl:attribute name='posX'>593.146</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN2_2']/@posY">
        <xsl:attribute name='posY'>478.194</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN2_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN14}Temonc</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EN4']/@posX">
        <xsl:attribute name='posX'>560.55</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN4']/@posY">
        <xsl:attribute name='posY'>405.22</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN4']/@gate_posX">
        <xsl:attribute name='gate_posX'>562.4598</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN4']/@gate_posY">
        <xsl:attribute name='gate_posY'>403.6138</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN4_1']/@posX">
        <xsl:attribute name='posX'>569.150</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN4_1']/@posY">
        <xsl:attribute name='posY'>391.539</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_EN6']/@gate_posX">
        <xsl:attribute name='gate_posX'>624.6627</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN6']/@name">
        <xsl:attribute name='name'>{=CE_NT_EN2}Amprela</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN6']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EN6_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN15}Avasinton</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN6_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN6_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EN6_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN16}Acragora</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_EN8']/@gate_posX">
        <xsl:attribute name='gate_posX'>661.7092</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN8']/@gate_posY">
        <xsl:attribute name='gate_posY'>475.9247</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN8']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_EN8}Temhem Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN8']/@owner">
        <xsl:attribute name='owner'>Faction.clan_empire_north_7</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_EN8']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_EN8_2']/@posX">
        <xsl:attribute name='posX'>661.061</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN8_2']/@posY">
        <xsl:attribute name='posY'>467.993</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN8_2']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_village_EN8_2}Temhem</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN8_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_EN8_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_EN5']/@posX">
        <xsl:attribute name='posX'>604.146</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN5']/@posY">
        <xsl:attribute name='posY'>426.119</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN5']/@gate_posX">
        <xsl:attribute name='gate_posX'>604.5169</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN5']/@gate_posY">
        <xsl:attribute name='gate_posY'>423.2607</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_EN5']/@name">
        <xsl:attribute name='name'>{=CE_NT_EN3}Myzea</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EN5_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN5_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EN5_1']/@posX">
        <xsl:attribute name='posX'>618.375</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN5_1']/@posY">
        <xsl:attribute name='posY'>446.083</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN5_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN18}Rozano</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN5_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN5_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_EN5_2']/@posX">
        <xsl:attribute name='posX'>607.409</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN5_2']/@posY">
        <xsl:attribute name='posY'>408.834</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN5_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_EN19}Caporello</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_EN5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_ES5']/@gate_posX">
        <xsl:attribute name='gate_posX'>643.96</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES5']/@gate_posY">
        <xsl:attribute name='gate_posY'>327.80</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_ES5_1']/@posX">
        <xsl:attribute name='posX'>632.331</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES5_1']/@posY">
        <xsl:attribute name='posY'>314.669</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_ES5_2']/@posX">
        <xsl:attribute name='posX'>645.935</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES5_2']/@posY">
        <xsl:attribute name='posY'>340.666</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_ES5_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES5_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_ES7']/@posX">
        <xsl:attribute name='posX'>644.606</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES7']/@posY">
        <xsl:attribute name='posY'>434.073</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES7']/@gate_posX">
        <xsl:attribute name='gate_posX'>647.70</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES7']/@gate_posY">
        <xsl:attribute name='gate_posY'>434.65</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES7']/@name">
        <xsl:attribute name='name'>{=CE_NC_ES1}Jogurys Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES7']/@owner">
        <xsl:attribute name='owner'>Faction.clan_empire_south_7</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES7_1']/@posX">
        <xsl:attribute name='posX'>638.809</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES7_1']/@posY">
        <xsl:attribute name='posY'>423.558</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES7_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES4}Jogurys</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES7_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES7_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES7_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.salt_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES7_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.salt_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_ES7']/@gate_posX">
        <xsl:attribute name='gate_posX'>648.9574</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES7']/@gate_posY">
        <xsl:attribute name='gate_posY'>388.6999</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES7']/@name">
        <xsl:attribute name='name'>{=CE_NT_ES2}Syronea</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES7']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_ES7_1']/@posX">
        <xsl:attribute name='posX'>635.38</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES7_1']/@posY">
        <xsl:attribute name='posY'>374.25</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES7_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES5}Psotai</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_ES7_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES7}Vargornis</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_ES3']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_ES3}Sagolina Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES3_2']/@posX">
        <xsl:attribute name='posX'>617.857</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES3_2']/@posY">
        <xsl:attribute name='posY'>373.131</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_ES2']/@posX">
        <xsl:attribute name='posX'>657.23</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES2']/@posY">
        <xsl:attribute name='posY'>340.03</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES2']/@gate_posX">
        <xsl:attribute name='gate_posX'>660.88</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES2']/@gate_posY">
        <xsl:attribute name='gate_posY'>341.04</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES2']/@name">
        <xsl:attribute name='name'>{=CE_NC_ES2}Metachia Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES2_1']/@posX">
        <xsl:attribute name='posX'>658.961</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES2_1']/@posY">
        <xsl:attribute name='posY'>359.269</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES2_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES8}Corenia</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES2_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES9}Metachia</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_ES1']/@gate_posX">
        <xsl:attribute name='gate_posX'>690.3297</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES1']/@gate_posY">
        <xsl:attribute name='gate_posY'>306.6122</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES1']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_ES1}Cotisia Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES1']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES1_1']/@posX">
        <xsl:attribute name='posX'>682.092</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES1_1']/@posY">
        <xsl:attribute name='posY'>323.742</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES1_2']/@posX">
        <xsl:attribute name='posX'>680.095</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES1_2']/@posY">
        <xsl:attribute name='posY'>314.916</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES1_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES10}Cotisia</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES1_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.silk_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES1_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.silk_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_ES1']/@gate_posX">
        <xsl:attribute name='gate_posX'>659.0048</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES1']/@gate_posY">
        <xsl:attribute name='gate_posY'>276.9256</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES1']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_ES1_4']/@posX">
        <xsl:attribute name='posX'>687.202</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES1_4']/@posY">
        <xsl:attribute name='posY'>276.935</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES1_4']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES11}Caira</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES1_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES1_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_ES1_2']/@posX">
        <xsl:attribute name='posX'>644.586</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES1_2']/@posY">
        <xsl:attribute name='posY'>279.354</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_ES4']/@gate_posY">
        <xsl:attribute name='gate_posY'>255.7068</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES4']/@name">
        <xsl:attribute name='name'>{=CE_NC_ES3}Erebulos Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES4']/@owner">
        <xsl:attribute name='owner'>Faction.clan_empire_south_4</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES4_1']/@posX">
        <xsl:attribute name='posX'>631.47</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES4_1']/@posY">
        <xsl:attribute name='posY'>263.573</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES4_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES12}Erebulos</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.clay_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.clay_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_ES2']/@posX">
        <xsl:attribute name='posX'>568.691</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES2']/@posY">
        <xsl:attribute name='posY'>239.759</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES2']/@gate_posX">
        <xsl:attribute name='gate_posX'>571.2314</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES2']/@gate_posY">
        <xsl:attribute name='gate_posY'>243.8832</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_ES2_3']/@posX">
        <xsl:attribute name='posX'>582.861</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES2_3']/@posY">
        <xsl:attribute name='posY'>267.395</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES2_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.silk_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES2_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.silk_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_ES5']/@posX">
        <xsl:attribute name='posX'>547.90</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES5']/@posY">
        <xsl:attribute name='posY'>275.99</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES5']/@gate_posX">
        <xsl:attribute name='gate_posX'>546.23</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES5']/@gate_posY">
        <xsl:attribute name='gate_posY'>278.41</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES5']/@name">
        <xsl:attribute name='name'>{=CE_NC_ES4}Atphynia Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES5_2']/@posX">
        <xsl:attribute name='posX'>539.964</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES5_2']/@posY">
        <xsl:attribute name='posY'>278.736</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES5_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES14}Atphynia</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_ES6']/@posX">
        <xsl:attribute name='posX'>486.09</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES6']/@posY">
        <xsl:attribute name='posY'>348.30</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES6']/@gate_posX">
        <xsl:attribute name='gate_posX'>483.56</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES6']/@gate_posY">
        <xsl:attribute name='gate_posY'>348.18</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_ES6']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_ES6}Amycon Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES6_1']/@posX">
        <xsl:attribute name='posX'>503.801</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES6_1']/@posY">
        <xsl:attribute name='posY'>349.47</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES6_1']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_village_ES6_1}Sestadeim</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_ES6']/@posX">
        <xsl:attribute name='posX'>566.24</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES6']/@gate_posX">
        <xsl:attribute name='gate_posX'>566.696</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES6']/@gate_posY">
        <xsl:attribute name='gate_posY'>345.217</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_ES6_2']/@posX">
        <xsl:attribute name='posX'>586.492</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES6_2']/@posY">
        <xsl:attribute name='posY'>362.637</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES6_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES15}Spotia</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_ES8']/@name">
        <xsl:attribute name='name'>{=CE_NC_ES5}Tripotamian Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES8_2']/@posX">
        <xsl:attribute name='posX'>522.389</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES8_2']/@posY">
        <xsl:attribute name='posY'>378.138</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES8_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES17}Popsia</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_ES8_1']/@posX">
        <xsl:attribute name='posX'>543.429</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES8_1']/@posY">
        <xsl:attribute name='posY'>371.202</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES8_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_ES18}Tripesso</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES8_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_ES8_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_ES3']/@posX">
        <xsl:attribute name='posX'>475.52</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES3']/@posY">
        <xsl:attribute name='posY'>280.30</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES3']/@gate_posX">
        <xsl:attribute name='gate_posX'>478.25</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES3']/@gate_posY">
        <xsl:attribute name='gate_posY'>280.20</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_ES3']/@name">
        <xsl:attribute name='name'>{=CE_NT_ES3}Poros</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_ES3_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_ES3_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_S7']/@posX">
        <xsl:attribute name='posX'>639.18</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S7']/@posY">
        <xsl:attribute name='posY'>548.63</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S7']/@gate_posX">
        <xsl:attribute name='gate_posX'>639.17</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S7']/@gate_posY">
        <xsl:attribute name='gate_posY'>546.80</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S7_1']/@posX">
        <xsl:attribute name='posX'>624.256</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S7_1']/@posY">
        <xsl:attribute name='posY'>541.011</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_S6']/@posX">
        <xsl:attribute name='posX'>549.77</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_S6']/@gate_posX">
        <xsl:attribute name='gate_posX'>554.0275</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_S6_1']/@posX">
        <xsl:attribute name='posX'>563.678</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S6_1']/@posY">
        <xsl:attribute name='posY'>592.944</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_S6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_S6_3']/@posX">
        <xsl:attribute name='posX'>529.84</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S6_3']/@posY">
        <xsl:attribute name='posY'>581.846</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_S6']/@posX">
        <xsl:attribute name='posX'>474.87</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S6']/@posY">
        <xsl:attribute name='posY'>546.98</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S6']/@gate_posX">
        <xsl:attribute name='gate_posX'>475.50</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S6']/@gate_posY">
        <xsl:attribute name='gate_posY'>548.71</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S6_1']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_village_S6_1}Dvorusta</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S6_2']/@posX">
        <xsl:attribute name='posX'>491.099</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S6_2']/@posY">
        <xsl:attribute name='posY'>551.6816</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S6_2']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_village_S6_2}Takor</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_S1']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_S1}Zhemyan Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S1_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S1_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S1_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S1_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_S3']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_S3_1']/@posX">
        <xsl:attribute name='posX'>435.727</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S3_1']/@posY">
        <xsl:attribute name='posY'>508.582</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_S2']/@posX">
        <xsl:attribute name='posX'>411.824</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S2']/@posY">
        <xsl:attribute name='posY'>501.278</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S2']/@gate_posX">
        <xsl:attribute name='gate_posX'>411.73</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S2']/@gate_posY">
        <xsl:attribute name='gate_posY'>499.35</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S2']/@name">
        <xsl:attribute name='name'>{=CE_NC_SG3}Forin Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S2_1']/@posX">
        <xsl:attribute name='posX'>395.339</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S2_1']/@posY">
        <xsl:attribute name='posY'>511.466</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_S4']/@name">
        <xsl:attribute name='name'>{=CE_NC_SG4}Seordas Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S4']/@owner">
        <xsl:attribute name='owner'>Faction.clan_sturgia_2</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S4']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S4_2']/@posX">
        <xsl:attribute name='posX'>357.593</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S4_2']/@posY">
        <xsl:attribute name='posY'>523.786</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S4_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_SG9}Seordas</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S4_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S4_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S4_1']/@posX">
        <xsl:attribute name='posX'>365.36</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S4_1']/@posY">
        <xsl:attribute name='posY'>510.44</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S4_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_SG10}Haroinby</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_S1']/@name">
        <xsl:attribute name='name'>{=CE_NT_SG3}Revyl</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_S1_1']/@posX">
        <xsl:attribute name='posX'>376.443</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S1_1']/@posY">
        <xsl:attribute name='posY'>551.982</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S1_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S1_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_S7']/@gate_posX">
        <xsl:attribute name='gate_posX'>300.7357</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_S7']/@gate_posY">
        <xsl:attribute name='gate_posY'>583.4869</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_S7']/@name">
        <xsl:attribute name='name'>{=CE_NT_SG4}Varcheg</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_S3']/@posX">
        <xsl:attribute name='posX'>291.136</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S3']/@posY">
        <xsl:attribute name='posY'>553.64</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S3']/@gate_posX">
        <xsl:attribute name='gate_posX'>291.23</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S3']/@gate_posY">
        <xsl:attribute name='gate_posY'>551.74</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S3']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_S3}Dnin Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S3']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S3_1']/@posX">
        <xsl:attribute name='posX'>270.890</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S3_1']/@posY">
        <xsl:attribute name='posY'>557.795</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S3_2']/@posX">
        <xsl:attribute name='posX'>299.953</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S3_2']/@posY">
        <xsl:attribute name='posY'>548.079</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_S5']/@posX">
        <xsl:attribute name='posX'>453.00</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S5']/@posY">
        <xsl:attribute name='posY'>539.21</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S5']/@gate_posX">
        <xsl:attribute name='gate_posX'>451.30</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S5']/@gate_posY">
        <xsl:attribute name='gate_posY'>538.77</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_S5']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_S5}Ferth Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S5_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S5_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S5_2']/@posX">
        <xsl:attribute name='posX'>444.24</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S5_2']/@posY">
        <xsl:attribute name='posY'>548.93</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S5_2']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_village_S5_2}Ferth</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_S8']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_S8}Glavstrom Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S8_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S8_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_S8_2']/@posX">
        <xsl:attribute name='posX'>602.09</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_S8_2']/@posY">
        <xsl:attribute name='posY'>579.03</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_S4']/@gate_posX">
        <xsl:attribute name='gate_posX'>537.909</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_S4']/@gate_posY">
        <xsl:attribute name='gate_posY'>549.673</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_S4_1']/@posX">
        <xsl:attribute name='posX'>515.753</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S4_1']/@posY">
        <xsl:attribute name='posY'>551.25</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S4_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_SG14}Borchovagorka</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_S4_4']/@posX">
        <xsl:attribute name='posX'>527.553</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S4_4']/@posY">
        <xsl:attribute name='posY'>565.444</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_S2']/@posX">
        <xsl:attribute name='posX'>467.158</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_S2']/@posY">
        <xsl:attribute name='posY'>570.245</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_S2']/@gate_posX">
        <xsl:attribute name='gate_posX'>468.2623</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_S2']/@gate_posY">
        <xsl:attribute name='gate_posY'>565.6448</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_S2_1']/@posX">
        <xsl:attribute name='posX'>475.92</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S2_1']/@posY">
        <xsl:attribute name='posY'>561.61</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_S2_2']/@posY">
        <xsl:attribute name='posY'>592.929</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_S5']/@gate_posY">
        <xsl:attribute name='gate_posY'>568.5306</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_S5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sturgian_horse_ranch</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_S5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sturgian_horse_ranch</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_B8']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_B8}Daldorn Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B8_2']/@posX">
        <xsl:attribute name='posX'>357.933</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B8_2']/@posY">
        <xsl:attribute name='posY'>500.148</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B8_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_BN1}Daldorn</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_B4_3']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.village_B4_3}Fenon Tryn</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B4_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B4_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_B4_4']/@posX">
        <xsl:attribute name='posX'>312.912</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B4_4']/@posY">
        <xsl:attribute name='posY'>496.178</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B4_4']/@name">
        <xsl:attribute name='name'>{=CE_NV_BN2}Iascyn</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B4_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B4_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_B6']/@gate_posX">
        <xsl:attribute name='gate_posX'>325.4799</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B6']/@gate_posY">
        <xsl:attribute name='gate_posY'>526.4038</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B6']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_B6}Swenryn Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B6_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.salt_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B6_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.salt_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B6_2']/@posX">
        <xsl:attribute name='posX'>312.990</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B6_2']/@posY">
        <xsl:attribute name='posY'>515.103</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B6_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_BN3}Swenryn</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B6_2']/Components/Village/@bound">
        <xsl:attribute name='bound'>Settlement.castle_B6</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B6_2']/Components/Village/@bound">
        <xsl:attribute name='bound'>Settlement.castle_B6</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_B4']/@posX">
        <xsl:attribute name='posX'>291.86</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B4']/@posY">
        <xsl:attribute name='posY'>509.03</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B4']/@gate_posX">
        <xsl:attribute name='gate_posX'>291.37</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B4']/@gate_posY">
        <xsl:attribute name='gate_posY'>511.69</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B4']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_B4}Glintor Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B4']/@owner">
        <xsl:attribute name='owner'>Faction.clan_sturgia_1</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B4_1']/@posX">
        <xsl:attribute name='posX'>289.421</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B4_1']/@posY">
        <xsl:attribute name='posY'>520.739</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B4_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_BN4}Glintor</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B4_2']/@posX">
        <xsl:attribute name='posX'>284.681</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B4_2']/@posY">
        <xsl:attribute name='posY'>498.005</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_B3']/@posX">
        <xsl:attribute name='posX'>223.86</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B3']/@posY">
        <xsl:attribute name='posY'>516.82</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B3']/@gate_posX">
        <xsl:attribute name='gate_posX'>225.42</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B3']/@gate_posY">
        <xsl:attribute name='gate_posY'>514.66</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B3']/@name">
        <xsl:attribute name='name'>{=CE_NC_BN1}Druimmor Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B3_2']/@posX">
        <xsl:attribute name='posX'>214.675</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_B3']/@gate_posX">
        <xsl:attribute name='gate_posX'>253.7009</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_B3']/@gate_posY">
        <xsl:attribute name='gate_posY'>513.0099</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_B3_1']/@posX">
        <xsl:attribute name='posX'>240.085</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B3_1']/@posY">
        <xsl:attribute name='posY'>518.918</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B3_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_BN8}Bog Beth</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_B3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_B2']/@posX">
        <xsl:attribute name='posX'>266.414</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_B2']/@posY">
        <xsl:attribute name='posY'>483.402</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_B2']/@gate_posX">
        <xsl:attribute name='gate_posX'>266.2964</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_B2']/@gate_posY">
        <xsl:attribute name='gate_posY'>485.9951</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_B2_1']/@posX">
        <xsl:attribute name='posX'>273.162</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B2_1']/@posY">
        <xsl:attribute name='posY'>499.335</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_B2_2']/@posX">
        <xsl:attribute name='posX'>257.248</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B2_2']/@posY">
        <xsl:attribute name='posY'>488.724</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_B2_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.battanian_horse_ranch</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B2_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.battanian_horse_ranch</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_B7']/@gate_posX">
        <xsl:attribute name='gate_posX'>236.0877</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B7']/@gate_posY">
        <xsl:attribute name='gate_posY'>477.6715</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B7']/@name">
        <xsl:attribute name='name'>{=CE_NC_BN2}Aster Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B7_2']/@posX">
        <xsl:attribute name='posX'>240.569</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B7_2']/@posY">
        <xsl:attribute name='posY'>478.388</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B7_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_BN10}Aster</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B7_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B7_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B7_1']/@posX">
        <xsl:attribute name='posX'>222.656</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B7_1']/@posY">
        <xsl:attribute name='posY'>476.266</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B7_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_BN11}Imlagh</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B7_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.clay_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B7_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.clay_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_B2']/@name">
        <xsl:attribute name='name'>{=CE_NC_BN3}Cantrec Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B2_2']/@posX">
        <xsl:attribute name='posX'>249.839</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B2_2']/@posY">
        <xsl:attribute name='posY'>444.806</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B2_1']/@posX">
        <xsl:attribute name='posX'>256.546</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B2_1']/@posY">
        <xsl:attribute name='posY'>456.105</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_B1']/@posX">
        <xsl:attribute name='posX'>220.531</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B1']/@posY">
        <xsl:attribute name='posY'>427.543</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B1']/@gate_posX">
        <xsl:attribute name='gate_posX'>220.93</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B1']/@gate_posY">
        <xsl:attribute name='gate_posY'>424.82</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B1']/@name">
        <xsl:attribute name='name'>{=CE_NC_BN4}Inveth Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_B1']/@owner">
        <xsl:attribute name='owner'>Faction.clan_battania_5</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B1_2']/@posX">
        <xsl:attribute name='posX'>217.657</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B1_2']/@posY">
        <xsl:attribute name='posY'>417.779</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B1_1']/@posX">
        <xsl:attribute name='posX'>232.425</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B1_1']/@posY">
        <xsl:attribute name='posY'>415.342</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B1_1']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_village_B1_1}Mag Arba</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B1_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B1_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_B5_2']/@posX">
        <xsl:attribute name='posX'>225.576</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B5_2']/@posY">
        <xsl:attribute name='posY'>461.841</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.swine_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.swine_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_B5_3']/@posX">
        <xsl:attribute name='posX'>236.468</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B5_3']/@posY">
        <xsl:attribute name='posY'>435.447</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B5_3']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.village_B5_3}Ab Comer</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B5_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B5_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_B1']/@posX">
        <xsl:attribute name='posX'>291.206</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_B1']/@posY">
        <xsl:attribute name='posY'>442.702</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_B1']/@gate_posX">
        <xsl:attribute name='gate_posX'>291.2067</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_B1']/@gate_posY">
        <xsl:attribute name='gate_posY'>442.7153</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_B1_1']/@posX">
        <xsl:attribute name='posX'>297.952</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B1_1']/@posY">
        <xsl:attribute name='posY'>457.408</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_B1_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_B1_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_B5_1']/@posX">
        <xsl:attribute name='posX'>315.757</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_B5_1']/@posY">
        <xsl:attribute name='posY'>455.983</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V5_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.olive_trees</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V5_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.olive_trees</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_V8']/@owner">
        <xsl:attribute name='owner'>Faction.clan_vlandia_5</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V8_1']/@posX">
        <xsl:attribute name='posX'>148.647</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V8_1']/@posY">
        <xsl:attribute name='posY'>535.518</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V8_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V8_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V8_2']/@posX">
        <xsl:attribute name='posX'>145.745</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V8_2']/@posY">
        <xsl:attribute name='posY'>551.749</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V8_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V8_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V8_3']/@posX">
        <xsl:attribute name='posX'>140.085</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V8_3']/@posY">
        <xsl:attribute name='posY'>565.016</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V8_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V8_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_V5']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_V5}Senkeberg Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V5_1']/@posX">
        <xsl:attribute name='posX'>147.196</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V5_1']/@posY">
        <xsl:attribute name='posY'>578.715</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V5_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_VD3}Horemdac</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V5_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V5_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_V2']/@gate_posX">
        <xsl:attribute name='gate_posX'>177.13</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_V2']/@gate_posY">
        <xsl:attribute name='gate_posY'>494.08</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V2_3']/@posX">
        <xsl:attribute name='posX'>162.028</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V2_3']/@posY">
        <xsl:attribute name='posY'>487.048</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V2_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.vlandian_horse_ranch</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V2_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.vlandian_horse_ranch</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_V8']/@posX">
        <xsl:attribute name='posX'>162.142</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V8']/@posY">
        <xsl:attribute name='posY'>466.833</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V8']/@gate_posX">
        <xsl:attribute name='gate_posX'>162.9213</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V8']/@gate_posY">
        <xsl:attribute name='gate_posY'>468.1964</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V8_1']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_village_V8_1}Marin</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V8_2']/@posX">
        <xsl:attribute name='posX'>170.749</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V8_2']/@posY">
        <xsl:attribute name='posY'>460.582</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V8_2']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_village_V8_2}Verecsand</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V8_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.vlandian_horse_ranch</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V8_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.vlandian_horse_ranch</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_V3']/@gate_posX">
        <xsl:attribute name='gate_posX'>136.1804</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_V3']/@gate_posY">
        <xsl:attribute name='gate_posY'>478.1952</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V3_4']/@posX">
        <xsl:attribute name='posX'>134.911</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V3_4']/@posY">
        <xsl:attribute name='posY'>466.659</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V3_4']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.village_V3_4}Palisona</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V3_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.swine_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V3_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.swine_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V3_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>312</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V3_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>312</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_V3']/@posX">
        <xsl:attribute name='posX'>174.663</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V3']/@posY">
        <xsl:attribute name='posY'>369.576</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V3']/@gate_posX">
        <xsl:attribute name='gate_posX'>174.7598</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V3']/@gate_posY">
        <xsl:attribute name='gate_posY'>370.7729</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V3']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_V3}Boismanc Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V3']/@owner">
        <xsl:attribute name='owner'>Faction.clan_vlandia_3</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V3_2']/@posX">
        <xsl:attribute name='posX'>185.107</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V3_2']/@posY">
        <xsl:attribute name='posY'>375.822</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V3_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_VD5}Mot</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V3_1']/@posX">
        <xsl:attribute name='posX'>170.209</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V3_1']/@posY">
        <xsl:attribute name='posY'>374.64</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V3_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_VD6}Boismanc</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V2_1']/@posX">
        <xsl:attribute name='posX'>137.521</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V2_1']/@posY">
        <xsl:attribute name='posY'>421.554</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V2_2']/@posX">
        <xsl:attribute name='posX'>131.960</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V2_2']/@posY">
        <xsl:attribute name='posY'>430.580</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_V6']/@posX">
        <xsl:attribute name='posX'>155.710</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V6']/@posY">
        <xsl:attribute name='posY'>438.634</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V6']/@gate_posX">
        <xsl:attribute name='gate_posX'>156.6978</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V6']/@gate_posY">
        <xsl:attribute name='gate_posY'>437.902</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V6']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_V6}Calfeld Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V6_1']/@posX">
        <xsl:attribute name='posX'>164.579</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V6_1']/@posY">
        <xsl:attribute name='posY'>431.105</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V6_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_VD10}Calfeld</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V6_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V6_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V6_2']/@posX">
        <xsl:attribute name='posX'>154.324</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V6_2']/@posY">
        <xsl:attribute name='posY'>425.222</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V6_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_VD11}Holzdorf</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_V7']/@posX">
        <xsl:attribute name='posX'>191.635</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V7']/@posY">
        <xsl:attribute name='posY'>439.510</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V7']/@gate_posX">
        <xsl:attribute name='gate_posX'>190.7112</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V7']/@gate_posY">
        <xsl:attribute name='gate_posY'>438.4026</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V7']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_V7}Rodetan Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V7_1']/@posX">
        <xsl:attribute name='posX'>177.604</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V7_1']/@posY">
        <xsl:attribute name='posY'>437.411</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V7_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.clay_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_V7_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.clay_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_V6']/@gate_posY">
        <xsl:attribute name='gate_posY'>392.1963</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V6_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V6_4']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V6_2']/@posX">
        <xsl:attribute name='posX'>159.1448</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V6_2']/@posY">
        <xsl:attribute name='posY'>385.2654</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V6_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_VD12}Surgroc</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V6_1']/@posX">
        <xsl:attribute name='posX'>154.452</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V6_1']/@posY">
        <xsl:attribute name='posY'>372.312</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V6_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_VD13}Arromanc</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V6_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V6_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_V1']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.town_V1}Velucad</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_V1_2']/@posX">
        <xsl:attribute name='posX'>208.379</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V1_2']/@posY">
        <xsl:attribute name='posY'>403.353</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_V1_2']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.village_V1_2}Etirburg</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_V7']/@posX">
        <xsl:attribute name='posX'>182.189</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_V7']/@posY">
        <xsl:attribute name='posY'>338.675</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_V7']/@gate_posX">
        <xsl:attribute name='gate_posX'>184.4817</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_V7']/@gate_posY">
        <xsl:attribute name='gate_posY'>342.4593</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_V1']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_V1}Wolleham Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_V1']/@owner">
        <xsl:attribute name='owner'>Faction.clan_vlandia_8</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_V1_1']/@posY">
        <xsl:attribute name='posY'>340.175</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_A1']/@posX">
        <xsl:attribute name='posX'>274.480</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A1']/@posY">
        <xsl:attribute name='posY'>279.924</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A1']/@gate_posX">
        <xsl:attribute name='gate_posX'>274.8722</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A1']/@gate_posY">
        <xsl:attribute name='gate_posY'>278.5858</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A1_1']/@posX">
        <xsl:attribute name='posX'>272.844</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A1_1']/@posY">
        <xsl:attribute name='posY'>287.565</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A1_2']/@posX">
        <xsl:attribute name='posX'>270.358</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A1_2']/@posY">
        <xsl:attribute name='posY'>266.958</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A1_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A1_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_A1']/@gate_posX">
        <xsl:attribute name='gate_posX'>300.6187</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_A1_4']/@posX">
        <xsl:attribute name='posX'>283.877</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A1_4']/@posY">
        <xsl:attribute name='posY'>255.748</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_A3']/@owner">
        <xsl:attribute name='owner'>Faction.clan_aserai_1</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A3_1']/@posX">
        <xsl:attribute name='posX'>315.278</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A3_1']/@posY">
        <xsl:attribute name='posY'>197.249</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.olive_trees</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.olive_trees</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A3_2']/@posX">
        <xsl:attribute name='posX'>322.492</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A3_2']/@posY">
        <xsl:attribute name='posY'>210.122</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A3_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_AS10}Bunqaz</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.silk_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.silk_plant</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_A7']/@posX">
        <xsl:attribute name='posX'>352.382</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A7']/@posY">
        <xsl:attribute name='posY'>201.012</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A7']/@gate_posX">
        <xsl:attribute name='gate_posX'>352.4443</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A7']/@gate_posY">
        <xsl:attribute name='gate_posY'>200.7701</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A7']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_A7}Aiwalitas Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A7_1']/@posX">
        <xsl:attribute name='posX'>367.816</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A7_1']/@posY">
        <xsl:attribute name='posY'>221.206</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A7_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_AS11}Uqba</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A7_2']/@posX">
        <xsl:attribute name='posX'>366.846</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A7_2']/@posY">
        <xsl:attribute name='posY'>203.129</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A7_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_AS12}Aiwalitas</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A7_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.silver_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A7_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.silver_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_A6']/@posX">
        <xsl:attribute name='posX'>401.65</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_A6']/@posY">
        <xsl:attribute name='posY'>207.33</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_A6']/@gate_posX">
        <xsl:attribute name='gate_posX'>399.13</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_A6']/@gate_posY">
        <xsl:attribute name='gate_posY'>206.80</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_A6_4']/@posX">
        <xsl:attribute name='posX'>398.587</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A6_4']/@posY">
        <xsl:attribute name='posY'>186.868</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_A9']/@posX">
        <xsl:attribute name='posX'>363.105</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A9']/@posY">
        <xsl:attribute name='posY'>163.472</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A9']/@gate_posX">
        <xsl:attribute name='gate_posX'>364.4925</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A9']/@gate_posY">
        <xsl:attribute name='gate_posY'>163.294</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A9']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_A9}Berihal Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A9']/@owner">
        <xsl:attribute name='owner'>Faction.clan_aserai_5</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A9_1']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_village_A9_1}Berihal</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A9_2']/@posX">
        <xsl:attribute name='posX'>367.295</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A9_2']/@posY">
        <xsl:attribute name='posY'>149.574</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A9_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A9_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_A7_2']/@posX">
        <xsl:attribute name='posX'>392.411</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A7_2']/@posY">
        <xsl:attribute name='posY'>108.728</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A7_2']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.village_A7_2}Kafr Hatif</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_A4']/@posX">
        <xsl:attribute name='posX'>445.269</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A4']/@posY">
        <xsl:attribute name='posY'>163.952</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A4']/@gate_posX">
        <xsl:attribute name='gate_posX'>444.23</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A4']/@gate_posY">
        <xsl:attribute name='gate_posY'>165.56</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A4_2']/@posX">
        <xsl:attribute name='posX'>449.639</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A4_2']/@posY">
        <xsl:attribute name='posY'>179.446</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A4_2']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_village_A4_2}Qednar</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A4_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A4_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_A3']/@posY">
        <xsl:attribute name='posY'>111.731</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_A3']/@gate_posX">
        <xsl:attribute name='gate_posX'>492.1278</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_A3']/@gate_posY">
        <xsl:attribute name='gate_posY'>114.4006</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_A3_1']/@posX">
        <xsl:attribute name='posX'>476.079</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A3_1']/@posY">
        <xsl:attribute name='posY'>117.393</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.date_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.date_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_A5']/@posX">
        <xsl:attribute name='posX'>520.643</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A5']/@posY">
        <xsl:attribute name='posY'>141.836</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A5']/@gate_posX">
        <xsl:attribute name='gate_posX'>522.2386</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A5']/@gate_posY">
        <xsl:attribute name='gate_posY'>142.3421</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A5_1']/@posX">
        <xsl:attribute name='posX'>530.43</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A5_2']/@posX">
        <xsl:attribute name='posX'>523.043</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A5_2']/@posY">
        <xsl:attribute name='posY'>129.500</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A5_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_AS15}Aiwyeh</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.salt_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.salt_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_A5_1']/@posX">
        <xsl:attribute name='posX'>577.838</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A5_1']/@posY">
        <xsl:attribute name='posY'>128.824</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_A5_2']/@posX">
        <xsl:attribute name='posX'>542.888</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A5_2']/@posY">
        <xsl:attribute name='posY'>122.697</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A5_2']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.village_A5_2}Aiwtas</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_A5_3']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.village_A5_3}Deir Hawa</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_A2']/@posX">
        <xsl:attribute name='posX'>637.89</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A2']/@posY">
        <xsl:attribute name='posY'>104.94</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A2']/@gate_posX">
        <xsl:attribute name='gate_posX'>639.48</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_A2']/@gate_posY">
        <xsl:attribute name='gate_posY'>105.63</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A2_2']/@posX">
        <xsl:attribute name='posX'>635.583</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A2_2']/@posY">
        <xsl:attribute name='posY'>125.730</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_A4']/@gate_posX">
        <xsl:attribute name='gate_posX'>610.5481</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_A4']/@gate_posY">
        <xsl:attribute name='gate_posY'>176.2253</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_A4_1']/@posX">
        <xsl:attribute name='posX'>605.103</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A4_1']/@posY">
        <xsl:attribute name='posY'>159.726</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_A4_2']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.village_A4_2}Mossom</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A8_1']/@posX">
        <xsl:attribute name='posX'>643.712</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A8_1']/@posY">
        <xsl:attribute name='posY'>220.047</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A8_2']/@posX">
        <xsl:attribute name='posX'>661.027</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A8_2']/@posY">
        <xsl:attribute name='posY'>203.985</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_A6']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_A6}Lamesa Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A6_1']/@posX">
        <xsl:attribute name='posX'>667.68</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A6_1']/@posY">
        <xsl:attribute name='posY'>257.53</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_A6_2']/@posX">
        <xsl:attribute name='posX'>659.135</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A6_2']/@posY">
        <xsl:attribute name='posY'>248.731</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.vineyard</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_A6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.vineyard</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_A2']/@posY">
        <xsl:attribute name='posY'>234.343</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_A2']/@gate_posX">
        <xsl:attribute name='gate_posX'>686.8181</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_A2']/@gate_posY">
        <xsl:attribute name='gate_posY'>236.229</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_A2_2']/@posX">
        <xsl:attribute name='posX'>703.03</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A2_2']/@posY">
        <xsl:attribute name='posY'>217.91</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A2_2']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.village_A2_2}Abou Khih</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_A2_3']/@posX">
        <xsl:attribute name='posX'>700.445</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_A2_3']/@posY">
        <xsl:attribute name='posY'>237.493</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_K6']/@posX">
        <xsl:attribute name='posX'>731.57</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K6']/@posY">
        <xsl:attribute name='posY'>583.23</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K6']/@gate_posX">
        <xsl:attribute name='gate_posX'>732.84</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K6']/@gate_posY">
        <xsl:attribute name='gate_posY'>582.23</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K6_1']/@posX">
        <xsl:attribute name='posX'>740.632</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K6_1']/@posY">
        <xsl:attribute name='posY'>576.513</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K6_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>413</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K6_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>413</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K6_2']/@posX">
        <xsl:attribute name='posX'>750.368</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K6_2']/@posY">
        <xsl:attribute name='posY'>593.291</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K6_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>413</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K6_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>413</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_K9']/@posX">
        <xsl:attribute name='posX'>712.93</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K9']/@posY">
        <xsl:attribute name='posY'>549.42</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K9']/@gate_posX">
        <xsl:attribute name='gate_posX'>713.71</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K9']/@gate_posY">
        <xsl:attribute name='gate_posY'>550.68</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K9_1']/@posX">
        <xsl:attribute name='posX'>710.84</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K9_1']/@posY">
        <xsl:attribute name='posY'>540.15</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K9_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>339</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K9_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>339</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_K1']/@posX">
        <xsl:attribute name='posX'>732.485</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_K1']/@posY">
        <xsl:attribute name='posY'>536.545</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_K1']/@gate_posX">
        <xsl:attribute name='gate_posX'>730.3407</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_K1']/@gate_posY">
        <xsl:attribute name='gate_posY'>536.892</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K1_2']/@posX">
        <xsl:attribute name='posX'>726.58</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K1_2']/@posY">
        <xsl:attribute name='posY'>549.436</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K1_4']/@posX">
        <xsl:attribute name='posX'>723.708</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K1_4']/@posY">
        <xsl:attribute name='posY'>522.759</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K1_4']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>435</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K1_4']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>435</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_K4']/@posX">
        <xsl:attribute name='posX'>719.82</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K4']/@posY">
        <xsl:attribute name='posY'>503.05</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K4']/@gate_posX">
        <xsl:attribute name='gate_posX'>718.69</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K4']/@gate_posY">
        <xsl:attribute name='gate_posY'>504.22</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K4_1']/@posX">
        <xsl:attribute name='posX'>713.592</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K4_1']/@posY">
        <xsl:attribute name='posY'>491.352</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K4_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>565</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K4_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>565</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K4_2']/@posX">
        <xsl:attribute name='posX'>704.884</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K4_2']/@posY">
        <xsl:attribute name='posY'>516.390</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K4_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>435</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K4_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>435</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_K3']/@gate_posY">
        <xsl:attribute name='gate_posY'>480.8119</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K3_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K3_2']/@posX">
        <xsl:attribute name='posX'>698.837</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K3_2']/@posY">
        <xsl:attribute name='posY'>500.489</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K3_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>209</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K3_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>209</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_K5']/@posX">
        <xsl:attribute name='posX'>683.269</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_K5']/@posY">
        <xsl:attribute name='posY'>422.582</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_K5']/@gate_posX">
        <xsl:attribute name='gate_posX'>684.5502</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_K5']/@gate_posY">
        <xsl:attribute name='gate_posY'>420.4101</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K5_2']/@posX">
        <xsl:attribute name='posX'>689.438</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K5_2']/@posY">
        <xsl:attribute name='posY'>406.916</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K5_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K5_3']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>427</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K5_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.trapper</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K5_3']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>427</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_K1']/@posX">
        <xsl:attribute name='posX'>703.36</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K1']/@posY">
        <xsl:attribute name='posY'>450.61</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K1']/@gate_posX">
        <xsl:attribute name='gate_posX'>704.86</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K1']/@gate_posY">
        <xsl:attribute name='gate_posY'>451.82</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K1']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_K1}Okukhy Castle</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K1_1']/@posX">
        <xsl:attribute name='posX'>712.347</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K1_1']/@posY">
        <xsl:attribute name='posY'>442.570</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K1_1']/@name">
        <xsl:attribute name='name'>{=CE_NV_KZ2}Okukhy</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K1_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.steppe_horse_ranch</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K1_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>121</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K1_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.steppe_horse_ranch</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K1_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>121</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K1_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>121</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K1_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>121</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_K5']/@posX">
        <xsl:attribute name='posX'>747.86</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K5']/@posY">
        <xsl:attribute name='posY'>484.29</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K5']/@gate_posX">
        <xsl:attribute name='gate_posX'>748.49</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K5']/@gate_posY">
        <xsl:attribute name='gate_posY'>482.88</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K5_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>463</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K5_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>463</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K5_2']/@posX">
        <xsl:attribute name='posX'>746.960</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K5_2']/@posY">
        <xsl:attribute name='posY'>493.346</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K5_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_KZ3}Rarojan</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K5_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>470</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K5_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>470</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K4_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K4_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K4_4']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>209</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K4_4']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>209</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_K3']/@posX">
        <xsl:attribute name='posX'>715.91</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K3']/@posY">
        <xsl:attribute name='posY'>406.10</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K3']/@gate_posX">
        <xsl:attribute name='gate_posX'>717.49</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K3']/@gate_posY">
        <xsl:attribute name='gate_posY'>406.76</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K3_2']/@posX">
        <xsl:attribute name='posX'>713.851</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K3_2']/@posY">
        <xsl:attribute name='posY'>397.271</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K3_2']/@name">
        <xsl:attribute name="name">{=CE_NV_KZ5}Tempuner</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K3_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>272</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K3_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K3_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>272</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K2_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>272</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K2_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>272</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_K2']/@gate_posX">
        <xsl:attribute name='gate_posX'>708.238</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K2']/@gate_posY">
        <xsl:attribute name='gate_posY'>371.524</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K2_2']/@posX">
        <xsl:attribute name='posX'>708.773</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K2_2']/@posY">
        <xsl:attribute name='posY'>359.499</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K2_2']/@name">
        <xsl:attribute name='name'>{=CE_NV_KZ8}Tikser</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.silk_plant</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K2_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.silk_plant</xsl:attribute>
    </xsl:template>

     <xsl:template match="Settlement[@id='castle_K8']/@posX">
        <xsl:attribute name='posX'>709.864</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K8']/@posY">
        <xsl:attribute name='posY'>319.847</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K8']/@gate_posX">
        <xsl:attribute name='gate_posX'>708.0017</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K8']/@gate_posY">
        <xsl:attribute name='gate_posY'>318.429</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K8']/@name">
        <xsl:attribute name='name'>{=Settlements.Settlement.name.castle_K8}Gereden Castle</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_K8']/@owner">
        <xsl:attribute name='owner'>Faction.clan_khuzait_8</xsl:attribute>
    </xsl:template>



    <xsl:template match="Settlement[@id='castle_village_K8_1']/@posX">
        <xsl:attribute name='posX'>705.396</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K8_1']/@posY">
        <xsl:attribute name='posY'>303.259</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K8_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K8_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>670</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K8_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K8_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>670</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K8_2']/@posX">
        <xsl:attribute name='posX'>703.419</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K8_2']/@posY">
        <xsl:attribute name='posY'>321.663</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='town_K6']/@posX">
        <xsl:attribute name='posX'>754.602</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_K6']/@posY">
        <xsl:attribute name='posY'>335.122</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_K6']/@gate_posX">
        <xsl:attribute name='gate_posX'>752.3246</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='town_K6']/@gate_posY">
        <xsl:attribute name='gate_posY'>334.0394</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K6_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>621</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K6_1']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>621</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K6_2']/@posX">
        <xsl:attribute name='posX'>742.093</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K6_2']/@posY">
        <xsl:attribute name='posY'>328.282</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.wheat_farm</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='village_K6_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.clay_mine</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='village_K6_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.clay_mine</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_K7']/@gate_posY">
        <xsl:attribute name='gate_posY'>377.9732</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K7_1']/@posX">
        <xsl:attribute name='posX'>781.218</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K7_1']/@posY">
        <xsl:attribute name='posY'>369.006</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='castle_village_K7_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>430</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='castle_village_K7_2']/Components/Village/@hearth">
        <xsl:attribute name='hearth'>430</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_forest_4']/@posX">
        <xsl:attribute name='posX'>229.00</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_forest_4']/@posY">
        <xsl:attribute name='posY'>404.48</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_forest_17']/@posX">
        <xsl:attribute name='posX'>217.38</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_forest_17']/@posY">
        <xsl:attribute name='posY'>599.77</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_seaside_2']/@posX">
        <xsl:attribute name='posX'>560.02</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_seaside_2']/@posY">
        <xsl:attribute name='posY'>512.06</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_seaside_3']/@posX">
        <xsl:attribute name='posX'>486.38</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_seaside_3']/@posY">
        <xsl:attribute name='posY'>474.04</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_seaside_8']/@posX">
        <xsl:attribute name='posX'>147.407</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_seaside_8']/@posY">
        <xsl:attribute name='posY'>605.2122</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_seaside_10']/@posX">
        <xsl:attribute name='posX'>98.17</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_seaside_10']/@posY">
        <xsl:attribute name='posY'>480.42</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_seaside_19']/@posX">
        <xsl:attribute name='posX'>365.19</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_seaside_19']/@posY">
        <xsl:attribute name='posY'>577.47</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_mountain_7']/@posX">
        <xsl:attribute name='posX'>383.112</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_mountain_7']/@posY">
        <xsl:attribute name='posY'>504.702</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_mountain_10']/@posX">
        <xsl:attribute name='posX'>196.131</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_mountain_10']/@posY">
        <xsl:attribute name='posY'>369.634</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_desert_2']/@posX">
        <xsl:attribute name='posX'>251.82</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_desert_2']/@posY">
        <xsl:attribute name='posY'>173.29</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_desert_8']/@posX">
        <xsl:attribute name='posX'>463.698</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_desert_8']/@posY">
        <xsl:attribute name='posY'>88.673</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_desert_12']/@posX">
        <xsl:attribute name='posX'>550.570</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_desert_12']/@posY">
        <xsl:attribute name='posY'>100.835</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_desert_14']/@posX">
        <xsl:attribute name='posX'>601.676</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_desert_14']/@posY">
        <xsl:attribute name='posY'>71.970</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_desert_16']/@posX">
        <xsl:attribute name='posX'>307.932</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_desert_16']/@posY">
        <xsl:attribute name='posY'>152.012</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_steppe_1']/@posX">
        <xsl:attribute name='posX'>815.016</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_steppe_1']/@posY">
        <xsl:attribute name='posY'>406.296</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_steppe_5']/@posX">
        <xsl:attribute name='posX'>738.12</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_steppe_5']/@posY">
        <xsl:attribute name='posY'>273.33</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_steppe_11']/@posX">
        <xsl:attribute name='posX'>689.06</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_steppe_11']/@posY">
        <xsl:attribute name='posY'>519.88</xsl:attribute>
    </xsl:template>


    <xsl:template match="Settlement[@id='hideout_steppe_13']/@posX">
        <xsl:attribute name='posX'>736.0339</xsl:attribute>
    </xsl:template>
    <xsl:template match="Settlement[@id='hideout_steppe_13']/@posY">
        <xsl:attribute name='posY'>514.2568</xsl:attribute>
    </xsl:template>



</xsl:stylesheet>