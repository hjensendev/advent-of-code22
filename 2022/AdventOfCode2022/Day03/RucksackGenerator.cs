
namespace Day03;

public static class RucksackGenerator
{
    public static RucksackCollection CreateRucksacks(string input)
    {
        var collection = new RucksackCollection();
        var groupId = 1;
        var id = 0;
        var groupMembers = 0;

        var arrayOfItems  = input.Split('\n');
        foreach (var items in arrayOfItems)
        {
            id++;
            groupMembers++;
            collection.AddRucksack(new Rucksack(id, groupId, items));

            if (groupMembers == 3)
            {
                groupId++;
                groupMembers = 0;
            }
        }
        return collection;
    }
}