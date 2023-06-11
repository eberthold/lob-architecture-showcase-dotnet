using BusinessLogic.Validation;

namespace BusinessLogic.DataItems;

public class DataItemValidator : IDataValidator<DataItemWriteModel>
{
    public Task<ValidationResult> ValidateAsync(DataItemWriteModel data)
    {
        if (string.IsNullOrWhiteSpace(data.Name))
        {
            return Task.FromResult(ValidationResult.FromError("name must not be emtpry"));
        }
        
        return Task.FromResult(ValidationResult.FromSucess());
    }
}