using System.ComponentModel.DataAnnotations;

namespace DataAccess.DataItems;

public class DataItemEntity
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ReadOnlyProperty { get; set; }

    public List<DataItemSubEntity>? SubEntities { get; set; }
}