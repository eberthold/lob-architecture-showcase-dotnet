using BusinessLogic.Results;

namespace BusinessLogic.Repositories;

public interface IRepositoryDelete
{
	Task<Result> DeleteAsync(int id);
}