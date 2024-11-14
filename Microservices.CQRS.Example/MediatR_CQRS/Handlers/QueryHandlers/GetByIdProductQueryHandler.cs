using MediatR;
using Microservices.CQRS.Example.Context;
using Microservices.CQRS.Example.MediatR_CQRS.Queries.Requests;
using Microservices.CQRS.Example.MediatR_CQRS.Queries.Responses;

namespace Microservices.CQRS.Example.MediatR_CQRS.Handlers.QueryHandlers;

public class GetByIdQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
{
    public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request,
        CancellationToken cancellationToken)
    {
        var product = ApplicationDbContext.ProductList.FirstOrDefault(c => c.Id == request.Id);

        return new GetByIdProductQueryResponse()
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Quantity = product.Quantity,
            CreatedAt = product.CreatedAt
        };
    }
}