using FluentValidation;

public static class InternationalPhoneValidators
{
    public static IRuleBuilderOptions<T, string> InternationalPhoneValidator<T>(
        this IRuleBuilder<T, string> ruleBuilder)
    {
        var result = ruleBuilder.Matches(@"^$|\+(?:[0-9] ?){6,14}[0-9]").WithMessage("The phone number is not in an international format.");
        return result;
    }
}