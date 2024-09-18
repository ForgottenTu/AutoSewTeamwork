using CarManagementSystem_DLL.Interfaces;

namespace CarManagementSystem_DLL.State;

public class RepairState(AVehicle vehicle) : IVehicleState
{
    private AVehicle _vehicle = vehicle;

    public void Driving()
    {
        throw new NotImplementedException();
    }

    public void Parking()
    {
        throw new NotImplementedException();
    }

    public void Repair()
    {
        throw new NotImplementedException();
    }
}