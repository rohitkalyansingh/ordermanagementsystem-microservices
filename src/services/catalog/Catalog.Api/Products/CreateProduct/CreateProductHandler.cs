using MediatR;

namespace Catalog.Api.Products.CreateProduct
{

    public record CreateProductCommand(string name, List<string> Category, string description) : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid id);

    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
