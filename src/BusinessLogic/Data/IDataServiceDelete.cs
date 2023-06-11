using BusinessLogic.Results;

namespace BusinessLogic.Data;

public interface IDataServiceDelete
{
	Task<Result> DeleteAsync(int id);
}