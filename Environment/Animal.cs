namespace Environment;

internal class Animal : ITargetable
{
    private int resistance;
    public int Resistance { get => resistance; set=>resistance=value; }
public Animal()
{
    Resistance=10;
}
}