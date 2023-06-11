namespace BusinessLogic.Validation;

public interface IDataValidator<T>
{
	Task<ValidationResult> ValidateAsync(T data);
}