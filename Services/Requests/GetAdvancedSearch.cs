using System;
namespace CHAP.Services.Requests
{
    using Models.AdvancedSearch;
    using Services.Requests;
    public class GetAdvancedSearch
    {
        private readonly IConfiguration _config;

        public GetAdvancedSearch(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<AdvancedSearch> GetAdvancedSearchAsync(string searchParams)
        {
            var search = new AdvancedSearch();
            if (!string.IsNullOrWhiteSpace(searchParams))
            {
                var baseUrl = _config.GetValue<string>("baseUrl");
                var apiKey = _config.GetValue<string>("api-key");

                if (string.IsNullOrWhiteSpace(apiKey)) throw new Exception("APIKey Missing");
                if (string.IsNullOrWhiteSpace(baseUrl)) throw new Exception("API URL Missing");

                string path = baseUrl + "advanced-search/companies?";

                var request = new AdvancedSearchRequest();
                search = await request.GetCompanyData(apiKey, path, searchParams);
            }
            return search;
        }
    }
}

