using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Actor
    {
        public int Health { get; set; } = 100;
        public string Name { get; set; }

        public bool isDead { get; set; }
        public string Race { get; set; }
        public int Power { get; private set; } = 10;
        public bool hasWeapon { get; private set; }

        List<string> Races = new List<string>()
        {
            "Humane", "Elf", "Gnome", "Orc", "Goblin"
        };

        public void isElf()
        {
            Health = 90;
            Race = "Elf";
            Power += 15;

        }
        public void isHuman()
        {
            Health = 100;
            Race = "Human";
        }
        public void isGnome()
        {
            Health = 120;
            Race = "Gnome";
            Power += 5;
        }
        public void isOcr()
        {
            Health = 110;
            Race = "Gnome";
            Power += 10;
        }
        public void isGoblin()
        {
            Health = 80;
            Race = "Goblin";
        }



        public void Hit(int damage)
        {
            Health -= damage;

            if (Health <= 0) { isDead = true; }
        }
        public void Heal(int heal)
        {
            Health += heal;
            if (Health > 100) { Health = 100; }
        }

        public void Weaponized()
        {
            hasWeapon = true;
        }



    }
}
