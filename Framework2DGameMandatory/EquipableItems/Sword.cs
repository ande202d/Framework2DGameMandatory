using System;
using System.Collections.Generic;
using System.Text;
using Framework2DGameMandatory.Interfaces;

namespace Framework2DGameMandatory.EquipableItems
{
    public class Sword : Equipable, IOffence
    {
        public Sword(Position pos, int dmg) : base(EquipableType.Sword, pos)
        {
            Damage = dmg;
        }

        public int Damage { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Dmg: {Damage}";
        }
    }
}
