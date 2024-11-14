using Microservices.CQRS.Example.Context;
using Microservices.CQRS.Example.Manual_CQRS.Commands.Requests;
using Microservices.CQRS.Example.Manual_CQRS.Commands.Responses;
using Microservices.CQRS.Example.Models;

namespace Microservices.CQRS.Example.Manual_CQRS.Handlers.CommandHandlers;

public class CreateProductCommandHandler
{
    public CreateProductCommandResponse Handle(CreateProductCommandRequest command)
    {
        Guid productId = Guid.NewGuid();

        ApplicationDbContext.ProductList.Add(new Product()
        {
            Name = command.Name,
            Price = command.Price,
            CreatedAt = DateTime.Now,
            Id = productId,
            Quantity = command.Quantity
        });

        return new CreateProductCommandResponse()
        {
            Id = productId,
            IsSuccess = true
        };
    }
}