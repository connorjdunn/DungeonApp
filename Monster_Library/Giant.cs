using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Monster_Library
{
    public class Giant : Monster
    {
        public Giant(string name, int life, int maxLife, int minDamage, int maxDamage, string description)
                        : base(name, life, maxLife, minDamage, maxDamage, description)
        {

        }

        public Giant()

        {
            Name = "Giant";
            MaxLife = 70;
            MaxDamage = 25;
            MinDamage = 10;
            Life = 70;
            Description = "A humanoid looking creature... only larger";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
