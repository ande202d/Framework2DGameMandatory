using System;
using System.Collections.Generic;
using System.Text;

namespace Framework2DGameMandatory
{
    public class Gear
    {
        private GearType Type;
        public int ExtraHp { get; } // private set; 
        public int DefencePoints { get; private set; }  

        public Gear(GearType gearType, int hp, int def)
        {
            Type = gearType;
            ExtraHp = hp;
            DefencePoints = def;
        }

    }
}
