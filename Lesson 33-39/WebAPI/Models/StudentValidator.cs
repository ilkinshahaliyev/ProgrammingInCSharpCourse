using FluentValidation;

namespace WebAPI.Models
{
    public class StudentValidator : AbstractValidator<StudentDto>
    {
        public StudentValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(25);
            RuleFor(x => x.LastName)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(25);
            RuleFor(x => x.Salary)
                .NotEmpty()
                .GreaterThan(0)
                .InclusiveBetween(0, 200);
        }
    }
}
