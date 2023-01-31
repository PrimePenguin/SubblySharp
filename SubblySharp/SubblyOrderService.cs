using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SubblySharp.Dto;
using SubblySharp.Filters;

namespace SubblySharp
{
    public class SubblyOrderService
    {
        public readonly SubblyApiClient ApiClient; 
        
        public SubblyOrderService(string accessToken)
        {
            ApiClient = new SubblyApiClient(SubblyConstants.BaseUrl, accessToken);
        }

        public async Task<List<SubblyOrder>> GetAllSubblyOrders(SubblyFilter filter)
        {
            var orders = new List<SubblyOrder>();
            var url =SubblyConstants.OrdersUrl;
            filter.Page = 1;
            filter.PerPage = SubblyConstants.Limit;
            while (true)
            {
                var response = await ApiClient.ExecuteAsync<SubblyOrders>(HttpMethod.Get, url, filter);
                orders.AddRange(response.Data);
                filter.Page++;

                if (orders.Count % (SubblyConstants.Limit * 2) == 0) Thread.Sleep(3000);
                if (response.Data.Length  < SubblyConstants.Limit) break;
            }

            return orders;
        }


        public async Task<SubblyOrder> GetSubblyOrder(string orderId)
        {
            return await ApiClient.ExecuteAsync<SubblyOrder>(HttpMethod.Get, $"{SubblyConstants.OrdersUrl}/{orderId}");
        }

        public async Task<SubblyResponse> UpdateSubblyOrder(SubblyOrderUpdateRequest updateRequest)
        {
            return await ApiClient.ExecuteAsync<SubblyResponse>(HttpMethod.Patch, $"{SubblyConstants.OrdersUrl}", updateRequest);
        }
    }
}
