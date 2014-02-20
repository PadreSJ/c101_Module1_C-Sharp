using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tic tac toe game By Joshua 2-18-14
            //Declaring variables
            int catcount = 0;
            bool catflag = false;
            bool winflag = false;
            bool nameflag = false;
            //name picker
            string Player2name = "";
            string PlayerName = "";
            Console.Write("Please Enter Player 1's name:");
            string Player1name = Console.ReadLine();
            while (nameflag == false)
            {
                Console.Write("Please Enter Player 2's name:");
                Player2name = Console.ReadLine();
                if (Player2name != Player1name)
                {
                    nameflag = true;
                }
            }
            string[,] board = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
            bool errflag = false;

            //Play the game
            while (winflag == false)
            {
                for (int Player = 1; Player <= 2; Player++)
                {
                    //Draw the board
                    BoardDraw(board);
                    //Cat Count
                    catcount++;

                    //Makes The Names Appear
                    if (Player == 1)
                    {
                        PlayerName = Player1name;

                    }
                    else
                    {
                        PlayerName = Player2name;

                    }
                    Console.Write("{0}'s row:", PlayerName);
                    string row = Console.ReadLine();
                    Console.Write("{0}'s col:", PlayerName);
                    string col = Console.ReadLine();
                    int rownumber = 0;
                    int colnumber = 0;
                    if (!int.TryParse(row, out rownumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Red; //Changing the Color of the Text
                        Console.WriteLine("There was an error converting what you typed to a Integer (Int32) number. <Enter> To exit. ");
                        Console.ResetColor(); //Reseting the color to the normal console color. <Enter> to exit.
                        Console.ReadKey(); //Wait for the user to hit enter
                        return;
                    }
                    if (!int.TryParse(col, out colnumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Red; //Changing the Color of the Text
                        Console.WriteLine("There was an error converting what you typed to a Integer (Int32) number. <Enter> To exit. ");
                        Console.ResetColor(); //Reseting the color to the normal console color. <Enter> to exit.
                        Console.ReadKey(); //Wait for the user to hit enter
                        return;

                    }
                    //Check If a vaild row number
                    if (rownumber > 2)
                    {
                        rownumber = 0;
                        Console.WriteLine("Invalid Row Number");
                        errflag = true;
                    }
                    //Check If a vaild col number
                    if (colnumber > 2)
                    {
                        colnumber = 0;
                        Console.WriteLine("Invalid Col Number");
                        errflag = true;
                    }
                    //Check if negitave row number
                    if (rownumber < 0)
                    {
                        rownumber = 0;
                        Console.WriteLine("Invalid Row Number");
                        errflag = true;
                    }
                    if (colnumber < 0)
                    {
                        colnumber = 0;
                        Console.WriteLine("Invalid Col Number");
                        errflag = true;
                    }
                    //Check If a space is taken
                    if (board[rownumber, colnumber] != " ")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error:Space is taken");
                        errflag = true;
                        Console.WriteLine("Press <ENTER> To Continue");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    //Reset Player If error
                    if (errflag == true)
                    {
                        Player--;
                        errflag = false;
                    }
                    else if (Player == 1)
                    {


                        board[rownumber, colnumber] = "X";
                    }
                    else
                    {
                        board[rownumber, colnumber] = "O";
                    }

                    //Check for winner
                    for (int counter1 = 0; counter1 < 2; counter1++)
                    {

                        //This is checking the vertical win
                        if (board[0, counter1] == board[1, counter1])
                        {

                            if (board[1, counter1] == board[2, counter1] && board[2, counter1] != " ")
                            {
                                winflag = true;
                                Player = 3;
                            }
                        }
                        //this is checking the horizontal win
                        if (board[counter1, 0] == board[counter1, 1])
                        {
                            if (board[counter1, 1] == board[counter1, 2] && board[counter1, 2] != " ")
                            {
                                winflag = true;
                                Player = 3;

                            }
                        }

                    }
                    //this is checking diagonal (<)
                    if (board[0, 0] == board[1, 1])
                    {
                        if (board[1, 1] == board[2, 2] && board[2, 2] != " ")
                        {
                            winflag = true;
                            Player = 3;
                        }
                    }
                    //this is checking diagonal (>)
                    if (board[2, 0] == board[1, 1])
                    {
                        if (board[1, 1] == board[0, 2] && board[0, 2] != " ")
                        {
                            winflag = true;
                            Player = 3;
                        }
                    }
                    //this checks if nobody wins
                    if (catcount == 9)
                    {
                        if (winflag == false)
                        {
                            winflag = true;
                            Player = 3;
                            PlayerName = "cat";
                        }
                    }

                }


            }
            BoardDraw(board);
            Console.WriteLine("{0} won the game", PlayerName);
            Console.WriteLine("Press <ENTER> To continue");
            Console.ReadLine();
        }


        public static void BoardDraw(string[,] board)
        {
            //Board Drawing Function
            Console.WriteLine(" 0 1 2");
            Console.WriteLine("0{0}|{1}|{2}", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine(" -+-+-");
            Console.WriteLine("1{0}|{1}|{2}", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine(" -+-+-");
            Console.WriteLine("2{0}|{1}|{2}", board[2, 0], board[2, 1], board[2, 2]);

        }
    }
}


