using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CHAP.Controllers
{
    using Services.Requests;
    public class AdvancedSearchController : Controller
    {
        // GET: /<controller>/
        private readonly IConfiguration _config;
        public AdvancedSearchController(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<IActionResult> Index(string searchParams)
        {
            if (!string.IsNullOrWhiteSpace(searchParams))
            {
                var request = new GetAdvancedSearch(_config);
                var searchView = await request.GetAdvancedSearchAsync(searchParams);

                return View(searchView);
            }
            return View();
        }
    }
}

