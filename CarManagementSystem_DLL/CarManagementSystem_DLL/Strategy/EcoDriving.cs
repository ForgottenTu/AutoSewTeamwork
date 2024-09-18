﻿using CarManagementSystem_DLL.Interfaces;

namespace CarManagementSystem_DLL.Strategy;

public class EcoDriving : IDriveBehaviour
{
    private readonly int acceleration_rate = 5;
    
    public int Drive(AVehicle vehicle)
    {
        if(vehicle is LKW)
            return acceleration_rate - 3;
        if(vehicle is null)
            throw new ArgumentNullException(nameof(vehicle));
        return acceleration_rate;
    }
}