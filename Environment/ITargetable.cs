namespace Environment;
public interface ITargetable
{
    public uint Health { get; set; }
    public bool IsAlive { get; }
    public void TakeDamage(int amount);
}