/***************************************************************************************************************
 * 
 *  Coding 101
 *  On The TWiT Network ( www.twit.tv )
 *  
 *  101 Coding Example 6
 *  Description: Using Loops and Functions to Calculate Speed
 * 
 *  Remark(s): BTW - This section, with lots of *'s, is called a comment section.
 *  
 *  Assignment: Change the way the code runs, try converting the numbers to more useful information. 
 *  
 *  @LouMM, @PadreSJ, @Snubs
 ****************************************************************************************************************/
using System;
namespace TwiT.Tv.Coding101
{
	/*START copying from here to paste in your program */
	partial class Program
	{
		/************Download the IDE************/
		//For Mac Users:        http://monodevelop.com/Download
		//For Windows Users:    http://www.visualstudio.com/downloads/download-visual-studio-vs

		/// <summary>
		/// Main function used in many console application.
		/// </summary>   
		static void Main()
		{
			while (true) //Loop used to keep asking for user input.
			{
				Console.Write("Minutes until your appointment: ");
				decimal minutesLeft = decimal.Parse(Console.ReadLine()); //Gets mins as a decimal from the user. (Doesn't check if they dont enter a number)
				Console.Write("Distance you have to travel (in miles): ");
				decimal distanceInMiles = decimal.Parse(Console.ReadLine()); //Gets miles as a decimal from the user. (Doesn't check if they dont enter a number)
				Console.WriteLine();

				int speedInMPH = RequiredSpeedInMPH(distanceInMiles, minutesLeft); //Calculate Required Speed using a function call

				//Write the text out with a space in between using {composite formatting} which is the {0} place holder that is replaced with the text. 
				//http://msdn.microsoft.com/en-us/library/txafckwd(v=vs.110).aspx
				Console.WriteLine("Drive approximately {0} mph nonstop to be on time. Good Luck!", speedInMPH); //Display the result to the user

				int kilometerPerHour = ConvertMPHtoKPH(speedInMPH);
				Console.WriteLine("That is {0} km/h  for those of you using the metric system.", kilometerPerHour);

				Console.ForegroundColor = ConsoleColor.Yellow; //Set the text color to yellow
				Console.WriteLine("***Please Follow Posted Speed Limits***"); //Write the warning to the user
				Console.ResetColor(); //Reset back to the original color

				Console.Write("<enter> to continue, <esc> or q to quit: "); //Tell the user to use <esc> or q to quit.
				var key = (int)Console.ReadKey(true).Key; //Retrieve the user input
				if (key == 27 /* <esc> key*/ || key == 81 /* letter q*/)
					break;
				Console.Clear(); //Clear the console for the next try.
			}
		}

		/// <summary>
		/// Convert Miles Per Hour to Kilometers Per Hour
		/// </summary>
		/// <param name="speedInMPH">Miles per hour as a whole number</param>
		/// <returns>Returns Kilometers per hour as a whole number</returns>
		static int ConvertMPHtoKPH(int speedInMPH)
		{
			return (int)Math.Round(speedInMPH * 1.609344, 0);
		}

		/// <summary>
		/// Calculates Speed based on distance in miles and minutes until your appointment
		/// </summary>
		/// <param name="distanceInMiles">Distance as a decimale</param>
		/// <param name="minutesLeft">Minutes as a decimal</param>
		/// <returns>Speed in MPH as a whole number</returns>
		static int RequiredSpeedInMPH(decimal distanceInMiles, decimal minutesLeft)
		{
			int requiredSpeed = 0; //initialize a variable for the calculated speed to return/

			decimal amountOfHours = minutesLeft / 60; // 60 mins in an hour
			requiredSpeed = (int)Math.Round(distanceInMiles / amountOfHours, 0); //Use the Math library to round the decimal to the nearest whole number

			return requiredSpeed; //return the speed back to the function caller.
		}

		/// <summary>
		/// This is a method with no return value
		/// </summary>
		static void PrintMenu()
		{
			Console.Title = "TwiT.Tv Coding 101"; //Set the title of the console window.

			Console.WriteLine("***      Welcome to Coding 101!      ***"); //Print a welcome message

			Console.WriteLine();
			Console.WriteLine("a  Repeat a word.");
			Console.WriteLine("b  Convert numbers to binary.");
			Console.WriteLine("c  Say Hello!");
			Console.WriteLine();
			Console.Write("Select a menu item (<esc> or q to quit):");
		}



	}

	/*STOP copying from here to paste in your program */
}
