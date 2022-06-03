
using Environment;
using Status;

namespace Robot;
public class Robot
{
    public Intensity EyeLaserIntensity { get; set; }
    private int TargetIndex = 0;
    public ITargetable CurrentTarget => Earth.Population[TargetIndex];
    public Planet Earth { get; set; }
    public bool IsActive { get; set; }
    public uint Size { get; private set; }
    public int Energy { get; private set; }

    public Robot()
    {
        Console.WriteLine("initialising robot");
        this.EyeLaserIntensity = Intensity.NonLethalParaliser;
        Console.WriteLine($"initialised laser intensity to{nameof(this.EyeLaserIntensity)}");
        this.Earth = new();
        this.Size = 1;//one meter or something
        this.IsActive = true;
        Console.WriteLine("robot initialisation successful");
    }
    public void AcquireNextTarget()
    {
        TargetIndex = TargetIndex++ % Earth.Population.Count;

        if (!CurrentTarget.IsAlive)
        {
            IsActive = false;
        }
    }
    public void FireLaserAt(ITargetable Target)
    {
        Target.TakeDamage(amount: GetDamageFactor());
    }

    private int GetDamageFactor() => (int)((2 * Size) + (Energy / 20) + (int)(0.15 * CurrentTarget.Resistance));
}
