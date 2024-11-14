using Microservices.CQRS.Example.Context;
using Microservices.CQRS.Example.Manual_CQRS.Queries.Requests;
using Microservices.CQRS.Example.Manual_CQRS.Queries.Responses;

namespace Microservices.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers;

public class GetAllProductQueryHandler
{
    public List<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request)
    {
        var productList = ApplicationDbContext.ProductList.Select(c => new GetAllProductQueryResponse()
        {
            Id = c.Id,
            Name = c.Name,
            CreatedAt = c.CreatedAt,
            Price = c.Price,
            Quantity = c.Quantity
        }).ToList();

        return productList;
    }
}