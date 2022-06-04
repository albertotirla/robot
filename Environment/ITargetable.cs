namespace Environment;
public interface ITargetable
{
    public int Resistance { get; set; }
    public bool IsAlive => Resistance> 0;
    public void TakeDamage(int amount)
    {
        if (amount < 0)
        {
            throw (new ArgumentOutOfRangeException(nameof(amount), null, "damage amount must be greater than 0. You don't want the target to have a health increase or not be damaged at all, right?"));
        }
        Resistance -= amount;
    }
}