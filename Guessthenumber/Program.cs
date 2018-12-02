using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessthenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the appinfo and greet user
            Getappinfo();
            GreetUser();

            while (true)
            {
                //Create a new rand obj
                
                Random ran = new Random();
                int correctnumber = ran.Next(1, 10);


                //Init guess var

                int guess = 0;
                //Ask a number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctnumber)
                {
                    //Get user input

                    string input = Console.ReadLine();

                    //try and catch a invalid

                    if (!int.TryParse(input, out guess))
                    {

                        //Print error message
                        Printcolor(ConsoleColor.Red, "Please enter a valid number");


                        continue;
                    }

                    //put the input to guess
                    guess = Int32.Parse(input);

                    //Match guess to correct

                    if (guess != correctnumber)
                    {

                        Printcolor(ConsoleColor.Red, "Wrong number,Please try again");

                    }

                }

                //Out success text
                //Change text color

                Printcolor(ConsoleColor.Yellow, "You are correct!!");


                //Play Again?

                Console.Write("Wanna Play Again? [Y or N]");


                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;

                }
                else if (answer == "N")
                { return;
                }
                   Console.ReadLine();

            }

        }


        //Methods

        static void Getappinfo()
        {
            string appname = "Guess the Number";
            string appversion = "1.0";
            string appauthor = "CodeStrike";

            //Change text color

            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appname, appversion, appauthor);
            Console.ResetColor();


        }

        static void GreetUser()
        {

            //Ask username
            Console.Write("Enter your name:-");
            //Get user  input

            string inputname = Console.ReadLine();

            Console.WriteLine("Hello {0},let's play a Game!", inputname);
        }

        static void Printcolor(ConsoleColor color,string message)
        {
            //Change text color

            Console.ForegroundColor = color;

            //Tell user it isn't a  number
            Console.WriteLine(message);


            //Reset text color
            Console.ResetColor();
        }
    }
}
