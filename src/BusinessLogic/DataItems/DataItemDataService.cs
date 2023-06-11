using BusinessLogic.Authentication;
using BusinessLogic.Data;
using BusinessLogic.Results;
using BusinessLogic.Validation;

namespace BusinessLogic.DataItems;

public class DataItemDataService : IDataItemDataService
{
    private readonly IDataItemRepository _repository;
    private readonly IDataValidator<DataItemWriteModel> _validator;
    private readonly IAuthenticationService _authenticationService;

    public DataItemDataService(
        IDataItemRepository repository,
        IDataValidator<DataItemWriteModel> validator,
        IAuthenticationService authenticationService)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        _authenticationService = authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
    }

    public async Task<Result<int>> CreateAsync(DataItemWriteModel item)
    {
        var authResult = await _authenticationService.HasPermission(Permission.Write);
        if (!authResult.Success)
        {
            return Result<int>.FromError(authResult.Message);
        }

        var validationResult = await _validator.ValidateAsync(item);
        if (!validationResult.IsValid)
        {
            return Result<int>.FromError(validationResult.Error);
        }

        var repoResult = await _repository.CreateAsync(item);
        return repoResult;
    }

    public Task<Result> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Result<DataItemModel>> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Result<bool>> UpdateAsync(DataItemWriteModel item)
    {
        throw new NotImplementedException();
    }
}