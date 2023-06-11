using BusinessLogic.Results;

namespace BusinessLogic.Data;

public interface IDataServiceGetById<T>
{
	Task<Result<T>> GetByIdAsync(int id);
}