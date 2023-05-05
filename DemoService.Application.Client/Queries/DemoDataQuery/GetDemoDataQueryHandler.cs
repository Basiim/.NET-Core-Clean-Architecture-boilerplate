using DemoService.Application.Queries.DemoDataQuery;
using DemoService.Common.Response;
using MediatR;

namespace DemoService.Application.Client.Queries.DemoDataQuery
{
    public class GetDemoDataQueryHandler : IRequestHandler<GetDemoDataQuery, Response<DemoServiceResponse>>
    {
        private readonly IMediator _mediator;
        public GetDemoDataQueryHandler(IMediator mediator) {
            _mediator = mediator;
        }
        public async Task<Response<DemoServiceResponse>> Handle(GetDemoDataQuery request, CancellationToken cancellationToken)
        {
            var query = PrepareQuery(request);
            var res = await _mediator.Send(query, cancellationToken);
            return PrepareResponse(res);
        }

        private static GetDemoDatasQuery PrepareQuery(GetDemoDataQuery request)
        {
            var query = new GetDemoDatasQuery() { Text = request.Text };
            return query;
        }

        private Response<DemoServiceResponse> PrepareResponse(Response<DemoServiceResponse> res)
        {
            return new Response<DemoServiceResponse> { Result = res.Result, Message = "Message recieved successfully", Successful = true };
        }


    }
}
