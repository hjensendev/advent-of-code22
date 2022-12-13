using System.Net.WebSockets;

namespace Day03;

public class RucksackCollection
{
    public List<Rucksack> Rucksacks { get; } = new List<Rucksack>();

    public List<Group> Groups { get; } = new List<Group>();

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
                Console.WriteLine($"{rucksack.GroupId}/{rucksack.Id}: {duplicate.Priority} ({duplicate.Name})");
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

    public void ShowGroupsBadge()
    {
        var groupCount = Rucksacks.MaxBy(r => r.GroupId)?.GroupId ?? 0;
        Console.WriteLine($"There are {groupCount} groups");
        
        for (var i = 1; i <= groupCount; i++)
        {
            
            var members = Rucksacks.Where(r => r.GroupId == i).ToList();
            if (members.Count != 3)
                throw new Exception($"Invalid group with {members.Count } members");

            var dup1 = members[0].Items.Intersect(members[1].Items).ToList();
            var duplicateItems = members[2].Items.Intersect(dup1).ToList();
            if (duplicateItems.Count != 1)
                throw new Exception($"Invalid group item count with {duplicateItems } duplicate items");
                
            var badge = duplicateItems.First();
            Console.WriteLine($"{i}: {badge.Priority} ({badge.Name})");
            var group = new Group(i, badge);
            Groups.Add(group);
        }
    }
    
    public void ShowSumOfGroups()
    {
        var sum = 0;
        
        foreach (var group in Groups)
        {
            sum += group.Priority;
        }

        Console.WriteLine($"The sum of all groups is {sum}");
    }
}