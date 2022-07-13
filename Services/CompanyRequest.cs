using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using CHAP.Models;
using System.Text;

namespace CHAP.Services
{
    public class CompanyRequest
    {
        public async Task<Company> GetCompanyData(string apiKey, string path, string searchParam)
        {
            var jsonResult = new Company();
            if (string.IsNullOrWhiteSpace(apiKey)) throw new Exception("APIKey Missing");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(path);
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
                    jsonResult = JsonConvert.DeserializeObject<Company>(CHResponse);
                }
            }
            return jsonResult;
        }
        
    }
}

