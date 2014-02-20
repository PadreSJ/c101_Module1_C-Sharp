/***************************************************************************************************************
 * 
 *  Coding 101
 *  On The TWiT Network ( www.twit.tv )
 *  
 *  101 Coding Example 5
 *  Description: Build a menu system using conditional If statments, methods\functions, and the console.
 * 
 *  Remark(s): BTW - This section, with lots of *'s, is called a comment section.
 *  
 *  Assignment: Add Some more menu items! Maybe try adding some more functions that do things!
 *  
 *  @LouMM, @PadreSJ, @Snubs
 ****************************************************************************************************************/
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
				selection = (int) Console.ReadKey().Key;
				Console.WriteLine();

				if (selection == 65) //a Selected
				{
					RepeatWord(); //Call the method to Repeat a Word
				}
				else if (selection == 66) // b Selected
				{
					ConvertIntToBinary(); //Call the method to Convert a number to a binary.
				}
				else if (selection == 67) // c Selected
				{
					SayHello(userName); //Call the method that says hello to a user.
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
			Console.Title = "TwiT.Tv Coding 101 - Example 5"; //Set the title of the console window.

			Console.WriteLine("***      Welcome {0} to Coding 101!      ***", name); //Print a welcome message using a personalized name
	
			Console.WriteLine();
			Console.WriteLine("a  Repeat a word.");
			Console.WriteLine("b  Convert numbers to binary.");
			Console.WriteLine("c  Say Hello!");
			Console.WriteLine();
			Console.Write("Select a menu item (q to quit):");
		}

		/// <summary>
		/// Method that asks a user for a word to repeat.
		/// </summary>
		static void RepeatWord()
		{
			Console.Write("What word do you want to repeat?: ");
			string textToRepeat = Console.ReadLine();

			int repeatNumber = 0;
			Console.Write("\nHow many times to repeat?: ");
			if(int.TryParse( Console.ReadLine(), out repeatNumber))
			{
				int count = 1;
					//Initializer moved to outer scope, or intialized outside the loop for use later to display the count to the user.
				for (; count <= repeatNumber; count++)
				{
					//Write the text out with a space in between using {composite formatting} which is the 0 place holder that is replaced with the text. 
					//http://msdn.microsoft.com/en-us/library/txafckwd(v=vs.110).aspx
					Console.WriteLine("{0}", textToRepeat);
				}
			}
		}

		/// <summary>
		/// Takes a number and converts it to binary
		/// </summary>
		/// <param name="number">the number entered</param>
		/// <returns>returns a binary number as a string for displaying to users</returns>
		static void ConvertIntToBinary()
		{
			//Ask the user to enter a binary number:
			Console.Write("Please Enter a Whole Number (example: 240): ");


			//This is where we read what binary number the user typed and hit <enter>
			//We store it in this fancy string variable for use later.
			int numberEntered = 0;
			if (int.TryParse(Console.ReadLine(), out numberEntered))
			{
				int bits = (sizeof (int)*8); //32bits
				char[] result = new char[bits]; //Array to hold the binary numbers http://msdn.microsoft.com/en-us/library/aa288453(v=vs.71).aspx


				while (bits > 0)
				{
					bits = bits - 1;
					int remainder = numberEntered % 2;
						//% called mod or modulo which computes the remainder after dividing http://msdn.microsoft.com/en-us/library/0w4e0fzs.aspx


					if (remainder == 1) //If remainder is 1, store it as 1
						result[bits] = '1';
					else
						result[bits] = '0'; //Otherwise store it as 0


					numberEntered = numberEntered / 2; //Take the original number, divide it by 2
				}

				Console.WriteLine("Binary Number: {0}", new String(result).Trim());
			}
		}

		/// <summary>
		/// Method that says hello to a user using a name parameter.
		/// </summary>
		/// <param name="name">The name of the user to say hello to.</param>
		static void SayHello(string name)
		{
			Console.ForegroundColor = ConsoleColor.Cyan; //Changed the color of the text.
			Console.WriteLine("Hi {0}!", name); //Say Hello to the user.
			Console.ResetColor(); //Reset the console color.
		}
	}
}
