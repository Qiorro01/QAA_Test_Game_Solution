using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Weapons
    {
        public int WeaponId;
        public int WeaponPower;

        public Weapons(int id,int power)
        {
             WeaponId = id;
             WeaponPower = power;
        }
        
        public void MagicDamage() {
            WeaponPower += 10;
        }

    }
}
