using CarManagementSystem_DLL.State;
using CarManagementSystem_DLL.Strategy;
using CarManagementSystem_DLL.Vehicle;

namespace CarManagementSystem_DLL;

public class CarFactory
{
    private static CarFactory _instance;
    
    public static CarFactory Instance
    {
        get
        {
            if(_instance == null)
                _instance = new CarFactory();
            return _instance;
        }
    }
    
    public Vehicle.AVehicle CreateCar()
    {
        return new Car()
        {
            Model = "Standard Car",
            Speed = 0,
            _driveBehaviour = new NormalDriving(),
        };
    }
    public Vehicle.AVehicle CreateTruck()
    {
        return new Truck()
        {
            Model = "Heavy Truck",
            Speed = 0,
            _driveBehaviour = new NormalDriving()
        };
    }
    public Vehicle.AVehicle CreateMotorcycle()
    {
        return new Motorcycle()
        {
            Model = "Sport Motorcycle",
            Speed = 0,
            _driveBehaviour = new SportDriving()
        };
    }
    
    public Vehicle.AVehicle CreateEcoCar()
    {
        return new Car()
        {
            Model = "Eco Car",
            Speed = 0,
            _driveBehaviour = new EcoDriving()
        };
    }
    public Vehicle.AVehicle CreateSportTruck()
    {
        return new Truck()
        {
            Model = "Sport Truck",
            Speed = 0,
            _driveBehaviour = new SportDriving()
        };
    }
    
}



/*1. Auto 

Modell: "Standard Car" 
Initialgeschwindigkeit: 0 km/h 
Standardstrategie: Normales Fahren 
Standardzustand: Geparkt 
2. Truck 

Modell: "Heavy Truck" 
Initialgeschwindigkeit: 0 km/h 
Standardstrategie: Normales Fahren 
Standardzustand: Geparkt 
3. Motorrad 

Modell: "Sport Motorcycle" 
Initialgeschwindigkeit: 0 km/h 
Standardstrategie: Sportliches Fahren 
Standardzustand: Geparkt 
4. Eco Car 

Modell: "Eco Car" 
Initialgeschwindigkeit: 0 km/h 
Standardstrategie: Energieeffizientes Fahren 
Standardzustand: Geparkt 
5. Sport Truck 

Modell: "Sport Truck" 
Initialgeschwindigkeit: 0 km/h 
Standardstrategie: Sportliches Fahren 
Standardzustand: Geparkt */