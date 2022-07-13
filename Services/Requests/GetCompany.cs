using System;
using CHAP.Services;
using CHAP.Models;
namespace CHAP.Services.Requests
{
    public class GetCompany
    {
        private readonly IConfiguration _config;

        public GetCompany(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<Company> GetCompanyById(string companyNumber)
        {
            var company = new Company();
            if (!string.IsNullOrWhiteSpace(companyNumber))
            {
                var baseUrl = _config.GetValue<string>("baseUrl");
                var apiKey = _config.GetValue<string>("api-key");

                if (string.IsNullOrWhiteSpace(apiKey)) throw new Exception("APIKey Missing");
                if (string.IsNullOrWhiteSpace(baseUrl)) throw new Exception("API URL Missing");

                string path = baseUrl + "company/";

                var request = new CompanyRequest();
                company = await request.GetCompanyData(apiKey, path, companyNumber);
            }
            return company;
        }
    }
}

