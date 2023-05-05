using DemoService.Application.Interfaces;
using DemoService.Common.Response;
using MediatR;

namespace DemoService.Application.Queries.DemoDataQuery
{
    public class GetDemoDatasQueryHandler : IRequestHandler<GetDemoDatasQuery, Response<DemoServiceResponse>>
    {
        private readonly IDemoServiceProvider _serviceProvider;
        public GetDemoDatasQueryHandler(IDemoServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
        }
        public async Task<Response<DemoServiceResponse>> Handle(GetDemoDatasQuery request, CancellationToken cancellationToken)
        {
            var res = await _serviceProvider.GetDemoData(request);
            return PrepareResponse(res);
        }

        private Response<DemoServiceResponse> PrepareResponse(DemoServiceResponse res)
        {
            return new Response<DemoServiceResponse> { Result = res };
        }
    }
}
