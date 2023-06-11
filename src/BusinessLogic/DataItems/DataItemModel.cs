namespace BusinessLogic.DataItems;

public class DataItemModel
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string ReadOnlyProperty { get; set; } = string.Empty;
}