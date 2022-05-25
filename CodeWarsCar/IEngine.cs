using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCar
{
    public interface IEngine
    {
        bool IsRunning { get; }

        void Consume(double liters);

        void Start();

        void Stop();
    }
}
