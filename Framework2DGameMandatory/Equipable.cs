using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Framework2DGameMandatory.Interfaces;

namespace Framework2DGameMandatory
{
    public abstract class Equipable
    {
        private EquipableType _type;
        private Position _pos;

        public Equipable(EquipableType type, Position pos)
        {
            _type = type;
            _pos = pos;
        }

        public EquipableType Type
        {
            get { return _type; }
            private set { _type = value; }
        }

        public Position Pos
        {
            get { return _pos;}
            private set { _pos = value; }
        }

        public Type GetInterFace()
        {
            if (Type == EquipableType.Head) return typeof(IDefence);
            else if (Type == EquipableType.Sword) return typeof(IOffence);
            return null;
        }

        public bool IsOffence()
        {
            if (Type == EquipableType.Sword) return true;
            return false;
        }

        public bool IsDefence()
        {
            if (Type == EquipableType.Head ||
                Type == EquipableType.Torso ||
                Type == EquipableType.Legs ||
                Type == EquipableType.Shield)
            {
                return true;
            }

            return false;
        }


        public override string ToString()
        {
            return $"{Type} at {Pos}";
        }
    }
}
