using System;
using System.Collections.Generic;
using System.Text;
using Framework2DGameMandatory.EquipableItems;
using Framework2DGameMandatory.Interfaces;

namespace Framework2DGameMandatory
{
    public class Hero
    {
        private int _currentHealth;

        //Character stats 
        public String Name { get; }
        public int BaseHealth { get; set; }
        public int BaseDamage { get; set; } //ex 20
        public Position MyPosition { get; set; }

        //Equipable
        public Equipable Helmet { get; set; }
        public Equipable Chestplate { get; set; }
        public Equipable Leggins { get; set; }
        public Equipable LeftHand { get; set; }
        public Equipable RightHand { get; set; }

        private bool CanEquipHead { get; set; }
        private bool CanEquipTorso { get; set; }
        private bool CanEquipLegs { get; set; }
        private bool CanEquipSwords { get; set; }
        private bool CanEquipShields { get; set; }


        public Hero(String name, Position position, int baseDamage, 
            bool ceHead = true, bool ceTorso = true, bool ceLegs = true, bool ceSwords = true, bool ceShields = false)
        {
            Name = name;
            BaseHealth = 100;
            _currentHealth = BaseHealth;
            MyPosition = position;
            BaseDamage = baseDamage;

            CanEquipHead = ceHead;
            CanEquipTorso = ceTorso;
            CanEquipLegs = ceLegs;
            CanEquipSwords = ceSwords;
            CanEquipShields = ceShields;
        }

        public int GetDamage()
        {
            int dmgToDeal = 0;
            dmgToDeal += BaseDamage;

            if (RightHand != null && RightHand.IsOffence())
            {
                dmgToDeal += ((IOffence)RightHand).Damage;
            }
            if (LeftHand != null && LeftHand.IsOffence())
            {
                dmgToDeal += ((IOffence)LeftHand).Damage;
            }

            return dmgToDeal;
        }

        public bool Equip(Equipable item)
        {
            if (item == null) return false;
            switch (item.Type)
            {
                case EquipableType.Head:
                    if (CanEquipHead)
                    {
                        _currentHealth += ((IDefence)item).Health;
                        Helmet = item;
                        Console.WriteLine($"{Name} picked up: {item}");
                        item = null;
                        return true;
                    }
                    else return false;
                case EquipableType.Torso:
                    if (CanEquipTorso)
                    {
                        _currentHealth += ((IDefence)item).Health;
                        Chestplate = item;
                        Console.WriteLine($"{Name} picked up: {item}");
                        item = null;
                        return true;
                    }
                    else return false;
                case EquipableType.Legs:
                    if (CanEquipLegs)
                    {
                        _currentHealth += ((IDefence)item).Health;
                        Leggins = item;
                        Console.WriteLine($"{Name} picked up: {item}");
                        item = null;
                        return true;
                    }
                    else return false;
                case EquipableType.Sword:
                    if (CanEquipSwords)
                    {
                        if (RightHand == null)
                        {
                            RightHand = item;
                            Console.WriteLine($"{Name} picked up: {item}");
                        }
                        else if (LeftHand == null)
                        {
                            LeftHand = item;
                            Console.WriteLine($"{Name} picked up: {item}");
                        }
                        else
                        {
                            Console.WriteLine($"{Name} picked up: {item}, and threw away: {RightHand}");
                            RightHand = item;
                        }
                        item = null;
                        return true;
                    }
                    else return false;
                case EquipableType.Shield:
                    if (CanEquipShields)
                    {
                        _currentHealth += ((IDefence)item).Health;
                        LeftHand = item;
                        Console.WriteLine($"{Name} picked up: {item}");
                        item = null;
                        return true;
                    }
                    else return false;
                default: return false;
            }
        }


        public override string ToString()
        {
            return $"{Name} at {MyPosition}, Health: {_currentHealth}, CurrentDamage: {GetDamage()}";
        }

        public String Information()
        {
            return "Helmet: " + (Helmet == null ? "none" : Helmet.ToString()) +
                   "\nRightHand: " + (RightHand == null ? "none" : RightHand.ToString()) +
                   "\nLeftHand: " + (LeftHand == null ? "none" : LeftHand.ToString());
        }

        #region Old

        /*

        private int _id;
        private static int _idCounter = 0;
        private int _baseDmg;
        private int _baseHp;
        private int[] _position;
        private Weapon _leftHand;
        private Weapon _rightHand;
        private Gear _head;
        private Gear _torso;
        private Gear _legs;

        #region Properties

        public Gear GearLegs
        {
            get { return _legs; }
            set { _legs = value; }
        }
        public Gear GearTorso
        {
            get { return _torso; }
            set { _torso = value; }
        }
        public Gear GearHead
        {
            get { return _head; }
            set { _head = value; }
        }
        public Weapon RightHand
        {
            get { return _rightHand; }
            set { _rightHand = value; }
        }
        public Weapon LeftHand
        {
            get { return _leftHand; }
            set { _leftHand = value; }
        }
        public int[] Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public int BaseHp
        {
            get { return _baseHp; }
            set { _baseHp = value; }
        }
        public int BaseDmg
        {
            get { return _baseDmg; }
            set { _baseDmg = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        } 

        #endregion

        */

        #endregion
    }
}
