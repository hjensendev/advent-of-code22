using System.Security.Cryptography.X509Certificates;

namespace Day02;

public class Tournament
{
    public List<GameRound> GameRoundsPart1 = new List<GameRound>();
    public List<GameRound> GameRoundsPart2 = new List<GameRound>();
    public Tournament(string inputText)
    {
        var rounds = inputText.Split('\n');
        foreach (var round in rounds)
        {
            var hands = round.Split(' ');
            var opponentCode = hands[0].ToCharArray()[0];
            var myCode = hands[1].ToCharArray()[0];
            var gameRound1 = new GameRound(opponentCode, myCode, 1);
            var gameRound2 = new GameRound(opponentCode, myCode, 2);
            GameRoundsPart1.Add(gameRound1);
            GameRoundsPart2.Add(gameRound2);
        }
    }

    public int MyScorePart1
    {
        get
        {
            return GameRoundsPart1.Sum(r => r.MyScore);
        }
    }
    
    public int MyScorePart2
    {
        get
        {
            return GameRoundsPart2.Sum(r => r.MyScore);
        }
    }
}