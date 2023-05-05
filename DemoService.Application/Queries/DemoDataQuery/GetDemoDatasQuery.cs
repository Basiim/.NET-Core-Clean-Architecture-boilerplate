using DemoService.Common.Response;
using MediatR;

namespace DemoService.Application.Queries.DemoDataQuery
{
    public class GetDemoDatasQuery : IRequest<Response<DemoServiceResponse>>
    {
        public string Text { get; set; }
    }
}
