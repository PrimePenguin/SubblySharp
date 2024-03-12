using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using SubblySharp.Dto;

namespace SubblySharp
{
    public class SubblyService
    {
        public readonly SubblyApiClient ApiClient;

        public SubblyService(string accessToken)
        {
            ApiClient = new SubblyApiClient(SubblyConsts.BaseUrl, accessToken);
        }

        public async Task<List<SubblyProduct>> GetAllProducts(SubblyFilter filter)
        {
            var products = new List<SubblyProduct>();
            while (true)
            {
                var response = await ApiClient.ExecuteAsync<SubblyProductsQuery>(HttpMethod.Get, SubblyConsts.ProductsUrl, filter);
                products.AddRange(response.SubblyProducts);

                if (response.SubblyProducts.Count != SubblyConsts.Limit) break;
                filter.Page++;
            }
            return products;
        }

        public async Task<List<SubblyOrder>> GetAllOrders(SubblyFilter filter)
        {
            var orders = new List<SubblyOrder>();
            while (true)
            {
                var response = await ApiClient.ExecuteAsync<SubblyOrdersQuery>(HttpMethod.Get, SubblyConsts.OrdersUrl, filter);
                orders.AddRange(response.SubblyOrders);

                if (response.SubblyOrders.Count != SubblyConsts.Limit) break;
                filter.Page++;
            }
            return orders;
        }

        public async Task<SubblyOrder> GetOrderById(string orderId)
        {
            return await ApiClient.ExecuteAsync<SubblyOrder>(HttpMethod.Get, $"{SubblyConsts.OrdersUrl}/{orderId}");
        }

        public async Task<SubblyResponse> UpdateOrder(SubblyOrderUpdateRequest updateRequest)
        {
            return await ApiClient.ExecuteAsync<SubblyResponse>(HttpMethod.Patch, $"{SubblyConsts.OrdersUrl}", updateRequest);
        }
    }
}
