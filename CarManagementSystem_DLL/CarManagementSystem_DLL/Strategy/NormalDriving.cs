using CarManagementSystem_DLL.Interfaces;
using CarManagementSystem_DLL.Vehicle;

namespace CarManagementSystem_DLL.Strategy;

public class NormalDriving : IDriveBehaviour
{
    private int acceleration_rate = 10;
    public void Drive(AVehicle vehicle)
    {
        vehicle.Speed += acceleration_rate;
    }
}