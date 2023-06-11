using System.Collections.Immutable;

namespace BusinessLogic.Validation;

public record ValidationResult
{
    private ValidationResult()
    {
    }

    public bool IsValid { get; init; }

    public string Error { get; init; } = string.Empty;

    public static ValidationResult FromSucess()
    {
        return new ValidationResult
        {
            IsValid = true
        };
    }

    public static ValidationResult FromError(string error)
    {
        return new ValidationResult
        {
            IsValid = false,
            Error = error
        };
    }
}