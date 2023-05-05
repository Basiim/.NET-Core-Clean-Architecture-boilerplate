using DemoService.Application.Interfaces;
using DemoService.Common.Response;
using MediatR;

namespace DemoService.Application.Commands.DemoDatasCommand
{
    public class GetDemoDatasCommandHandler : IRequestHandler<GetDemoDatasCommand, Response<DemoServiceResponse>>
    {
        private readonly IDemoServiceProvider _serviceProvider;
        public GetDemoDatasCommandHandler(IDemoServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public async Task<Response<DemoServiceResponse>> Handle(GetDemoDatasCommand request, CancellationToken cancellationToken)
        {
            var res = await _serviceProvider.GetDemoData(Convert.ToInt32(request.Text));
            return PrepareResponse(res);
        }
        private Response<DemoServiceResponse> PrepareResponse(DemoServiceResponse res)
        {
            return new Response<DemoServiceResponse> { Result = res };
        }
    }
}
