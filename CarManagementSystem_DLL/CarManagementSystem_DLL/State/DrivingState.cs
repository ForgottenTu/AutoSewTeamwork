using CarManagementSystem_DLL.Interfaces;

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

    }

    public void Repair()
    {
        throw new NotImplementedException();
    }
}