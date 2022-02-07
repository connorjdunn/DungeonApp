using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;


namespace Monster_Library
{
    public class Demon : Monster
    {
        public Demon(string name, int life, int maxLife,int minDamage, int maxDamage, string description)
            : base(name, life, maxLife, minDamage, maxDamage, description)
        {

        }

        public Demon()
        {
            MaxLife = 15;
            MaxDamage = 10;
            Name = "Demon";
            Life = 15;
            MinDamage = 5;
            Description = "A creature from another world";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
