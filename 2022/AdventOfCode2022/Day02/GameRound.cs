namespace Day02;

public class GameRound
{
    public GameRound(char opponentCode, char myCode, int part = 1)
    {
        if (part > 2)
            throw new ArgumentOutOfRangeException(nameof(part));
        
        OpponentGesture = RulesPart1.GetGestureForCode(opponentCode);
        
        if (part == 2)
        {
            var forcedOutcome = RulesPart2.GetOutcomeForCode(myCode);
            MyGesture = RulesPart2.ChooseResponse(OpponentGesture, forcedOutcome);
        }
        else
        {
            MyGesture = RulesPart1.GetGestureForCode(myCode);
        }
    }
    public HandGesture OpponentGesture { get; set; }
    public HandGesture MyGesture { get; set; }

    public RoundOutcome Outcome
    {
        get
        {
            // I choose Rock
            if (MyGesture == HandGesture.Rock && OpponentGesture == HandGesture.Rock)
                return RoundOutcome.Draw;
            if (MyGesture == HandGesture.Rock && OpponentGesture == HandGesture.Scissors)
                return RoundOutcome.Win;
            if (MyGesture == HandGesture.Rock && OpponentGesture == HandGesture.Paper)
                return RoundOutcome.Lost;

            // I choose Paper
            if (MyGesture == HandGesture.Paper && OpponentGesture == HandGesture.Paper)
                return RoundOutcome.Draw;
            if (MyGesture == HandGesture.Paper && OpponentGesture == HandGesture.Rock)
                return RoundOutcome.Win;
            if (MyGesture == HandGesture.Paper && OpponentGesture == HandGesture.Scissors)
                return RoundOutcome.Lost;
            
            // I choose Scissors
            if (MyGesture == HandGesture.Scissors && OpponentGesture == HandGesture.Scissors)
                return RoundOutcome.Draw;
            if (MyGesture == HandGesture.Scissors && OpponentGesture == HandGesture.Paper)
                return RoundOutcome.Win;
            if (MyGesture == HandGesture.Scissors && OpponentGesture == HandGesture.Rock)
                return RoundOutcome.Lost;
            
            throw new Exception("Unhandled outcome");
        }
    }

    public int MyScore => (int)MyGesture + (int)Outcome;

    public override string ToString()
    {
        return $"Opponent: {OpponentGesture}, Me: {MyGesture}({(int)MyGesture}), Outcome: {Outcome}({(int)Outcome}), Points: {MyScore}";
    }
}