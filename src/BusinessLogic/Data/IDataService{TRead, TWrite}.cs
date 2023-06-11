namespace BusinessLogic.Data;

// TRead and TWrite could be constraintet based on prerequisites the data objects have to fulfill.
public interface IDataService<TRead, TWrite> : IDataServiceGetById<TRead>, IDataServiceWrite<TWrite>, IDataServiceDelete
{
}