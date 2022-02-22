using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Weapons_Library
{
    public class Bow_And_Arrow : Weapons
    {
        

        

        

        public Bow_And_Arrow(int minDamage, int maxDamage, string name, bool isTwoHanded)
            : base(minDamage, maxDamage, name, isTwoHanded)
        {
            //Here. the Properties are being assigned the value of the PARAMETERS
            //When we use the constructor to create a Weapon object, we MUST provide
            //the values listed in the parentheses.

            //If you have any properties that have buisness rules
            //that are based off of any other properties...
            //Set the other properties FIRST
            MaxDamage = maxDamage;
            //Since MinDamage has buisness rules that depend on
            //the value of MaxDamage, we MUST set MaxDamage before
            //minDamage
            MinDamage = minDamage;
            Name = name;
            IsTwoHanded = true;
             

        }

        //NO DEFAULT CONSTUCTOR! We do not want anyone to make
        //a blank weapon that is missing any of the info related
        //to that weapon.

        //METHODS
        //Since Dungeon Libary.Weapon is probably NOT what we want
        //printed to the screen, we will need to override the ToString()
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Is Two Handed? {3}" ,
                Name,
                MinDamage,
                MaxDamage,
                IsTwoHanded ? "Two-Handed" : "One-Handed");
        }


    }
}
