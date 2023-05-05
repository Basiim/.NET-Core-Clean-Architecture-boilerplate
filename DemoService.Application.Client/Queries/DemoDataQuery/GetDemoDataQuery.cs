using DemoService.Common.Response;
using MediatR;

namespace DemoService.Application.Client.Queries.DemoDataQuery
{
    public class GetDemoDataQuery : IRequest<Response<DemoServiceResponse>>
    {
        public string Text { get; set; }
    }
}
