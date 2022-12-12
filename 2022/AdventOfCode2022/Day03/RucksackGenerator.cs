
namespace Day03;

public static class RucksackGenerator
{

    public static RucksackCollection CreateRucksacks(string input)
    {
        var collection = new RucksackCollection();
        var id = 0;

        var arrayOfItems  = input.Split('\n');
        foreach (var items in arrayOfItems)
        {
            id++;
            collection.AddRucksack(new Rucksack(id,items));
        }
        return collection;
    }
}