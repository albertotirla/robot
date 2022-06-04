namespace Environment;

internal class SuperHero : ITargetable
{
    private int resistance;
    public int Resistance { get => resistance; set => resistance = value; }
    public SuperHero()
    {
        Resistance = 1000;
    }
}

