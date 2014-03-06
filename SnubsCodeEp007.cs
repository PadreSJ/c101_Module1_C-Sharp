using System;
namespace TwiT.Tv.Coding101
{
    partial class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Your dinner / movie date locations are next door to each other. Minutes until your dinner reservation: ");
                decimal Dinner = decimal.Parse(Console.ReadLine()); 
                Console.Write("Minutes until the movie: ");
                decimal Movie = decimal.Parse(Console.ReadLine());
                Console.WriteLine();

                int MinutesToLeave = HowLongTilILeave(Movie, Dinner); 
                Console.WriteLine("You should leave dinner after {0} minutes to be at the movie on time.", MinutesToLeave); 

                Console.Write("<enter> to continue, <esc> or q to quit: "); 
                var key = (int)Console.ReadKey(true).Key; 
                if (key == 27 /* <esc> key*/ || key == 81 /* letter q*/)
                    break;
                Console.Clear(); 
            }
        }

        static int HowLongTilILeave(decimal Dinner, decimal Movie)
        {
            int MinutesToLeave = 0; 

            decimal TotalTime = Dinner - Movie; 
            MinutesToLeave = (int)Math.Round(Dinner - Movie, 0); 

            return MinutesToLeave; 
        }


    }
}
