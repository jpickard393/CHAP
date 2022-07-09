using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using CHAP;
using Microsoft.Extensions.Configuration;

namespace CHAP.Controllers
{
    using Services;
    public class CompanyController : Controller
    {
        private readonly IConfiguration _config;
        public CompanyController(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<IActionResult> Index(string companyNumber)
        {
            if(!string.IsNullOrWhiteSpace(companyNumber))
            {
                string path = "company/";
                CHAPIRequest request = new CHAPIRequest(_config);
                var companyView = await request.GetCompanyId(path, companyNumber);
                return View(companyView);
            }
            return View();
            
        }
    }
}
