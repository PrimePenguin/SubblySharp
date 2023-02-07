using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SubblySharp.Dto;

namespace SubblySharp
{
    public class SubblyOrderService
    {
        public readonly SubblyApiClient ApiClient; 
        
        public SubblyOrderService(string accessToken)
        {
            ApiClient = new SubblyApiClient(SubblyConsts.BaseUrl, accessToken);
        }

        public async Task<List<SubblyOrder>> GetAllSubblyOrders(SubblyFilter filter)
        {
            var orders = new List<SubblyOrder>();
         
            while (true)
            {
                var response = await ApiClient.ExecuteAsync<SubblyOrdersQuery>(HttpMethod.Get, SubblyConsts.OrdersUrl, filter);
                orders.AddRange(response.SubblyOrders);

                if (orders.Count % (SubblyConsts.Limit * 2) == 0) Thread.Sleep(3000);
                if (response.SubblyOrders.Count  < SubblyConsts.Limit) break;

                filter.Page++;
            }

            return orders;
        }

        public async Task<SubblyOrder> GetSubblyOrder(string orderId)
        {
            return await ApiClient.ExecuteAsync<SubblyOrder>(HttpMethod.Get, $"{SubblyConsts.OrdersUrl}/{orderId}");
        }

        public async Task<SubblyResponse> UpdateSubblyOrder(SubblyOrderUpdateRequest updateRequest)
        {
            return await ApiClient.ExecuteAsync<SubblyResponse>(HttpMethod.Patch, $"{SubblyConsts.OrdersUrl}", updateRequest);
        }
    }
}
