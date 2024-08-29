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
        string Description, string ImageFile, decimal Price):IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // Business Logic to Create a Product
            throw new NotImplementedException();
        }
    }
}
