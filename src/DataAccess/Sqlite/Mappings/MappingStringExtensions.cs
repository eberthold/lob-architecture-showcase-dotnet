namespace DataAccess.Mappings;

public static class MappingStringExtensions
{
    public static string? ToEntity(this string? source)
    {
        if (string.IsNullOrWhiteSpace(source))
        {
            return null;
        }

        return source;
    }

    public static string ToModel(this string? source)
    {
       if (source is null)
       {
           return string.Empty;
       }

       return source;
    }
}