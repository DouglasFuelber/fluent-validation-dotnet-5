using System.Text.RegularExpressions;

namespace FluentValidation.API.Validations
{
    public static class FluentExtensions
    {
        public static IRuleBuilderOptions<T, TElement> Phone<T, TElement>(this IRuleBuilder<T, TElement> ruleBuilder)
        {
            return ruleBuilder.Must((_, value, _) => value?.ToString().Length == 12 && Regex.IsMatch(value.ToString(), "^[0-9]*$"));
        }
    }
}