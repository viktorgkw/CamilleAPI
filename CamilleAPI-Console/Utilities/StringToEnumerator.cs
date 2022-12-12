namespace CamilleAPI.Utilities
{
    public static class StringToEnumerator
    {
        public static void ChampionIdsToEnumerator()
        {
            string text = "    266: Aatrox\r\n\r\n    103: Ahri\r\n\r\n    84: Akali\r\n\r\n    166: Akshan\r\n\r\n    12: Alistar\r\n\r\n    32: Amumu\r\n\r\n    34: Anivia\r\n\r\n    1: Annie\r\n\r\n    523: Aphelios\r\n\r\n    22: Ashe\r\n\r\n    136: Aurelion Sol\r\n\r\n    268: Azir\r\n\r\n    432: Bard\r\n\r\n    200: Bel'Veth\r\n\r\n    53: Blitzcrank\r\n\r\n    63: Brand\r\n\r\n    201: Braum\r\n\r\n    51: Caitlyn\r\n\r\n    164: Camille\r\n\r\n    69: Cassiopeia\r\n\r\n    31: Cho'Gath\r\n\r\n    42: Corki\r\n\r\n    122: Darius\r\n\r\n    131: Diana\r\n\r\n    119: Draven\r\n\r\n    36: Dr. Mundo\r\n\r\n    245: Ekko\r\n\r\n    60: Elise\r\n\r\n    28: Evelynn\r\n\r\n    81: Ezreal\r\n\r\n    9: Fiddlesticks\r\n\r\n    114: Fiora\r\n\r\n    105: Fizz\r\n\r\n    3: Galio\r\n\r\n    41: Gangplank\r\n\r\n    86: Garen\r\n\r\n    150: Gnar\r\n\r\n    79: Gragas\r\n\r\n    104: Graves\r\n\r\n    887: Gwen\r\n\r\n    120: Hecarim\r\n\r\n    74: Heimerdinger\r\n\r\n    420: Illaoi\r\n\r\n    39: Irelia\r\n\r\n    427: Ivern\r\n\r\n    40: Janna\r\n\r\n    59: Jarvan IV\r\n\r\n    24: Jax\r\n\r\n    126: Jayce\r\n\r\n    202: Jhin\r\n\r\n    222: Jinx\r\n\r\n    145: Kai'Sa\r\n\r\n    429: Kalista\r\n\r\n    43: Karma\r\n\r\n    30: Karthus\r\n\r\n    38: Kassadin\r\n\r\n    55: Katarina\r\n\r\n    10: Kayle\r\n\r\n    141: Kayn\r\n\r\n    85: Kennen\r\n\r\n    121: Kha'Zix\r\n\r\n    203: Kindred\r\n\r\n    240: Kled\r\n\r\n    96: Kog'Maw\r\n\r\n    897: K'Sante\r\n\r\n    7: LeBlanc\r\n\r\n    64: Lee Sin\r\n\r\n    89: Leona\r\n\r\n    876: Lillia\r\n\r\n    127: Lissandra\r\n\r\n    236: Lucian\r\n\r\n    117: Lulu\r\n\r\n    99: Lux\r\n\r\n    54: Malphite\r\n\r\n    90: Malzahar\r\n\r\n    57: Maokai\r\n\r\n    11: Master Yi\r\n\r\n    21: Miss Fortune\r\n\r\n    62: Wukong\r\n\r\n    82: Mordekaiser\r\n\r\n    25: Morgana\r\n\r\n    267: Nami\r\n\r\n    75: Nasus\r\n\r\n    111: Nautilus\r\n\r\n    518: Neeko\r\n\r\n    76: Nidalee\r\n\r\n    895: Nilah\r\n\r\n    56: Nocturne\r\n\r\n    20: Nunu & Willump\r\n\r\n    2: Olaf\r\n\r\n    61: Orianna\r\n\r\n    516: Ornn\r\n\r\n    80: Pantheon\r\n\r\n    78: Poppy\r\n\r\n    555: Pyke\r\n\r\n    246: Qiyana\r\n\r\n    133: Quinn\r\n\r\n    497: Rakan\r\n\r\n    33: Rammus\r\n\r\n    421: Rek'Sai\r\n\r\n    526: Rell\r\n\r\n    888: Renata Glasc\r\n\r\n    58: Renekton\r\n\r\n    107: Rengar\r\n\r\n    92: Riven\r\n\r\n    68: Rumble\r\n\r\n    13: Ryze\r\n\r\n    360: Samira\r\n\r\n    113: Sejuani\r\n\r\n    235: Senna\r\n\r\n    147: Seraphine\r\n\r\n    875: Sett\r\n\r\n    35: Shaco\r\n\r\n    98: Shen\r\n\r\n    102: Shyvana\r\n\r\n    27: Singed\r\n\r\n    14: Sion\r\n\r\n    15: Sivir\r\n\r\n    72: Skarner\r\n\r\n    37: Sona\r\n\r\n    16: Soraka\r\n\r\n    50: Swain\r\n\r\n    517: Sylas\r\n\r\n    134: Syndra\r\n\r\n    223: Tahm Kench\r\n\r\n    163: Taliyah\r\n\r\n    91: Talon\r\n\r\n    44: Taric\r\n\r\n    17: Teemo\r\n\r\n    412: Thresh\r\n\r\n    18: Tristana\r\n\r\n    48: Trundle\r\n\r\n    23: Tryndamere\r\n\r\n    4: Twisted Fate\r\n\r\n    29: Twitch\r\n\r\n    77: Udyr\r\n\r\n    6: Urgot\r\n\r\n    110: Varus\r\n\r\n    67: Vayne\r\n\r\n    45: Veigar\r\n\r\n    161: Vel'Koz\r\n\r\n    711: Vex\r\n\r\n    254: Vi\r\n\r\n    234: Viego\r\n\r\n    112: Viktor\r\n\r\n    8: Vladimir\r\n\r\n    106: Volibear\r\n\r\n    19: Warwick\r\n\r\n    498: Xayah\r\n\r\n    101: Xerath\r\n\r\n    5: Xin Zhao\r\n\r\n    157: Yasuo\r\n\r\n    777: Yone\r\n\r\n    83: Yorick\r\n\r\n    350: Yuumi\r\n\r\n    154: Zac\r\n\r\n    238: Zed\r\n\r\n    221: Zeri\r\n\r\n    115: Ziggs\r\n\r\n    26: Zilean\r\n\r\n    142: Zoe\r\n\r\n    143: Zyra";

            string[] textArr = text.Split("    ");

            foreach (var line in textArr)
            {
                if (line == "")
                {
                    continue;
                }
                var lineData = line.Split(": ");
                int trimStartIndex = lineData[1].IndexOf("\r");
                if (trimStartIndex == -1)
                {
                    Console.WriteLine(lineData[1] + " = " + lineData[0] + ",");
                    continue;
                }
                Console.WriteLine(lineData[1].Substring(0, trimStartIndex) + " = " + lineData[0] + ",");
            }
        }
    }
}
