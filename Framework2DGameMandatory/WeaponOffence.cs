using System;
using System.Collections.Generic;
using System.Text;

namespace Framework2DGameMandatory
{
    public class WeaponOffence
    {
        private int _dmg;
        private int _critChance;

        public WeaponOffence(int dmg, int critChance)
        {
            _dmg = dmg;
            _critChance = critChance;
        }

        public int CritChance
        {
            get { return _critChance; }
            set { _critChance = value; }
        }
        public int Dmg
        {
            get { return _dmg; }
            set { _dmg = value; }
        }
    }
}
