using FluentValidation;

public class ContactInfoValidator : AbstractValidator<ContactInfo>
{
    public ContactInfoValidator()
    {
        this.RuleFor(a => a.Phone).InternationalPhoneValidator();
    }
}
