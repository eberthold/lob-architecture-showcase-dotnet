using System.ComponentModel.DataAnnotations;

namespace DataAccess.DataItems;

public class DataItemSubEntity
{
    [Key]
    public int Id { get; set; }
}