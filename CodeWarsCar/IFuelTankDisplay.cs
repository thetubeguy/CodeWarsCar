﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCar
{
    public interface IFuelTankDisplay
    {
        double FillLevel { get; }

        bool IsOnReserve { get; }

        bool IsComplete { get; }
    }
}
