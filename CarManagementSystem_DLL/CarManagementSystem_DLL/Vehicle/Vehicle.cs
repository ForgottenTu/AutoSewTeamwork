using CarManagementSystem_DLL.Interfaces;
using CarManagementSystem_DLL.State;
using CarManagementSystem_DLL.Strategy;

namespace CarManagementSystem_DLL.Vehicle;

public abstract class AVehicle
{
    public int Speed { get; set; }
    public string Model { get; set; }

    public DrivingState drivingState;
    public ParkingState parkingState;
    public RepairState repairState;

    public AVehicle()
    {
        Speed = 0;
        _vehicleState = new ParkingState(this);
        drivingState = new DrivingState(this);
        parkingState = new ParkingState(this);
        repairState = new RepairState(this);
    }

    public IDriveBehaviour _driveBehaviour { get; set; }
    private IVehicleState _vehicleState;

    public void SetDriveBehaviour(IDriveBehaviour driveBehaviour)
    {
        _driveBehaviour = driveBehaviour;
    }

    public void Accelerate()
    {
        if(_vehicleState is not DrivingState)
            SetState(drivingState);

        Speed += _driveBehaviour.Drive(this);
    }
    public void Brake()
    {
        if(_vehicleState is not DrivingState)
            return;

        Speed -= _driveBehaviour.Drive(this);
    }

    public void SetState(IVehicleState state) => _vehicleState = state;
}