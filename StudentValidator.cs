using FluentValidation;

public class StudentValidator : AbstractValidator<Student>
{
    public StudentValidator()
    {
        this.RuleFor(a => a.ContactInfo).SetValidator(new ContactInfoValidator());
    }
}
