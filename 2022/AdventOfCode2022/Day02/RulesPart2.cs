namespace Day02;

public static class RulesPart2
{
    public static HandGesture ChooseResponse(HandGesture opponent, RoundOutcome forcedOutcome)
    {
        // I need to Draw
        if (forcedOutcome == RoundOutcome.Draw)
            return opponent; // return same gesture as opponent
        
        // I need to Win
        if (forcedOutcome == RoundOutcome.Win)
        {
            if (opponent == HandGesture.Rock)
                return HandGesture.Paper;           // Paper beats Rock
            if (opponent == HandGesture.Paper)
                return HandGesture.Scissors;        // Scissors beats Paper
            if (opponent == HandGesture.Scissors)
                return HandGesture.Rock;            // Rock beats Scissors
        }
        
        // I need to Loose
        if (forcedOutcome == RoundOutcome.Lost)
        {
            if (opponent == HandGesture.Rock)
                return HandGesture.Scissors;        // Scissors lose to Rock
            if (opponent == HandGesture.Paper)
                return HandGesture.Rock;            // Rock lose to Paper
            if (opponent == HandGesture.Scissors)
                return HandGesture.Paper;           // Paper lose to Scissors
        }

        throw new Exception("Unhandled response");
    }
    
    public static RoundOutcome GetOutcomeForCode(char code)
    {
        return code switch
        {
            'X' => RoundOutcome.Lost,
            'Y' => RoundOutcome.Draw,
            'Z' => RoundOutcome.Win,
            _ => throw new Exception("Invalid code")
        };
    }
}