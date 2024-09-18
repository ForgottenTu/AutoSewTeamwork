using CarManagementSystem_DLL.State;
using CarManagementSystem_DLL.Strategy;

namespace CarManagementSystem_DLL;

public abstract class AVehicle
{
    public int Speed { get; set; }
    public string Model { get; set; }

    public AVehicle()
    {
        Speed = 0;
        _driveBehaviour = new NormalDriving();
        _vehicleState = new ParkingState();
    }
    private IDriveBehaviour _driveBehaviour;
    private IVehicleState _vehicleState;
    
    private void SetDriveBehaviour(IDriveBehaviour driveBehaviour)
    {
        _driveBehaviour = driveBehaviour;
    }
    public void Drive()
    {
        while(_vehicleState is DrivingState)
        {
            _driveBehaviour.Drive(this);
        }
    }
    public void Accelerate()
    {
        
    }
    public void Brake()
    {
        //TODO
    }
}