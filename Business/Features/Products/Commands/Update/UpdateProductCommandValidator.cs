using FluentValidation;

namespace Business.Features.Products.Commands.Update
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(i => i.Name).NotEmpty();
        }
    }
}