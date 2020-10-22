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
            Hero hero1 = new Hero("Hero1", new Position(2,2), 10, ceShields:true);
            Sword sword1 = new Sword(new Position(5,5), 15);
            Sword sword2 = new Sword(new Position(5,5), 25);
            Sword sword3 = new Sword(new Position(5,5), 35);
            Sword sword4 = new Sword(new Position(5,5), 45);
            Shield shield1 = new Shield(new Position(5,5), 30, 25);
            Shield shield2 = new Shield(new Position(5,5), 30, 35);
            Shield shield3 = new Shield(new Position(5,5), 30, 45);
            Helmet helmet1 = new Helmet(new Position(5,5), 20, 50);
            Helmet helmet2 = new Helmet(new Position(5,5), 35, 45);



            Console.WriteLine(hero1);
            if (hero1.Equip(sword1)) sword1 = null; 
            if (hero1.Equip(sword3)) sword3 = null;
            if (hero1.Equip(sword4)) sword4 = null;

            if (hero1.Equip(helmet1)) helmet1 = null;
            if (hero1.Equip(helmet2)) helmet2 = null;

            if (hero1.Equip(shield1)) shield1 = null;
            if (hero1.Equip(shield2)) shield2 = null;
            hero1.TakeDamage(50);
            hero1.TakeDamage(50);
            hero1.TakeDamage(50);
            hero1.TakeDamage(50);
            if (hero1.Equip(shield3)) shield3 = null;


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(hero1.Information());

        }
    }
}
