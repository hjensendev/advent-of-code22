namespace Day03;

public class Group
{
    public int Id { get; set; }
    public Item Item { get; set; }

    public Group(int id, Item item)
    {
        Id = id;
        Item = item;
    }
    
    public int Badge => Item.Name;

    public int Priority => Item.Priority;
}