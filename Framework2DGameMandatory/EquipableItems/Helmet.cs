using System;
using System.Collections.Generic;
using System.Text;
using Framework2DGameMandatory.Interfaces;

namespace Framework2DGameMandatory.EquipableItems
{
    public class Helmet : Equipable, IDefence
    {
        public Helmet(Position pos, int block, int health) : base(EquipableType.Head, pos)
        {
            Block = block;
            Health = health;
        }

        public int Block { get; set; }
        public int Health { get; set; }
    }
}
