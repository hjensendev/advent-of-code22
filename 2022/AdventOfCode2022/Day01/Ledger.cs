

namespace Day01;

public class Ledger
{
    public List<Elf> Elves = new ();
    
    public Ledger(string list)
    {
        var elfCounter = 0;
        var ledgerAsArray = list.Split("\n\n");

        foreach (var entries in ledgerAsArray)
        {
            elfCounter++;
            var elf = new Elf(elfCounter);
            var entriesAsArray = entries.Split('\n');

            foreach (var elfEntry in entriesAsArray)
            {
                elf.AddEntry(Convert.ToInt32(elfEntry));
            }
            Elves.Add(elf);
        }
    }

    public Elf GetElfWithMostCalories()
    {
        return Elves.MaxBy(e => e.TotalCalories) ?? new Elf(0);
    }
    
    public List<Elf> GetTop3ElfWithMostCalories()
    {
        return Elves.OrderByDescending(e => e.TotalCalories).Take(3).ToList();
    }
}