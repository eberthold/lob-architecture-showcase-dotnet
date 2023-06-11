namespace DataAccess.Mappings;

public interface IMapper<TSource, TDestination>
{
    TDestination Map(TSource source);
}