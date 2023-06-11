using BusinessLogic.DataItems;
using DataAccess.Mappings;

namespace DataAccess.DataItems;

public class DataItemMapper : IMapper<DataItemWriteModel, DataItemEntity>, IMapper<DataItemEntity, DataItemModel>
{
    public DataItemEntity Map(DataItemWriteModel source)
    {
        return new DataItemEntity
        {
            Id = source.Id,
            Name = source.Name.ToEntity()
        };
    }

    public DataItemModel Map(DataItemEntity source)
    {
        return new DataItemModel
        {
            Id = source.Id,
            Name = source.Name.ToModel()
        };
    }
}
