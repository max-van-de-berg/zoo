using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Zoo
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public string Specie { get; set; }
        public abstract int UseEnergy();

        public void Eat()
        {
            Energy += 25;
        }

        public override string ToString()
        {
            return this.Name + " the " + this.Specie + ". energy: " + this.Energy;
        }
    }
}
