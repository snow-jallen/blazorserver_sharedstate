namespace sharedState;

public class State
{
    public static List<string> Users{get;set;}=new();

}

public enum PlayerType
{
    Strong=0,
    Weak=1,
    Hero=2,
    RuntBabbyGoat=3,
    Accountant=4
}

[Flags]
public enum Powers
{
    Fly=0b01,
    SeeThroughWalls=0b10,
    LazerVision=0b100,
    Invisibility=0b1000,
    Superman=0b111
}