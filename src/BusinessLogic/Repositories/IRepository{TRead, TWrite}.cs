namespace BusinessLogic.Repositories;

public interface IRepository<TRead, TWrite> : IRepositoryGetById<TRead>, IRepositoryGetAll<TRead>, IRepositoryWrite<TWrite>, IRepositoryDelete
{
}