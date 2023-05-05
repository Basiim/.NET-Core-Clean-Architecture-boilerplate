using DemoService.Application.Interfaces;
using DemoService.Application.Queries.DemoDataQuery;
using DemoService.Common.Response;

namespace DemoService.Application.Implementation
{
    public abstract class DemoServiceProviderBase : IDemoServiceProvider
    {
        public abstract Task<DemoServiceResponse> GetDemoData(GetDemoDatasQuery reqQuery);
    }
}
