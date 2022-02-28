using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Library;
using Weapons_Library;
using Dungeon_Library;

namespace Dungeon
{


    class Program
    {
        static void Main(string[] args)
        //Max player life should only be 100
        // use 100 for reference when customizing how much damage something does
        {
            Console.Title = "Unknown Dungeon";
            Console.WriteLine("Discover what lies below...");

            int score = 0;

            Console.WriteLine("Enter Player Name: ");

            string playerName = Console.ReadLine();

            Weapons playerWeapon = new Weapons();

            Weapons bowAndArrow = new Weapons(15, 40, "Bow and Arrow", true);

            Weapons longSword = new Weapons(25, 35, "Long Sword", true);

            Weapons dagger = new Weapons(20, 25, "Dagger", false);


            #region Weapon Menu

            Console.Write("\nPlease choose your weapon:\n" +
                "A) Bow and Arrow\n" +
                "B) Long Sword\n" +
                "C) Dagger\n");

            ConsoleKey userWeapon = Console.ReadKey(true).Key;
            //Executes on input without having to hit enter

            //Clear the console
            Console.Clear();

            //Build out the switch for userChoice
            switch (userWeapon)
            {

                case ConsoleKey.A:
                    playerWeapon = bowAndArrow;
                    //Console.WriteLine(playerName + "has picked" + playerWeapon);
                    Console.Write("You have picked Bow and Arrow!");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;


                case ConsoleKey.B:
                    playerWeapon = longSword;
                    //Console.WriteLine(playerName + "has picked" + playerWeapon);
                    Console.Write("You have picked Long Sword!");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;


                case ConsoleKey.C:
                    playerWeapon = dagger;
                    //Console.WriteLine(playerName + "has picked" + playerWeapon);
                    Console.Write("You have picked Dagger!");
                    Console.WriteLine();
                    Console.WriteLine();

                    break;
            }

            #endregion

            bool exit = false;
            bool reload = false;

            do
            {

                Console.WriteLine(GetRoom());

                Player player = new Player(playerName, 100, 100, Race.Elf, playerWeapon, "A new challanger the likes this temple has never seen");

                Demon r1 = new Demon(); //Uses the default constructor

                Harpy h1 = new Harpy();

                Dragon d1 = new Dragon();

                Giant g1 = new Giant();

                Monster[] monsters = { r1, r1, r1, r1, h1, h1, h1, d1, g1 };

                Random rand = new Random();

                int randomNumber = rand.Next(monsters.Length);

                Monster monster = monsters[randomNumber];

                Console.WriteLine("\nIn this room you encounter a " + monster.Name);


                do
                {
                    #region Menu

                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "W) Weapon Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    //Executes on input without having to hit enter

                    //Clear the console
                    Console.Clear();

                    //Build out the switch for userChoice
                    switch (userChoice)
                    {
                        //Attack
                        case ConsoleKey.A:
                            Combat.DoBattle(player, monster);

                            if (monster.Life <= 0)
                            {
                                //It is dead!
                                //You could put logic here to have the player
                                //get items, recover some life, or some other
                                //similar bonus for defeating the monster

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}!\n", monster.Name);
                                Console.ResetColor();
                                reload = true;

                                //We now want to get a new room
                                //Because reload is true, we will exit
                                //the menu loop and return to the top of
                                //the gameplay loop. Once we loop back there,
                                //our code generates a new room using the GetRoom()
                                score++;
                            }



                            break;

                        //Run Away

                        case ConsoleKey.R:

                            Console.WriteLine("Run away!");

                            Console.WriteLine("You've escaped this time!");
                            Console.WriteLine();
                            reload = true;

                            break;

                        //Player Info

                        case ConsoleKey.P:

                            Console.WriteLine("Player Info");

                            Console.WriteLine(player);
                            Console.WriteLine("Monsters Slain: " + score);

                            break;


                        case ConsoleKey.W:

                            Console.WriteLine("Weapon Info");

                            Console.WriteLine(playerWeapon);


                            break;

                        //Monster Info

                        case ConsoleKey.M:

                            Console.WriteLine("Monsters Info");
                            Console.WriteLine(monster);

                            break;

                        //Exit

                        case ConsoleKey.X:
                        case ConsoleKey.E:

                            Console.WriteLine("No one likes a quiter...");
                            Console.WriteLine("Monsters Slain: " + score);
                            exit = true;

                            break;

                        default:

                            Console.WriteLine("Improper Selection, Please Try Agin.");

                            break;
                    }

                    #endregion

                    if (player.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("YOU ARE DEAD");
                        Console.ResetColor();
                        Console.WriteLine("Monsters Slain: " + score);
                        exit = true;
                    }


                } while (!reload && !exit);


            } while (!exit);

        }//end main
        private static string GetRoom()
        {
            string[] rooms =
            {
                "The room is dark, you can only seem a few feet in front of you with the light from your lantern.",
                "You enter a chamber, it looks like someone of importance has stayed in this room.",
                "You arrive in a room filled with sarcophagi, and the smell is almost unbearable.",
                "As you enter the room, you realize you are standing on a platform surrounded by 10 foot tall spikes.",

                    };

            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }

    }//end class
}//end main

