namespace Sample
{
    using FluentValidation;

    public class TeacherValidator : AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            this.RuleFor(a => a.ContactInfo).SetValidator(new ContactInfoValidator());
        }
    }
}