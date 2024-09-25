using CarManagementSystem_DLL.Interfaces;
using CarManagementSystem_DLL.Vehicle;

namespace CarManagementSystem_DLL.State;

public class DrivingState(AVehicle vehicle) : IVehicleState
{
    private AVehicle _vehicle = vehicle;

    public void Driving()
    {
        return;
    }

    public void Parking()
    {
        _vehicle.SetState(_vehicle.parkingState);
    }

    public void Repair()
    {
        return;
    }
}