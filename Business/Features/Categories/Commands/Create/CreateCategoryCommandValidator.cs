using FluentValidation;

namespace Business.Features.Categories.Commands.Create
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(i => i.CategoryName).NotEmpty().WithMessage("İsim alanı boş olamaz.");
        }
    }
}