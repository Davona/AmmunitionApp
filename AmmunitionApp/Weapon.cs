using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmunitionApp
{
    class Weapon
    {
        public Weapon(string model, int id, int cartridgeCount)
        {
            _model = model;
            _id = id;
            _cartridgeCount = cartridgeCount;
        }
        public string _model { get; private set; }
        public int _id { get; private set; }
        public int _cartridgeCount { get; set; }
        public virtual void Shoot()
        {
            Console.WriteLine();
        }
    }
}