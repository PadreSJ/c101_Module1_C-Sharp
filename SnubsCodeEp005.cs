using System;


namespace TWiT.Tv.Coding101.Snubs.Example.Ep5
{
    internal class Coding101SnubsExampleEp5
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("What is your favorite color? (Choose RED! Or, BLUE!): ");
            string text = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nWhat is the air speed velocity of an unladen swallow? (It may be 3): "); 
            string repeatNumberText = Console.ReadLine();

            int repeatNumber = 0;

            if (!int.TryParse(repeatNumberText, out repeatNumber))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Your text, {0}, is not a number", repeatNumberText);
                Console.ResetColor();
                Console.WriteLine("Type <Enter> to Exit");
                Console.Read();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nPrint on seperate lines? (y/n): ");
            string onSeperateLinesText = Console.ReadLine();
            bool onSeperateLines = false;
            if (onSeperateLinesText == "y")
            {
                onSeperateLines = true;
            }

            int count = 1;
            for (; count <= repeatNumber; count++)
            {

                if (onSeperateLines)
                {
                    Console.WriteLine(text);
                }
                else
                {

                    Console.Write("{0} ", text);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe Count was {0}.", count);

          
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nType <Enter> to Exit.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
