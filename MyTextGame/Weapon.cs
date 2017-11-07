using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTextGame
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }


        //purpose of using :base is to take parameters from
        //the weapon constructor and pass them to the item class
        //as the item class is the base class
        public Weapon(int id, string name, string namePlural,
                      int minimumDamage, int maximumDamage) : base(id, name,namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;

        }


    }
}
