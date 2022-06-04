using Environment;
using Status;

namespace Robot;
abstract public class Robot
{
    public Intensity EyeLaserIntensity { get; set; }
    private int TargetIndex = 0;
    public ITargetable CurrentTarget { get; protected set; }
    public Planet Earth { get; protected set; }
    public bool IsActive { get; protected set; }
    protected uint Size { get; set; }
    protected int Energy { get; set; }

    public Robot()
    {
        this.Earth = new Earth();
        CurrentTarget = Earth.Population[TargetIndex];
    }
    public void AcquireNextTarget()
    {
        TargetIndex++;
        //this doesn't work for some reason, so I'm commenting it
        //TargetIndex = (TargetIndex++) % Earth.Population.Count;
        if (TargetIndex >= Earth.Population.Count)
        {
            TargetIndex = 0;
        }
        CurrentTarget = Earth.Population[TargetIndex];
        if (!CurrentTarget.IsAlive)
        {
            Console.WriteLine("no more targets remaining, deactivating the robot");
            IsActive = false;
        }
    }
    public void FireLaserAt(ITargetable Target)
    {
        Energy -= GetEnergyFactor();
        if (Energy <= 0)
        {
            IsActive = false;
        }
        Target.TakeDamage(amount: GetDamageFactor());
    }

    private int GetEnergyFactor() => (int)(0.12 * Energy);
    private int GetDamageFactor() => (int)((2 * Size) + (Energy / 20) + (int)(0.15 * CurrentTarget.Resistance));
}
