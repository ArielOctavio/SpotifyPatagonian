using Newtonsoft.Json;
using RestSharp;
using ServiceProject.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace ServiceProject.Helpers
{
    public class SearchHelper
    {
        public static Token token { get; set; }

        public static async Task GetTokenAsync()
        {

            #region SecretVault
            string clientID = WebConfigurationManager.AppSettings["ClientID"].ToString();

            string clientSecret = WebConfigurationManager.AppSettings["ClientSecret"].ToString();
            #endregion

            string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(clientID + ":" + clientSecret));

            List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            };

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {auth}");
            HttpContent content = new FormUrlEncodedContent(args);

            HttpResponseMessage resp = await client.PostAsync("https://accounts.spotify.com/api/token", content);
            string msg = await resp.Content.ReadAsStringAsync();

            token = JsonConvert.DeserializeObject<Token>(msg);
        }

        public static Root SearchTrack(string cadena)
        {
            if (token == null)
            {
                GetTokenAsync().Wait();
            }
            var client = new RestClient("https://api.spotify.com/v1/search");

            client.AddDefaultHeader("Authorization", $"Bearer {token.access_token}");

            var request = new RestRequest($"?q={cadena}&type=track&limit=15", Method.GET);

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var result = JsonConvert.DeserializeObject<Root>(response.Content);

                return result;
            }
            else
            {
                return null;
            }
        }

    }
}