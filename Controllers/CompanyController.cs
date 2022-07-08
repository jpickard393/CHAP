using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using CHAP.Models;
using System.Text;

namespace CHAP.Controllers
{
    public class CompanyController : Controller
    {
        string baseUrl = "https://api.company-information.service.gov.uk";
        string testCompany = "02312959";

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            // ToDo:  put this is class
            // put test company in app settings
            // put key in envronment variable
                
            var company = new Company();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();

                var byteArray = Encoding.ASCII.GetBytes("811bff84-d342-49c4-a65d-eab51efc058c");
                
                //Define request data format
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                HttpResponseMessage Res = await client.GetAsync("company/" + testCompany);

                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var CHResponse = Res.Content.ReadAsStringAsync().Result;
                    company = JsonConvert.DeserializeObject<Company>(CHResponse);
                }
                //returning the employee list to view
                return View(company);
            }
        }
    }
}

