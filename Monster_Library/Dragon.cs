using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Monster_Library
{
    public class Dragon : Monster
    {

        public Dragon(string name, int life, int maxLife, int minDamage, int maxDamage, string description)
            
        {
            Name = "Dragon";
            MaxLife = 150;
            MaxDamage = 40;
            MinDamage = 20;
            Life = 150;
            Description = "Flying beast... is it hot in here or is it just me?";
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
