using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCar
{
    public class Car : ICar
    {

        public IFuelTank FuelTank;
        public IEngine Engine;
        public IFuelTankDisplay fuelTankDisplay;
        private Engine_And_FuelTank Engine_And_Fuel_System;

        public bool EngineIsRunning
        {
            get { return Engine.IsRunning; }
        }

    

        public Car(double fuellevel)
        {
            Engine_And_Fuel_System = new Engine_And_FuelTank();
            Engine = Engine_And_Fuel_System;
            FuelTank = Engine_And_Fuel_System;
            fuelTankDisplay = Engine_And_Fuel_System;
            FuelTank.Refuel(fuellevel);
                    

        }

        public Car() : this(20) { }
        
        public void Refuel(double liters) { FuelTank.Refuel(liters); }

        public void EngineStart() { Engine.Start(); }

        public void EngineStop() { Engine.Stop(); }

        public void RunningIdle()
        {
            this.Engine.Consume(0.0003);
        }
    }
}
