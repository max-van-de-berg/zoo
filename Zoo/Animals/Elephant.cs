﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    class Elephant : Animal
    {
        public override int UseEnergy()
        {
            return Energy -= 5;
        }
    }
}
