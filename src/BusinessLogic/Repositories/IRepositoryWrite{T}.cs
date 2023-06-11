using BusinessLogic.Results;

namespace BusinessLogic.Repositories;

public interface IRepositoryWrite<T>
{
	Task<Result<int>> CreateAsync(T item);

	Task<Result> UpdateAsync(T item);
}