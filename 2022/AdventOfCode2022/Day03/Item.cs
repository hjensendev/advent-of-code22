namespace Day03;

public class Item : IEquatable<Item>
{
    public Item(char item)
    {
        Name = item;
    }
    public char Name { get; }

    public int Priority
    {
        get
        {
            var code = (int)Name;
            if (code >= 65 & code <= 90) // A-Z = 27-52
                return code - 38;
            if (code >= 97 & code <= 122) // a-z = 1-26
                return code - 96;
            throw new Exception("Invalid item in rucksack");
        }
    }

    public bool Equals(Item? other)
    {
        if (other == null) 
            return false;

        return this.Name == other.Name && this.Priority == other.Priority;
    }

    public override string ToString()
    {
        return $"{Name}:{Priority}";
    }

    public override bool Equals(object? obj) => Equals(obj as Item);

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}