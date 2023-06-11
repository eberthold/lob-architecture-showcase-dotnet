using BusinessLogic.Results;

namespace BusinessLogic.Repositories;

public interface IRepositoryGetAll<T>
{
    Task<Result<IReadOnlyCollection<T>>> GetAllAsync();
}