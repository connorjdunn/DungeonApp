using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Weapons
    {
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //Shouldn't be more than the MaxDamage
                //Shouldn't be less than 1
                if (value > 0 && value <= MaxDamage)
                {
                    //This follows the guidlines above, so go ahead and
                    //assign the field the value that was provided
                    _minDamage = value;
                }
                else
                {
                    //Tried to set the value outside of the ranges we deemed appropriate
                    //Therefor, default the value to 1
                    _minDamage = 1;
                }
            }
        }

        //CONSTRUCTORS
        //Create a fully qualified constructor (FQCTOR)

        public Weapons(int minDamage, int maxDamage, string name, bool isTwoHanded)
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
            IsTwoHanded = isTwoHanded;

        }

         public Weapons()
        {

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
                "\t{3}\n",
                Name,
                MinDamage,
                MaxDamage,
                IsTwoHanded ? "Two-Handed" : "One-Handed");
        }



    }
}
