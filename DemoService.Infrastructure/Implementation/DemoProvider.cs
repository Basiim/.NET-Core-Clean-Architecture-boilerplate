using DemoService.Application.Implementation;
using DemoService.Application.Queries.DemoDataQuery;
using DemoService.Common.Response;
using DemoService.Infrastructure.Interfaces;

namespace DemoService.Infrastructure.Implementation
{
    public class DemoProvider : DemoServiceProviderBase, IDemoProvider
    {
        private readonly IDemo _demo;
        public DemoProvider(IDemo demo) { _demo = demo; }
        public override async Task<DemoServiceResponse> GetDemoData(GetDemoDatasQuery reqQuery)
        => await _demo.GetDemoData(reqQuery);

        public override async Task<DemoServiceResponse> GetDemoData(int id)
        => await _demo.GetDemoData(id);
    }
}
