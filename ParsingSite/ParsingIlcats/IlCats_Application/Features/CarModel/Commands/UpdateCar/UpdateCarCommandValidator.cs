using FluentValidation;

namespace IlCats_Application.Features.CarModel.Commands.UpdateCar
{
    public class UpdateCarCommandValidator : AbstractValidator<UpdateCarCommand>
    {
        public UpdateCarCommandValidator()
        {
            RuleFor(p => p.Model.Name)
                .NotEmpty().WithMessage("{PropertyFName} is required")
                .NotNull().WithMessage("{PropertyFName} can't be null")
                .MaximumLength(50).WithMessage("{PropertyFName} can't be null");
        }
    }
}