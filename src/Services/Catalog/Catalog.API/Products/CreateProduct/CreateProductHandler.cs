using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    // record id used to define a special kind of reference type that is designed for storing data.
    // For creating immutable objects to model data transfer objects.

    /*
     This inherits from IRequest which is mediator. When mediator sees requests from API,
    it will trigger CreateProductCommandHandler
     */
    public record CreateProductCommand(string Name, List<string> Category,
        string Description, string ImageFile, decimal Price):ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // Business Logic to Create a Product
            var product = new Product()
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            // Save to database

            // return CreateProductResult result
            return new CreateProductResult(Guid.NewGuid());
        }
    }
}
