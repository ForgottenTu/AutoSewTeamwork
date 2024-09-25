using CarManagementSystem_DLL.Vehicle;

namespace CarManagementSystem_DLL.Command;

public class BrakeCommand(AVehicle vehicle) : ICommand
{
    private AVehicle _vehicle = vehicle;
    public void execute()
    {
        _vehicle.Brake();
    }
}