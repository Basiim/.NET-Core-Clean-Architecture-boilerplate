using DemoService.Common.Response;
using MediatR;

namespace DemoService.Application.Commands.DemoDatasCommand
{
    public class GetDemoDatasCommand : IRequest<Response<DemoServiceResponse>>
    {
        public string Text { get; set; }
    }
}
