using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using CHAP.Models;
using System.Text;


namespace CHAP.Services
{
    public class CHAPIRequest
    {
        private readonly IConfiguration _config;

        public CHAPIRequest(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<Company> GetCompanyId(string path, string searchParam)
        {
            var company = new Company();
            var apiKey = _config.GetValue<string>("api-key");
            if (string.IsNullOrWhiteSpace(apiKey)) throw new Exception("APIKey Missing");
            
            if (!string.IsNullOrWhiteSpace(searchParam)
                && !string.IsNullOrWhiteSpace(path))
            {
                var baseUrl = _config.GetValue<string>("baseUrl");
                
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl);
                    client.DefaultRequestHeaders.Clear();

                    var byteArray = Encoding.ASCII.GetBytes(apiKey);

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(byteArray));

                    //Sending request to find web api REST service resource using HttpClient
                    HttpResponseMessage Res = await client.GetAsync(path + searchParam);

                    //Checking the response is successful or not which is sent using HttpClient
                    if (Res.IsSuccessStatusCode)
                    {
                        //Storing the response details recieved from web api
                        var CHResponse = Res.Content.ReadAsStringAsync().Result;
                        company = JsonConvert.DeserializeObject<Company>(CHResponse);
                    }

                }
            }
            return company;
        }
        
    }
}

