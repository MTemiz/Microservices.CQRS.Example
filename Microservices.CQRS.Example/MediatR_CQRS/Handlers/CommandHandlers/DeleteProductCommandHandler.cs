using Microservices.CQRS.Example.Context;
using Microservices.CQRS.Example.Manual_CQRS.Commands.Requests;
using Microservices.CQRS.Example.Manual_CQRS.Commands.Responses;
using Microservices.CQRS.Example.Models;

namespace Microservices.CQRS.Example.Manual_CQRS.Handlers.CommandHandlers;

public class DeleteProductCommandHandler
{
    public DeleteProductCommandResponse Handle(DeleteProductCommandRequest command)
    {
        Product product = ApplicationDbContext.ProductList.FirstOrDefault(c => c.Id == command.Id);

        if (product != null)
        {
            ApplicationDbContext.ProductList.Remove(product);
        }

        return new DeleteProductCommandResponse()
        {
            IsSuccess = true
        };
    }
}