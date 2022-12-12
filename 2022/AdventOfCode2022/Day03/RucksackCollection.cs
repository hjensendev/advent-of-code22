using System.Net.WebSockets;

namespace Day03;

public class RucksackCollection
{
    public List<Rucksack> Rucksacks { get; } = new List<Rucksack>();

    public void AddRucksack(Rucksack rucksack)
    {
        Rucksacks.Add(rucksack);
    }

    public void ShowDuplicates()
    {
        foreach (var rucksack in Rucksacks)
        {
            foreach (var duplicate in rucksack.Duplicates)
            {
                Console.WriteLine($"{rucksack.Id}: {duplicate.Priority} ({duplicate.Name})");
            }
        }
    }

    public void ShowSumDuplicates()
    {
        var sum = 0;
        
        foreach (var rucksack in Rucksacks)
        {
            sum += rucksack.SumOfDuplicates;
        }

        Console.WriteLine($"The sum of duplicates is {sum}");
    }
}