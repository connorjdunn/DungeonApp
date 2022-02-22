using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Player : Character
    {
        

        //FIELDS
        //Attributes: Name, HitChance, Block, Life, MaxLife, Race, Weapon
        //Only need to create fields for any attributes that require buisness rules
        //private int _life;


        //PROPERTIES
        //Automatic Properties: A shortcut syntax that allows you to create a shortened
        //version of a public property. Automatic properties have an open getter and 
        //setter. They automatically create default fields for you at run time.

        // public string Name { get; set; }
        //
        // public int HitChance { get; set; }
        //
        // public int Block { get; set; }
        //
        // public int MaxLife { get; set; }

        public Race CharacterRace { get; set; }

        public Weapons EquippedWeapon { get; set; }

        public string Description { get; set; }

        //You CANNOT have buisness rules with automatic properties.
        //If you need buisness rules, you MUST have the field declared
        //aboce and write the property the "long way"
        //  public int Life
        //  {
        //      get { return _life; }
        //      set
        //      {
        //          //Buisness rule: Life should NOT exceed MaxLife
        //          if (value <= MaxLife)
        //          {
        //              //Good to go!
        //              _life = value;
        //          }
        //          else
        //          {
        //              //Tried to set a value for life that was greater than MaxLife.
        //              //So, let's default the life value to the MaxLife value
        //              _life = MaxLife;
        //          }
        //      }
        //  }

        //CONSTRUCTORS
        //ONLY MAKE A FULLY QUALIFIED CONSTRUCTOR
        //We don't want to allow anyone to make a blank Player, so they MUST
        //give us all of the info necessary
        public Player(string name, int life, int maxLife,
            Race characterRace, Weapons equippedWeapon, string description)
        {
            //Since Life depends on MaxLife, SET MAXLIFE FIRST
            MaxLife = maxLife;
            Name = name;
            Life = life;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            Description = description;
        }

        

        //METHODS
        public override string ToString()
        {
            //return base.ToString();
            string description = "";

            switch (CharacterRace)
            {
                case Race.Khajit:
                    description = "Khajit";
                    break;
                case Race.Human:
                    description = "Human";
                    break;
                case Race.Giant:
                    description = "Giant";
                    break;
                default:
                    break;
            }//end switch

            return string.Format("-=-= {0} =-=-\n" +
                "Life: {1} of {2}\n" +
                "Race: {3}\n" + 
                "Weapon: \n{4}" +
                "Description: {5}",
                Name,
                Life,
                MaxLife,
                CharacterRace,
                EquippedWeapon,
                Description
                );

        }//end ToString()

        public override int CalcDamage()
        {
            //return base.CalcDamage();

            //Weapon will be the basis for how our player deals damage
            //Weapon has MinDamage and MaxDamage properties. Let's
            //use a Random object to randomly select how much damage
            //our Weapon can do with any given attack

            Random rand = new Random();

            //Determine the potential range of damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            //Return damage
            return damage;

        }


    }
}
