using System;
namespace TWiT.Tv.Coding101
{
    class Ep005
    {
        private static void Main(string[] args)
        {
            int selection = 0;
            string userName = Environment.UserName;

            while (true) //Keep looping since this is always true
            {
                PrintMenu(userName);
                selection = (int)Console.ReadKey().Key;
                Console.WriteLine();

                if (selection == 65) //a Selected
                {
                    RunAway(); //
                }
                else if (selection == 66) // b Selected
                {
                    Magic(); //
                }
                else if (selection == 67) // c Selected
                {
                    Sword(); //
                }
                else if (selection == 27 || selection == 13 || selection == 81) //Quit using q, <esc>, or just an <enter>
                {
                    break; //Breaks the loop so it doesn't go forever, and stops the program.
                }
                Console.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// This is a method with no return value, but takes a person's name or username as a parameter
        /// </summary>
        /// <param name="name">Name of UserName of a person.</param>
        static void PrintMenu(string name)
        {
            Console.Title = "TwiT.Tv Coding 101 - Shannon's Example 5"; //Set the title of the console window.

            Console.WriteLine("***      Welcome {0} to Flight of the Dragon!      ***", name); //Print a welcome message using a personalized name
            Console.WriteLine("*You walk into a forest looking for trouble. What do you do when you run into a dragon?");

            Console.WriteLine();
            Console.WriteLine("a  Run away!");
            Console.WriteLine("b  Use a magic spell to stun him.");
            Console.WriteLine("c  Stick 'em with the pointy end of my sword!");
            Console.WriteLine();
            Console.Write("Select a menu item (q to quit):");
        }


        static void RunAway()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("The dragon chases you, and fries you to a crisp! GAME OVER ");
            Console.ResetColor();
            
        }


        static void Magic()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("What kind of magic spell do you use? ");
            String MagicType = Console.ReadLine();

            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your magic ability, {0}, destroys the dragon instantly. CONGRATS! YOU WON!", MagicType);
                Console.WriteLine("Would you like to play again?");
                Console.ResetColor();
            }

            
        }

        static void Sword()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You use the sword on the dragon's weak point, and destroy the beast! Congrats!! YOU WIN! ");
            Console.WriteLine("Play again? Choose your option below or press Q to quit.");
            Console.ResetColor();
        }
    }
}
