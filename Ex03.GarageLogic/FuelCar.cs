﻿namespace Ex03.GarageLogic
{
    internal class FuelCar : Car
    {
        public FuelCar(string i_LicenseNumber) : base(i_LicenseNumber, new FuelEngine(FuelEngine.eFuelType.Octan96, 60)) 
        {
        }
    }
}
