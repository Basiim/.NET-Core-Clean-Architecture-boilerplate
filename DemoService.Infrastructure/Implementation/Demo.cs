using DemoService.Application.Queries.DemoDataQuery;
using DemoService.Common.Response;
using DemoService.Infrastructure.Interfaces;

namespace DemoService.Infrastructure.Implementation
{
    public class Demo : IDemo
    {
        public async Task<DemoServiceResponse> GetDemoData(GetDemoDatasQuery query)
        {
            var res = new DemoServiceResponse() {
                
                Response = $"Hello {query.Text}"
            };
            return res;
        }

        public Task<DemoServiceResponse> GetDemoData(int id)
        {
            var res = new DemoServiceResponse()
            {

                Response = $"Hello World!"
            };
            return Task.FromResult(res);
        }
    }
}
