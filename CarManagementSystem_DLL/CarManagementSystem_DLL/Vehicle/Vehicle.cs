using CarManagementSystem_DLL.Interfaces;
using CarManagementSystem_DLL.State;
using CarManagementSystem_DLL.Strategy;

namespace CarManagementSystem_DLL.Vehicle;

public abstract class AVehicle
{
    public int Speed { get; private set; }
    public string Model { get; private set; }

    public readonly DrivingState DrivingState;
    public readonly ParkingState ParkingState;
    public readonly RepairState RepairState;

    public AVehicle()
    {
        Speed = 0;
        _driveBehaviour = new NormalDriving();
        _vehicleState = new ParkingState(this);
        DrivingState = new DrivingState(this);
        ParkingState = new ParkingState(this);
        RepairState = new RepairState(this);
    }

    private IDriveBehaviour _driveBehaviour;
    private IVehicleState _vehicleState;

    public void SetDriveBehaviour(IDriveBehaviour driveBehaviour)
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

    public void SetState(IVehicleState state) => _vehicleState = state;
}