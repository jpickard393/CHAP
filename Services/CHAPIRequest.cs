using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using CHAP.Models;
using System.Text;
using System.Threading.Tasks;


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

            if (!string.IsNullOrWhiteSpace(searchParam) && !string.IsNullOrWhiteSpace(path))
            {
                var baseUrl = _config.GetValue<string>("baseUrl");
                
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl);
                    client.DefaultRequestHeaders.Clear();

                    var byteArray = Encoding.ASCII.GetBytes("811bff84-d342-49c4-a65d-eab51efc058c");

                    //Define request data format
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                    //Sending request to find web api REST service resource GetAllEmployees using HttpClient
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

