namespace Environment;
public interface ITargetable
{
    public uint Resistance { get; set; }
    public bool IsAlive =>Resistance>0;
    public void TakeDamage(int amount)
    {
        if (amount<0)
        {
            throw(new ArgumentOutOfRangeException("damage amount must be positive"));
        }
    Resistance-=amount;
    }
}