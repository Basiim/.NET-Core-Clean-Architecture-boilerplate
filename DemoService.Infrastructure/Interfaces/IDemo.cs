using DemoService.Application.Queries.DemoDataQuery;
using DemoService.Common.Response;

namespace DemoService.Infrastructure.Interfaces
{
    public interface IDemo
    {
        Task<DemoServiceResponse> GetDemoData(GetDemoDatasQuery query);
        Task<DemoServiceResponse> GetDemoData(int id);
    }
}
