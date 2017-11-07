using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTextGame
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string monsterName { get; set; }
        public int maxDamage { get; set; }
        public int rewardXP { get; set; }
        public int rewardGold { get; set; }

        public Monster(int id, string monstername,
                       int maxdamage, int rewardxp,
                       int rewardgold, int currenthitpoints,
                       int maximumhitpoints) : base(currenthitpoints, maximumhitpoints)
        {
            ID = id;
            monsterName = monstername;
            maxDamage = maxdamage;
            rewardXP = rewardxp;
            rewardGold = rewardgold;
        }
    }
}
