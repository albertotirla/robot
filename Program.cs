using Environment;
using Robot;

var robot = new JiantKillerRobot();
Planet earth = new Earth();
while (robot.IsActive && earth.ContainsLife)
{
    if (robot.CurrentTarget.IsAlive)
    {
        Console.WriteLine("firing the laser");
        robot.FireLaserAt(robot.CurrentTarget);
    }
    else
    {
        Console.WriteLine("target is dead, choosing another one");
        robot.AcquireNextTarget();
    }
}
