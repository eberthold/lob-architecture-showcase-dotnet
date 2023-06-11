using BusinessLogic.Results;

namespace BusinessLogic.Data;

public interface IDataServiceWrite<T>
{
	Task<Result<int>> CreateAsync(T item);

	Task<Result<bool>> UpdateAsync(T item);
}