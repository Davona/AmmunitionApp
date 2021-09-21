using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmunitionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon pistol = new Pistol("TT", 4274, 8);
            Weapon rifle = new Rifle("AK-74", 5066, 30);
            Weapon machineGun = new MachineGun("Thompson", 3578, 75);
            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(pistol);
            weapons.Add(rifle);
            weapons.Add(machineGun);
            for (int i = 0; i < weapons.Count; i++)
            {
                weapons[i].Shoot();
            }
        }
    }
}
