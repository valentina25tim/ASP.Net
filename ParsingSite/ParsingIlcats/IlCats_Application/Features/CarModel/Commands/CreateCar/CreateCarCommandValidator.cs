using FluentValidation;

namespace IlCats_Application.Features.CarModel.Commands.CreateCar
{
    public class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
    {
        public CreateCarCommandValidator()
        {
            RuleFor(p => p.Model.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} can't be null")
                .MaximumLength(60).WithMessage("{PropertyName} can't be null");
        }
    }
}