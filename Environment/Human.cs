namespace Environment;

internal class Human : ITargetable
{
    int resistance;

    public int Resistance { get => resistance; set => resistance = value; }
    public Human()
    {
        Resistance = 100;
    }
}