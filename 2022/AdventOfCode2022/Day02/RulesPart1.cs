namespace Day02;

public static class RulesPart1
{
    public static HandGesture ChooseResponse(HandGesture opponent)
    {
        return opponent switch
        {
            HandGesture.Rock => HandGesture.Paper,
            HandGesture.Paper => HandGesture.Rock,
            HandGesture.Scissors => HandGesture.Scissors,
            _ => throw new Exception("Invalid hand gesture by opponent")
        };
    }
    
    public static HandGesture GetGestureForCode(char code)
    {
        return code switch
        {
            'A' => HandGesture.Rock,
            'B' => HandGesture.Paper,
            'C' => HandGesture.Scissors,
            'X' => HandGesture.Rock,
            'Y' => HandGesture.Paper,
            'Z' => HandGesture.Scissors,
            _ => throw new Exception("Invalid code")
        };
    }
}