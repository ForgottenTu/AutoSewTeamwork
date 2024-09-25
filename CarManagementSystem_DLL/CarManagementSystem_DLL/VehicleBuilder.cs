using CarManagementSystem_DLL.Vehicle;

namespace CarManagementSystem_DLL;

public class VehicleBuilder
{
    private readonly Car _car = new();

    public VehicleBuilder SetModel(string model)
    {
        _car.Model = model;
        return this;
    }

    public Car Build() => _car;
}