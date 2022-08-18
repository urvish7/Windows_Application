using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

// Namespace
namespace ConsoleApp
{
    // Main Class
    internal class Program
    {
        // Entry point Method
        static void Main(string[] args)
        {
            // running a sample get info function
            getAppInfo();

            //Ask users name
            Console.WriteLine("Whats your name?");

            //Get user input
            string input = Console.ReadLine();
            Console.WriteLine("Hello {0}, the Game begins", input);

            while (true)
            {

                // create a random number
                Random random = new Random();

                // assigning the number to variable
                int setnumber = random.Next(1,5);

                // guessing the number
                int guess = 0;

                // Asking the user for number to guess between 1-5
                Console.WriteLine("guess a number in between 1 t0 5");

                // looping in the function until the guess is not correct
                while (guess != setnumber)
                {
                    // get the user input
                    string userinput = Console.ReadLine();

                    // getting the number from user
                    if (!int.TryParse(userinput, out guess))
                    {
                        //if not using the number requesting to enter the actual number
                        PrintColor(ConsoleColor.Red, "Please use actual number");

                        // continue
                        continue;
                    }

                    // changing the type to int and assign to guess
                    guess = Int32.Parse(userinput);


                    // comparing the guess to the set number
                    if (guess != setnumber)
                    {
                        // showing an error messgae that guess is wrong and try again
                        PrintColor(ConsoleColor.Magenta, "Wrong Guess, please try again");
                    }

                }

                // if the number matches then print the success message

                PrintColor(ConsoleColor.DarkGreen, "Bingo! you got it");
                
                // Ask if they wanna start over
                Console.WriteLine("Play Again? [Y or N]");

                // Assign the input
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        static void getAppInfo()
        {
            // the number gussers
            string appName = "Testing";
            string appversion = "1.0.0";
            string appAuthor = "Urvish Desai";

            // changing the text color
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // mentioning the app info
            Console.WriteLine("{0}: version {1} by {2}", appName, appversion, appAuthor);

            // resetting the color back to its place
            Console.ResetColor();


          
        }
        //the color function
        static void PrintColor(ConsoleColor color, string message)
        {
            // changing the text color
            Console.ForegroundColor = color;

            // mentioning the app info
            Console.WriteLine(message);

            // resetting the color back to its place
            Console.ResetColor();

        }
    }
}
