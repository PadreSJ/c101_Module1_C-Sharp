/***************************************************************************************************************
 * 
 *  Coding 101
 *  On The TWiT Network ( www.twit.tv )
 *  
 *  101 Coding Example 3
 *  Description: Ask a user for text and a number - print out the text the amount of types they provided.
 * 
 *  Remark(s): BTW - This section, with lots of *'s, is called a comment section.
 *  
 *  Assignment: Change the way the code runs, send different messages to the user, and ask for different input.
 *   - Try asking the user if they want to print the Text on different lines?
 *  
 *  @LouMM, @PadreSJ, @Snubs
 ****************************************************************************************************************/

using System;

namespace TWiT.Tv.Coding101
{
	class Coding101Example3
	{
		static void Main(string[] args)
		{
			Console.Write("What would you like to write? (example: Hello World!): "); //Ask the user what they want written.
			string text = Console.ReadLine(); //Using 'Readline' here will wait for the user to finish typing a line of text and hit <enter>.

			
			Console.Write("\nHow many times would you like to output it to the screen? (Example: 3): "); //Ask the user how many types they wanted it outputted
			string repeatNumberText = Console.ReadLine(); //Using 'Readline' here will wait for the user to finish typing number and hit <enter>.
			int repeatNumber = 0; //Initialize a variable to store the repeat number entered by the user, for use later.
			
			if (!int.TryParse(repeatNumberText, out repeatNumber)) //Convert the number from text entered by the user to an actual number type. (in this case a integer)
			{
				Console.ForegroundColor = ConsoleColor.Red; //Change the console to red to inform the user they entered incorrectly.
				Console.WriteLine("We could not convert the text you entered,{0},to a number", repeatNumberText);
				Console.ResetColor();
				Console.WriteLine("Type <Enter> to Exit");
				Console.Read();
				return;
			}

			int count = 1;//Initializer moved to outer scope, or intialized outside the loop for use later to display the count to the user.
			for(; count <= repeatNumber; count++)
			{
				//Write the text out with a space in between using {composite formatting} which is the 0 place holder that is replaced with the text. 
				//http://msdn.microsoft.com/en-us/library/txafckwd(v=vs.110).aspx
				Console.Write("{0}", text); 
			}

			Console.WriteLine("\nThe Count was {0}.", count); //What is your count? why do you think it is THAT number?

			//Tell the user to type <enter> to exit using Magenta text.
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("\nType <Enter> to Exit.");
			Console.ResetColor();//Reset the console color to the default.
			Console.ReadKey();
		}
	}
}
