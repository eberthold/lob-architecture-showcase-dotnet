using BusinessLogic.Results;

namespace BusinessLogic.Repositories;

public interface IRepositoryGetById<T>
{
	Task<Result<T>> GetByIdAsync(int id);
}