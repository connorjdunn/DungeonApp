using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Combat
    {

        //This class will not have fields, properties, custom
        //constructors, as it is just a container for different methods

        public static void DoAttack(Character attacker, Character defender)
        {
            bool death = true;
            do
            {
                //If the attacker hit, calculate the damage
                int damageDelt = attacker.CalcDamage();

                //Assign the damage
                defender.Life -= damageDelt;

                //Write the result to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!",
                    attacker.Name, defender.Name, damageDelt);
                Console.ResetColor();

            } while (!death);



        }//End DoAttack();

        public static void DoBattle(Player player, Monster monster)
        {
            //Player attacks first
            DoAttack(player, monster);

            //Monster attacks second -- if they are still alive
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }

        }//End Battle();
    }
}
