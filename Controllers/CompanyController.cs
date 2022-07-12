using Microsoft.AspNetCore.Mvc;

namespace CHAP.Controllers
{
    using Services;
    using Services.Requests;
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
                GetCompany request = new GetCompany(_config);
                var companyView = await request.GetCompanyById(companyNumber);

                return View(companyView);
            }
            return View();
        }
    }
}
