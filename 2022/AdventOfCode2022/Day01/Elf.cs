namespace Day01;

public class Elf
{
    public Elf(int id)
    {
        Id = id;
    }
    
    private List<int> Entries = new List<int>();
    public int Id { get; set; }

    public int TotalCalories
    {
        get { return Entries.Sum(e => e); }
    }

    public void AddEntry(int calories)
    {
        Entries.Add(calories);
    }

    public override string ToString()
    {
        return Id.ToString();
    }
}