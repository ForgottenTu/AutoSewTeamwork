using CarManagementSystem_DLL.Interfaces;
using CarManagementSystem_DLL.Vehicle;

namespace CarManagementSystem_DLL.Strategy;

public class SportDriving : IDriveBehaviour
{
    private readonly int acceleration_rate = 20;
    public int Drive(AVehicle vehicle)
    {
        if(vehicle is LKW)
            return acceleration_rate - 5;
        if(vehicle is null)
            throw new ArgumentNullException(nameof(vehicle));
        return acceleration_rate;
    }
}