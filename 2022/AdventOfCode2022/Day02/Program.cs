using Day02;

var tournament = new Tournament(CustomInput.MyText);
foreach (var gameRound in tournament.GameRoundsPart2)
{
        Console.WriteLine(gameRound.ToString());
}

Console.WriteLine($"My Score in part 1: {tournament.MyScorePart1}");
Console.WriteLine($"My Score in part 2: {tournament.MyScorePart2}");