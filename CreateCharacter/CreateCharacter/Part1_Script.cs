using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace CreateCharacterMain
{
    class Part1_Script : IntroPlot
    {

        private static string gameName = "Unknown Quest";
        public static void FirstPart()
        {


            Clear();
            ContinueToGame();
            Clear();

            NameGame();
            ReadKey();

            WriteLine("\nWelcome to the very beginning of the adventure\n");
            WriteLine("\nYou feel cold, and you're trying to open your eyes. You don't remember " +
                "anything recent but you know your name" + " is " + playerSheet.Name + ".  " +
                " You also remember that you are " + playerSheet.Age + " years old." + " Because of your age, you realize that you can only be a " + playerSheet.Race + ".");
            WriteLine("\nYou finally managed to open your eyes you notice a quaint fire pit in front of you." +
                " Your hands are tied together, it's like someone caputred and drugged you.\n");
            WriteLine("You know you need to get out of this place, good thing you are a " + playerSheet.CharClass + ".  You know just the trick to get out of this situation!");
            ReadKey(false);
            GetOutOfRope();
        }
        /// <summary>
        /// Gets out of rope
        /// </summary>
        /// 
        public static void SecondPart()
        {
            Clear();
            WriteLine("Now that you're out of the rope you decided to stand up and observe the cave.\n");
            WriteLine("From what you can tell, you're at the back of a cave. The fire pit you are by looks abandoned.\n" +
                "There is no trace of whoever brought you here, so you decide to leave the cave.\n");
            Console.WriteLine("Press Enter to procced.");
            ReadKey(false);
            Clear();
            WriteLine("You stumble out of the cave and find that you're at the top of a small hill.  You can see a " +
                "rugged path through some weak woods that is followed by a very thick swamp and in the other direction there is a fairly" +
                " used path.");
            WriteLine("\nYou decide to look up at the sun to figure out how much daylight you have and to figure out your directions. "
                + "You reailze the Swamp faces North and the nicer trail is to the West.");
            ReadKey(false);
            Clear();
            SwampOrWest();
            West();
            StrangerEncounter();





        }
        public static void GetOutOfRope()
        {
            Clear();
            if (playerSheet.CharClass == "Warrior")
            {
                WriteLine("You use your imense strength to break out of the rope.");
            }
            if (playerSheet.CharClass == "Mage")
            {
                WriteLine("Your intelligence makes you think outside of the box. You come up with a quick way" +
                    " to combust the area around the rope into fire.  Once the rope has burned just enough, you rip out of the bondage");
            }
            if (playerSheet.CharClass == "Theif")
            {
                WriteLine("Since you're a Theif you already got yourself out of the bondage.");
            }
            if (playerSheet.CharClass == "Cleric")
            {
                WriteLine("The bondage is so tight aroudn your hands, it's very hard for you to get out.  Usually in tight situations" +
                    " you send a prayer off.  You go into deep mediation and relay a connection with your entity and the bondage starts to loosen.  " +
                    "You're safely able break loose");
            }
            ReadKey();

        }

        public static void NameGame()
        {

            WriteLine("Would you like to rename this game? Enter y if so\n");
            string choice = Console.ReadLine();


            if (choice == "y")
            {
                WriteLine("\nEnter a new name, otherwise press the enter key: \n");
                string newName = Console.ReadLine();
                gameName = newName;
                Clear();

                WriteLine("\nYou've decided to name the game: " + gameName.ToUpper());
                ReadKey(false);
                Clear();



            }
            else
            {
                WriteLine("\nWelcome to " + gameName.ToUpper());
                ReadKey(false);
                Clear();
            }



        }// end Rename Game
        public static void ContinueToGame()
        {
            Console.Clear();
            WriteLine("Are you happy with your decisions?  If not type n now if you want to restart the set up");
            string choice = ReadLine();

            if (choice.ToUpper() == "N")
            {
                Console.Beep();
                Console.Clear();
                IntroWalkthough.AskForName();
                IntroWalkthough.GetRace();
                IntroWalkthough.GetClass();
                IntroWalkthough.GetStats();

                Clear();
            }

            else
            {

                Console.WriteLine("Press enter to continue to Main game.");
                ReadKey(false);
                Clear();
            }
        }// end ContinueToGame

        public static void SwampOrWest()
        {


            int counter = 1;
            while (counter == 1)
            {
                WriteLine("Choose a direction:");
                
                WriteLine("Which direction would you like to go?  Press 's' for swamp or 'w' for west: ");
                string choice = ReadLine().ToUpper();

                if (choice == "S")
                {
                    counter++;
                    Swamp();
                    ReadKey(false);

                }

                if (choice == "W")
                {
                    counter++;
                    Clear();
                    WriteLine("You decide to head west and take the safe route.");
                    ReadKey(false);
                }
               
            }
        }// end SwampOrWest


        public static void Swamp()
        {
            Clear();
            WriteLine("You decide that the swamp looks like a neat place to explore, maybe you'll find out" +
                " more about why you woke up in a cave.\n" +
                "You had no trouble bouldering down the small bluff. You notice there's an even bigger cave entrance behind you " +
                "facing the south, however it's boarded up.  You press onward on the rugged trail towards the swamp.\n");
            ReadKey(false);
            Clear();
            WriteLine("After about a half mile down the trail, it ends to the entrance of a gross looking swamp." +
                " You hear something that sounds like it's popping and you realize there are bubbles coming out of the swamp water" +
                " near you.");
            ReadKey();
            CheckBubbles();
            WriteLine("\nAfter coughing and gagging from the bog fog you realize you made it back to the cave you awoke from." +
                "  You end up heading down the fairly used path, towards the west.");
            ReadKey();
        }// end Swamp Scenario

        public static void CheckBubbles()
        {
            Clear();
            if (playerSheet.Wisdom >= 14)
            {
                WriteLine("Your Wisdom knows better than to stick your hand into a bubbling part of a swamp." +
                    " You decide to wait a minute or two.\n");
                ReadKey(false);

                if (playerSheet.Intelligence >= 15)
                {
                    WriteLine("You're aware that swamps sometimes produce bog gas which is a mixture of natural earth gasses." +
                        " You know best to turn back and quit wasting your time.");
                    ReadKey(false);
                }
                else
                {
                    WriteLine("You're not sure why the swamp is bubiling but you know not to get involved.  You decide to turn back.");
                    ReadKey(false);
                }


            }// end if
            else
            {

                WriteLine("You seem intrigured by this, you've never seen anything like this.");
                WriteLine("Do you want to venture into the swamp and see what this is? \n\nEnter 1 for yes, press any other key to leave" +
                    " the swamp.");
                string choice = Console.ReadLine();


                if (choice == "1")
                {
                    Clear();
                    int damage = 10;
                    int updatedHealth = playerSheet.TempHealth - damage;

                    WriteLine("You take a few steps into the swamp.  It is very hard to move through and it's suprisingly warm." +
                        "  As you walk closer to the bubbles you realize your about knee deep in the swamp.\n" +
                        "  You notice an awful stench coming from the bubbles, it's worse than any farm work you've delt with" +
                        "  Your knees start to buckle and you start gagging.  You loose your footing and bang your knee into a small " +
                        "structure in the swamp, that really hurt!\n");
                    WriteLine("You lost " + damage + (" health points.") + " " +
                        "Your current health is " + (updatedHealth) + "/" + playerSheet.Health);

                    ReadKey(false);

                }// end



                WriteLine("\nYou decided to back out of the swamp and go back to where it's safe.");
               
                ReadKey(false);
                Clear();

                ReadKey(false);

            }// end else
        }// end check bubbles

        public static void West()
        {
            Clear();
            WriteLine("You've been walking along this path now for about a mile, the scenery is a lightwooded area" +
                " that looks like is fading away\n.  Something smells very odd close by, you happen to notice a corpse" +
                " lying on it's back.  You can't tell what sex it is, it looks like it was eaten alive, by you also can't tell" +
                " what from.\n");
            WriteLine("Are you interested in checking the corpse?  Checking corpses is a thing to keep in mind " +
                " since you can salvage useable things from them. ");
            CheckCorpse();


        }// end West

        /// <summary>
        /// Option to search a coropse, boolean logic - checks to see if boolean is typed in
        /// </summary>
        public static void CheckCorpse()
        {

            WriteLine("\ntype in 'search' if you are interested in checking the corpse for valuables:\n");
            string search = ReadLine();

            if (search.ToUpperInvariant() == "SEARCH")
                
            {
                Clear();
                if (playerSheet.Race == "Human")
                {
                    WriteLine("You happen to spot something shinny beside the corpse. You realize it's a memento that you" +
                        " completely forgot about. You grab the sliver ring packed with an amythest.");
                    Console.Beep(3908, 800);
                }
                if (playerSheet.Race == "Elf")
                {
                    WriteLine("You found your brooch that you've been missing.  You've had this for Many years.");
                    Console.Beep(3098, 800);
                }
                if (playerSheet.Race == "Dwarf")
                {
                    WriteLine("Out of the corner of your eye you notice a leather bag right next to the corpse." +
                        " You quickly snatch it and open it to find a small batch of gold that is worth 100.");
                    playerSheet.Gold += 100;
                    Console.Beep(2000, 800);
                }
                if (playerSheet.Race == "Hobbit")
                {
                    WriteLine("You notice a small little journal that looks like was used for notes. You grabbed and opened it up" +
                        " to find that there are recipies that you could be using for all of your future events. \n" +
                        "\nYou stash this away and save it for later.");
                    Console.Beep(1506, 800);
                }

                WriteLine("\nPress any key to contiune.");
                ReadKey(false);
            }// end check Corpse

        }

        public static void StrangerEncounter()
        {
            Clear();
            WriteLine("You head down the path for about another half mile and you realize the woods are becoming less abundant.\n" +
                ".  You eventually break out of the woods at the top of huge valley.\n" +
                "This valley has a giant ladnscape, and a river that flows from the northeast to the southwest, however " +
                "this looks rather far away, at least five miles to the river.\n");
            WriteLine("\nPast the river you see what seems to be a village. This whole place is somewhere you haven't" +
                " been before. \nYou honestly don't know how to get back to your home, maybe it's best if you walk" +
                " down towards the river, you're rather thirsty.");
            ReadKey(false);
            ListenFor();


        }// end Stranger Encounter

        public static void ListenFor()
        {
            Clear();
            //1st route
            if (playerSheet.Dexterity >= 16)
            {
                WriteLine("You hear the sound of horse footsteps from quite a ways back from the way you came.\n" +
                    "You've got plenty of time to hide and possibly sneak up on the stranger that's about to appear.\n");
                ReadKey();
                SneakUp();

            }
            //2nd route
            if (playerSheet.Dexterity < 16 && playerSheet.Dexterity >=13)
            {
                Clear();
                WriteLine("You managed to sneak behind a boulder just before the stranger arrived.\n");
                DescStranger();
                WriteLine("\n The stranger knows that someone is recently there.");
                WriteLine("\n STRANGER: 'I know someone is here, I am not afraid to endanger you")
                
            }
            //3rd route
            if(playerSheet.Dexterity < 13)
            {

            }

        }

        /// <summary>
        /// Called by Listen For - Theif
        /// </summary>
        public static void SneakUp()
        {
            Clear();
            WriteLine("Press 1 if you'd like to hide!\n");
            string choice = ReadLine();

            if (choice == "1")
            {
                WriteLine("\nYou scaled to the top of a nearby tree along the path, no one can tell you're up there.\n");
                WriteLine("After a minute passes by you finally see a traveler appear. ");
                DescStranger();
                Clear();
                //  WriteLine("You have the thought of ");
                ReadKey(false);
            }

            else
            {
                DescStranger();
            }

        }

        public static void DescStranger()
        {
            WriteLine("The stranger is clothed in long sleeve chestware and wool pants.  They have a hood on, otherwise" +
                " you could tell what gender they are.  They are sitting riding on a well build dark brown horse, looks" +
                " well fed and taken care of.");
            ReadKey();
        }
    }


}
