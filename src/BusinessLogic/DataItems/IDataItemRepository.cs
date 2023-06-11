using BusinessLogic.Repositories;

namespace BusinessLogic.DataItems;

public interface IDataItemRepository : IRepository<DataItemModel, DataItemWriteModel>
{
}