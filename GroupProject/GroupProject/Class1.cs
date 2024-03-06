using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GroupProject
{
    public class SportsDbClient
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string BaseUrl = "https://www.thesportsdb.com/api/v1/json/3"; // Using test API key "3"

        public SportsDbClient()
        {
            _httpClient.BaseAddress = new Uri(BaseUrl);
        }

        public async Task<List<Player>> SearchPlayersByNameAsync(string playerName)
        {
            string url = $"{BaseUrl}/searchplayers.php?p={Uri.EscapeDataString(playerName)}";
            var jsonResponse = await _httpClient.GetStringAsync(url);

            if (!string.IsNullOrEmpty(jsonResponse))
            {
                var playersResponse = JsonConvert.DeserializeObject<PlayersResponse>(jsonResponse);
                return playersResponse?.player ?? new List<Player>();
            }
            else
            {
                throw new HttpRequestException("Failed to fetch data: No response received.");
            }
        }

        // Player class with expanded fields to match the API response
        public class Player
        {
            public string strPlayer { get; set; }
            public string strTeam { get; set; }
            public string strSport { get; set; }
            public string strNationality { get; set; }
            public string strPosition { get; set; }
            public string strBirthLocation { get; set; }
            public string dateBorn { get; set; }
            public string strSigning { get; set; }
            public string strWage { get; set; }
            public string strDescriptionEN { get; set; }
        }

        public class PlayersResponse
        {
            public List<Player> player { get; set; }
        }

        public class Team
        {
            public string strTeam { get; set; }
            public string strSport { get; set; }
            public string strPlayer { get; set; }
            public string strPosition { get; set; }
            public string strNationality { get; set; }
            public string strBirthLocation { get; set; }
            public string dateBorn { get; set; }
            public string strSigning { get; set; }
            public string strWage { get; set; }
        }
    }
}

