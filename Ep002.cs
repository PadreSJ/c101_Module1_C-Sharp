/***************************************************************************************************************
 * 
 *  Coding 101
 *  On The TWiT Network ( www.twit.tv )
 *  
 *  101 Coding Example 2
 *  Description: Ask a user for number - convert it to binary
 * 
 *  Remark(s): BTW - This section, with lots of *'s, is called a comment section.
 *  
 *  Assignment: Change the way the code runs, send different messages to the user, and ask for different input.
 *   - Also for the pros and experts out there, try coding a more efficient conversion from a number to a binary
 *  
 *  @LouMM, @PadreSJ, @Snubs
 ****************************************************************************************************************/

using System;

namespace TWiT.Tv.Coding101
{
	class Program
	{
		/************Download the IDE************/
		//For Mac Users:        http://monodevelop.com/
		//For Windows Users:    http://www.visualstudio.com/

		/// <summary>
		/// Main function used in many console application.
		/// </summary>        
		static void Main(string[] args)
		{
			//Ask the user to enter a binary number:
			Console.Write("Please Enter a Whole Number (example: 240): ");

			//This is where we read what binary number the user typed and hit <enter>
			//We store it in this fancy string variable for use later.			
			string enteredNumber = Console.ReadLine();

			#region Convert Text(string) to a number (sanitize input)
			//Check that what was entered was what we expected. An Integer number
			int wholeNumber = 0;
			if (!int.TryParse(enteredNumber, out wholeNumber))
			{
				Console.ForegroundColor = ConsoleColor.Red; //Changing the Color of the Text
				Console.WriteLine("There was an error converting what you typed to a Integer (Int32) number. <Enter> To exit. ");
				Console.ResetColor(); //Reseting the color to the normal console color. <Enter> to exit.
				Console.ReadKey(); //Wait for the user to hit enter
				return;
			}
			#endregion

			//Here is where we take the entered number and pass it off to 
			string binaryNumber = ConvertIntToBinary(wholeNumber);

			Console.Write("Your converted binary number is {0}", binaryNumber);//Write the converted number to user. (using a tokenizer here {0})
			 

			//Pauses the console app until the user hits enter to exit.
			Console.WriteLine("\nHit <Enter> to exit. "); //Notice the '\n' before this line, tells the Write to put it on a new line.
			Console.Read(); //Pause 

			//Check out: http://msdn.microsoft.com/en-us/library/System.Console_methods(v=vs.110).aspx For more Details on Console.		
		}

		#region Loops, Increments and Decrements Examples - Conversion Code Check it out		
		/// <summary>
		/// Takes a number and converts it to binary
		/// </summary>
		/// <param name="number">the number entered</param>
		/// <returns>returns a binary number as a string for displaying to users</returns>
		public static string ConvertIntToBinary(int number)
		{
			int bits = (sizeof(int) * 8); //32bits
			char[] result = new char[bits]; //Array to hold the binary numbers http://msdn.microsoft.com/en-us/library/aa288453(v=vs.71).aspx
			
			while (bits > 0)
			{
				bits = bits - 1;
				int remainder = number % 2; //% called mod or modulo which computes the remainder after dividing http://msdn.microsoft.com/en-us/library/0w4e0fzs.aspx
				
				if (remainder == 1) //If remainder is 1, store it as 1
					result[bits] = '1';
				else
					result[bits] = '0'; //Otherwise store it as 0

				number = number / 2; //Take the original number, divide it by 2
			}
			return new string(result).TrimStart('0'); //return the result as a string ,removing extra 0's
		}

		#endregion
	}

}
