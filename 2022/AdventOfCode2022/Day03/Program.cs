using Day03;



Console.WriteLine("Challenge 1");
var collection = RucksackGenerator.CreateRucksacks(ChallengeInput.RealText);
collection.ShowDuplicates();
collection.ShowSumDuplicates();


Console.WriteLine("Challenge 2");
collection.ShowGroupsBadge();
collection.ShowSumOfGroups();