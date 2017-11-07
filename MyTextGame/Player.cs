using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTextGame
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }

        //Default constructor
        public Player(int currentHitPoints, int maximumHitPoints,
                      int gold, int experiencePoints, int level) :
        base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            XP = experiencePoints;
            Level = level;
        }

    }
}
