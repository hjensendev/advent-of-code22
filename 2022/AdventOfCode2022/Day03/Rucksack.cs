namespace Day03;

public class Rucksack
{
    public int Id;
    public List<Item> Compartment1 { get; set; } = new List<Item>();
    public List<Item> Compartment2 { get; set; } = new List<Item>();

    public Rucksack(int id, string items)
    {
        Id = id;
        var itemCount = items.Length;
        var c1Items = items.Substring(0, itemCount / 2);
        var c2Items = items.Substring(itemCount / 2);
        if (c1Items.Length != c2Items.Length)
            throw new Exception("Invalid number of items");

        foreach (var itemChar in c1Items.ToCharArray())
        {
                Compartment1.Add(new Item(itemChar));
        }
        foreach (var itemChar in c2Items.ToCharArray())
        {
            Compartment2.Add(new Item(itemChar));
        }
    }

    public void WriteContentToConsole()
    {
        foreach (var item in Compartment1)
        {
            Console.WriteLine($"{Id}:C1: {item.Name}({item.Priority})");
        }
        foreach (var item in Compartment2)
        {
            Console.WriteLine($"{Id}:C2: {item.Name}({item.Priority})");
        }
    }

    public List<Item> Duplicates
    {
        get
        {
            return Compartment1.Intersect(Compartment2).ToList();
        }
    }
    
    public int SumOfDuplicates
    {
        get
        {
            var duplicates =  Compartment1.Intersect(Compartment2).ToList();
            return duplicates.Sum(item => item.Priority);
        }
    }
    
}