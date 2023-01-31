using SubblySharp.Dto;
using SubblySharp.Filters;

namespace SubblySharp
{
    public  class SubblyProductService
    {
        public readonly SubblyApiClient ApiClient;

        public SubblyProductService(string accessToken)
        {
            ApiClient = new SubblyApiClient(SubblyConstants.BaseUrl, accessToken);
        }

        public async Task<List<SubblyProduct>> GetAllSubblyProducts(SubblyFilter filter)
        {
            var products = new List<SubblyProduct>();
            var url = SubblyConstants.ProductsUrl;
            filter.Page = 1;
            filter.PerPage = SubblyConstants.Limit;
            while (true)
            {
                var response = await ApiClient.ExecuteAsync<SubblyProducts>(HttpMethod.Get, url, filter);
                products.AddRange(response.Data);
                filter.Page++;

                if (products.Count % (SubblyConstants.Limit * 2) == 0) Thread.Sleep(3000);
                if (response.Data.Length < SubblyConstants.Limit) break;
            }

            return products;
        }

    }
}
