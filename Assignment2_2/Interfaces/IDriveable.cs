﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2.Interfaces
{
    interface IDriveable
    {        
        void StartEngine();
        void StopEngine();
        void Gas();
        void Break();
        void TurnLeft();
        void TurnRight();         
    }
}