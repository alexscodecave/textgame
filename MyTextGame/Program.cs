using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings
            string playerName;
            string playerChoice;
            int correct = 0;


            Console.WriteLine("Hello good sir/Madam please enter your name:");
            playerName = Console.ReadLine();
            Console.WriteLine("Ahh yes " + playerName + " the name of a warrior, I have a challenge for you" +
                " if you can slay the 3 beasts located in this without dying a horrible death I will grant you one wish");
            

            do
            {
                Console.WriteLine("Are you up for the challenge?:");
                playerChoice = Console.ReadLine().ToUpper();
                if (playerChoice == "YES")
                {
                    Console.WriteLine("Fantastic let us continue on with our adventure! First we need to pick a weapon for you!");
                    correct = 1;
                    
                }
                else if (playerChoice == "NO")
                {
                    Console.WriteLine("Ahhh ok greater men than you have failed " + playerName);
                    correct = 1;
                    
                }
                else
                {
                    Console.WriteLine("Error please try again");
                    correct = 0;
                }

            } while (correct == 0);
           


                


        }
    }
}
