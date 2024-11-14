using Microservices.CQRS.Example.Context;
using Microservices.CQRS.Example.Manual_CQRS.Queries.Requests;
using Microservices.CQRS.Example.Manual_CQRS.Queries.Responses;

namespace Microservices.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers;

public class GetByIdProductQueryHandler
{
    public GetByIdProductQueryResponse Handle(GetByIdProductQueryRequest request)
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