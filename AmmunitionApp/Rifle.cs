using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmunitionApp
{
    class Rifle : Weapon
    {
        public Rifle(string model, int id, int cartridgeCount):base( model,  id,  cartridgeCount)
        {

        }
        public override void Shoot()
        {
            Console.WriteLine($"Rifle  {_model}  is loaded and ready to shoot");
            Console.WriteLine("Shooting");
        }
    }
}
