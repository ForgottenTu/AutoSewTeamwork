using CarManagementSystem_DLL.Strategy;
using CarManagementSystem_DLL.Vehicle;
using JetBrains.Annotations;
using Xunit;

namespace CarManagementSystem_DLL.Tests;

[TestSubject(typeof(VehicleFactory))]
public class VehicleFactoryTest
{
    [Fact]
    public void TestCreateCar()
    {
        AVehicle car = VehicleFactory.Instance.CreateCar();

        Assert.NotNull(car);
        Assert.IsType<Car>(car);
        Assert.IsType<NormalDriving>(car._driveBehaviour);
        Assert.Equal("Standard Car", car.Model);
        Assert.Equal(0, car.Speed);
    }
    
    [Fact]
    public void TestCreateMotorcycle()
    {
        AVehicle bike = VehicleFactory.Instance.CreateMotorcycle();

        Assert.NotNull(bike);
        Assert.IsType<Motorcycle>(bike);
        Assert.IsType<SportDriving>(bike._driveBehaviour);
        Assert.Equal("Sport Motorcycle", bike.Model);
        Assert.Equal(0, bike.Speed);
    }
    
    [Fact]
    public void TestCreateTruck()
    {
        AVehicle truck = VehicleFactory.Instance.CreateTruck();

        Assert.NotNull(truck);
        Assert.IsType<Truck>(truck);
        Assert.IsType<NormalDriving>(truck._driveBehaviour);
        Assert.Equal("Heavy Truck", truck.Model);
        Assert.Equal(0, truck.Speed);
    }
    
    [Fact]
    public void TestCreateEcoCar()
    {
        AVehicle car = VehicleFactory.Instance.CreateEcoCar();

        Assert.NotNull(car);
        Assert.IsType<Car>(car);
        Assert.IsType<EcoDriving>(car._driveBehaviour);
        Assert.Equal("Eco Car", car.Model);
        Assert.Equal(0, car.Speed);
    }
    
    [Fact]
    public void TestCreateSportTruck()
    {
        AVehicle truck = VehicleFactory.Instance.CreateSportTruck();

        Assert.NotNull(truck);
        Assert.IsType<Truck>(truck);
        Assert.IsType<SportDriving>(truck._driveBehaviour);
        Assert.Equal("Sport Truck", truck.Model);
        Assert.Equal(0, truck.Speed);
    }
}