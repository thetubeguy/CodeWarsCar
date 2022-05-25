using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCar
{
    internal class Engine_And_FuelTank : IEngine, IFuelTank, IFuelTankDisplay
    {
        public bool IsRunning { get; private set; }
        public double FillLevel { get { return Math.Round(FillLevel, 2); } private set { } }
        public bool IsOnReserve { get { return FillLevel < 5 ? true : false; } }
        public bool IsComplete { get {return FillLevel == 60 ? true : false; } }

        public Engine_And_FuelTank()
        {
            IsRunning = false;
        }
        public void Start()
        {
            IsRunning = true;
        }

        public void Stop()
        {
            IsRunning = false;
        }

        public void Refuel(double liters)
        {
            FillLevel += liters;
        }

        public void Consume(double liters)
        {
            FillLevel -= liters;
        }


    }
}
