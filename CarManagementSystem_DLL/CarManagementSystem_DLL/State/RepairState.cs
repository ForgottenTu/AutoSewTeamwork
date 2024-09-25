using CarManagementSystem_DLL.Interfaces;
using CarManagementSystem_DLL.Vehicle;

namespace CarManagementSystem_DLL.State;

public class RepairState(AVehicle vehicle) : IVehicleState
{
    private AVehicle _vehicle = vehicle;

    public void Driving()
    {
        return;
    }

    public void Parking()
    {
        return;
    }

    public void Repair()
    {
        _vehicle.SetState(_vehicle.parkingState);
    }
}