using System;
using System.Collections.Generic;
using System.Text;
using Framework2DGameMandatory;
using Framework2DGameMandatory.EquipableItems;

namespace _2DGame
{
    public class tester
    {
        public void Start()
        {
            Hero hero1 = new Hero("Hero1", new Position(2,2), 10);
            Sword sword1 = new Sword(new Position(5,5), 15);
            Sword sword2 = new Sword(new Position(5,5), 25);
            Sword sword3 = new Sword(new Position(5,5), 35);
            Sword sword4 = new Sword(new Position(5,5), 45);
            Helmet helmet1 = new Helmet(new Position(5,5), 20, 50);



            Console.WriteLine(hero1);
            if (hero1.Equip(sword1)) sword1 = null;
            Console.WriteLine(hero1);
            if (hero1.Equip(sword2)) sword2 = null;
            Console.WriteLine(hero1);
            if (hero1.Equip(sword3)) sword3 = null;
            Console.WriteLine(hero1);
            if (hero1.Equip(sword4)) sword4 = null;
            Console.WriteLine(hero1);
            if (hero1.Equip(helmet1)) helmet1 = null;
            Console.WriteLine(hero1);
            if (hero1.Equip(helmet1)) helmet1 = null;
            Console.WriteLine(hero1);
            if (hero1.Equip(helmet1)) helmet1 = null;
            Console.WriteLine(hero1);

        }
    }
}
