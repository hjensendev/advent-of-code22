using Day01;

var debug = false;
var input = CustomInput.Text;
var ledger = new Ledger(input);

if (debug)
{
    foreach (var elf in ledger.Elves)
    {   
        Console.WriteLine($"Elf {elf.Id} has {elf.TotalCalories} calories");
    } 
}

var maxElf = ledger.GetElfWithMostCalories();
var top3Elves = ledger.GetTop3ElfWithMostCalories();

Console.WriteLine($"Elf {maxElf.Id} has the highest number of calories, with {maxElf.TotalCalories} calories.");

var calCount = 0;
foreach(var elf in top3Elves)
{
    calCount += elf.TotalCalories;
    Console.WriteLine($"Top3 Elf {elf.Id} has {elf.TotalCalories} calories");
}

Console.WriteLine($"Top 3 has a total of {calCount} calories");