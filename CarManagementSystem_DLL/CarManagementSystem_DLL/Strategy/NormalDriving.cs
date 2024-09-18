using CarManagementSystem_DLL.Interfaces;

namespace CarManagementSystem_DLL.Strategy;

public class NormalDriving : IDriveBehaviour
{
    private int acceleration_rate = 10;
    public void Drive(AVehicle vehicle)
    {
        vehicle.Speed += acceleration_rate;
    }
}