using MingweiSamuel.Camille.ChampionMasteryV4;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille;
using CamilleAPI.Utilities;

namespace CamilleAPI
{
    public static class Controller
    {
        public static void Run()
        {
            GetData();
        }

        private static void GetData()
        {
            var playerUsernameSearch = "SimpingForLeona";

            RiotApi client = RiotApi.NewInstance("RGAPI-31144f19-5550-4d27-a75e-51e668fcc286");

            var player = client.SummonerV4.GetBySummonerName(Region.EUNE, playerUsernameSearch);

            var playerChampions = client.ChampionMasteryV4.GetAllChampionMasteries(Region.EUNE, player.Id);

            Console.WriteLine($"Player {playerUsernameSearch} | ID: {player.Id}");
            Console.WriteLine("");
            Console.WriteLine("Champions:");
            foreach (var champMastery in playerChampions)
            {
                DisplayData(champMastery);
            }

            Console.ReadKey();
        }

        private static void DisplayData(ChampionMastery champMastery)
        {
            Console.WriteLine(new string(' ', 2)
                + "Champion => " + (ChampionNamesEnum)champMastery.ChampionId
                + " Level => " + champMastery.ChampionLevel
                + " Points => " + champMastery.ChampionPoints
                + " Chest Granted => " + champMastery.ChestGranted
                + " Tokens Earned => " + champMastery.TokensEarned);
        }
    }
}
