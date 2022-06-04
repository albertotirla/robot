using Environment;
using Status;

namespace Robot;
public class JiantKillerRobot : Robot
{
    public JiantKillerRobot() : base()
    {
        Console.WriteLine("initialising robot");
        this.EyeLaserIntensity = Intensity.LethalEliminator;
        Console.WriteLine($"initialised laser intensity to{this.EyeLaserIntensity}");
        
        this.IsActive = true;
        Size = 23;
    Energy=1000000;
    }
}