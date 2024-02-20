using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Monster
    {
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

        public int Health { get; private set; } = 100;
        public bool isDead { get; private set; }
    }
}
