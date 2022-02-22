using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Monster_Library
{
    public class Harpy : Monster
    {
        public Harpy(string name, int life, int maxLife, int minDamage, int maxDamage, string description)
                        : base(name, life, maxLife, minDamage, maxDamage, description)
        {

        }

        public Harpy()
        {
            Name = "Harpy";
            MaxLife = 40;
            MaxDamage = 15;
            MinDamage = 10;
            Life = 40;
            Description = "A humanoid looking creature... wait are those wings?";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
