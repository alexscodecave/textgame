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
            string playerChoice;

            Player player = new Player(10, 10, 5, 0, 1);
            
            Console.WriteLine("Player level: " + player.Level);

            Player[] playerList = new Player[2];
            playerList[0] = new Player(20, 20, 20, 20, 5);
            playerList[0] = new Player(20, 20, 20, 20, 10);

            //Integers
            int correct = 0;

            //Ask user for name
            Console.WriteLine("Hello good sir/Madam");
            Console.WriteLine("I have a challenge for you" +
                " if you can slay the 3 beasts located in this without dying a horrible death I will grant you one wish");
            

            //do loop to continue until user enters either yes or no
            do
            {
                Console.WriteLine("Are you up for the challenge?:");
                //convert what the user enters to uppercase in case of YeS or nO instances
                playerChoice = Console.ReadLine().ToUpper();
                if (playerChoice == "YES")
                {
                    Console.WriteLine("Fantastic let us continue on with our adventure! First we need to pick a weapon for you!");
                    correct = 1;
                    
                }
                else if (playerChoice == "NO")
                {
                    Console.WriteLine("Ahhh ok greater greater people than you have failed ");
                    correct = 1;
                }
                else
                {
                    Console.WriteLine("Error please try again");
                    correct = 0;
                }

            } while (correct == 0);
            Console.ReadLine();

            Console.WriteLine("This planet is full of wonderful entities, but one thing that is truly exceptional is the craftmanship" +
                " that is available here, you have many great weapons to choose from! Oh please... take a look!");
            Console.WriteLine("But first let us view your current player profile");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Gold: " + player.Gold.ToString());
            Console.WriteLine("Experience points: " + player.XP.ToString());
            Console.WriteLine("Current Level: " + player.Level.ToString());


            Console.ReadLine();
            
        }
    }
}
