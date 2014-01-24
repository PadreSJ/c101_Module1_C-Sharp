/***************************************************************************************************************
 * 
 *  Coding 101
 *  On The TWiT Network ( www.twit.tv )
 *  
 *  101 Coding Example
 *  Description: Ask a user for binary number input and convert it to decimal. 
 * 
 *  Remark(s): BTW - This section with lots of *'s is called a comment section.
 *  
 *  Assignment: Find Change the way the code runs, send different messages to the user, and ask for different input.
 *  
 *  @LouMM, @PadreSJ, @Snubs
 ****************************************************************************************************************/
 
using System;

namespace Coding101
{
    class Program
    {
        /************Download the IDE************/
        //For Mac Users:        http://monodevelop.com/
        //For Windows Users:    http://www.visualstudio.com/

        /// <summary>
        /// Main function used in any console application.
        /// </summary>        
        static void Main(string[] args)
        {
            //Ask the user to enter a binary number:
            Console.Write("Please Enter a Binary Number (example: 110001): ");
            
            //This is where we read what binary number the user typed and hit <enter>
            //We store it in this fancy string variable for use later.
            string enteredBinaryNumber = Console.ReadLine(); 

            //Here is where we take the entered number and pass it off to 
            long number = ConvertBinaryToDecimal(enteredBinaryNumber);

            Console.Write("Your converted decimal number is ");
            Console.Write(number); //Write the converted number to user. (could use a tokenizer here)

            //Pauses the console app until the user hits enter to exit.
            Console.WriteLine("\nHit <Enter> to exit. "); //Notice the '\n' before this line, tells the Write to put it on a new line.
            Console.Read(); //Pause 

            //Check out: http://msdn.microsoft.com/en-us/library/System.Console_methods(v=vs.110).aspx For more Details on Console.
            //Try changing the color of the text!
        }

        
        #region For Another Time (Check it out if you are brave or pro :) )
        

        /// <summary>
        /// Manually Converts the number entered from Binary String to a Number.
        /// </summary>
        /// <remarks>
        /// Yes, we know there are Library functions that do this more efficiently, leaner, and meaner. :) 
        /// This is so we can learn things like loops, variables, incrementing, decrementing, etc...
        /// Come with us on the journey...
        /// </remarks>
        /// <param name="number">Binary Number <c>string</c></param>
        /// <returns>Decimal Number</returns>
        public static long ConvertBinaryToDecimal(string number)
        {            
            number = number.ToUpperInvariant();

            long decimalNumber = 0;
            long baseMultiplier = 1; //2^0=1

            //Start from the end and work backwards with binary numbers.
            for (int i = number.Length - 1; i >= 0; i--)
            {
                //Loop each digit.
                char binaryCharacter = number[i];
                if (i == 0 && binaryCharacter == '-')
                {
                    //If the number is negative, make sure the return number is negative too.
                    decimalNumber = -decimalNumber;
                    break;
                }
                
                //If the user decided to enter a number that isn't binary
                if (binaryCharacter != '1' && binaryCharacter != '0')
                {
                    Console.WriteLine("Invalid Character {0}", binaryCharacter); //To Simplify, just write to console to inform the user.
                    //We would normally throw an exception and handle it.    
                    decimalNumber = 0; //just return 0 since we can't convert it.
                    break;
                }
                int digit = binaryCharacter == '1' ? 1 : 0;

                decimalNumber += digit * baseMultiplier;

                baseMultiplier *= 2; //Next digit
            }

            return decimalNumber; //return the result back
        }

        #endregion
    }

}
