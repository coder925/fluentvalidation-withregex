using FluentValidation;

public class StudentValidator : AbstractValidator<Student>
{
    public StudentValidator()
    {
        this.RuleFor(a => a.Recipient).SetValidator(new ContactInfoValidator());
    }
}
