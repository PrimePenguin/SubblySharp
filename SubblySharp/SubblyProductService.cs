using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SubblySharp.Dto;

namespace SubblySharp
{
    public  class SubblyProductService
    {
        public readonly SubblyApiClient ApiClient;

        public SubblyProductService(string accessToken)
        {
            ApiClient = new SubblyApiClient(SubblyConsts.BaseUrl, accessToken);
        }

        public async Task<List<SubblyProduct>> GetAllSubblyProducts(SubblyFilter filter)
        {
            var products = new List<SubblyProduct>();

            while (true)
            {
                var response = await ApiClient.ExecuteAsync<SubblyProductsQuery>(HttpMethod.Get, SubblyConsts.ProductsUrl, filter);
                products.AddRange(response.SubblyProducts);

                if (products.Count % (SubblyConsts.Limit * 2) == 0) Thread.Sleep(3000);
                if (response.SubblyProducts.Count < SubblyConsts.Limit) break;

                filter.Page++;
            }

            return products;
        }
    }
}