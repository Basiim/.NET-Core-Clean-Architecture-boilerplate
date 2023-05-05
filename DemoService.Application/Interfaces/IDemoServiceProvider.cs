using DemoService.Application.Queries.DemoDataQuery;
using DemoService.Common.Response;

namespace DemoService.Application.Interfaces
{
    public interface IDemoServiceProvider
    {
        Task<DemoServiceResponse> GetDemoData(GetDemoDatasQuery reqQuery);
        Task<DemoServiceResponse> GetDemoData(int id);
    }
}
