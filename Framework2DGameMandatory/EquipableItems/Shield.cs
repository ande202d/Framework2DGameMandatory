using System;
using System.Collections.Generic;
using System.Text;
using Framework2DGameMandatory.Interfaces;

namespace Framework2DGameMandatory.EquipableItems
{
    public class Shield : Equipable, IDefence
    {
        public Shield(Position pos, int block, int health) : base(EquipableType.Shield, pos)
        {
            Block = block;
            Health = health;
        }

        public int Block { get; set; }
        public int Health { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", HP+{Health}, Block: {Block}";
        }
    }
}
