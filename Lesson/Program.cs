using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Greatest Number
              /*int x;
            int y;
            int z;
            Console.WriteLine("Enter the first number: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            z = int.Parse(Console.ReadLine());
            if(x > y )
            {
                if(x > z)
                {
                    Console.WriteLine($"The biggest number is your first number {x}");
                }
                else
                {
                    Console.WriteLine($"The biggest number is your third number {z}");
                }
                
            }
            else if( y > z)
            {
                Console.WriteLine($"the biggest number is your second number {y}");
            }
            else
            {
                Console.WriteLine($"the biggest number is your third number {z}");
            }*/

            
            //Random number generator     
            /*Random randomGenerator = new Random();
            int cpuRoll = randomGenerator.Next(1, 7);
            Console.WriteLine("Throw a dice (enter a number from 1-6): ");
            int userRoll = int.Parse(Console.ReadLine());

            if(userRoll > cpuRoll)
            {
                Console.WriteLine("Congratulations, you won!");
            }
            else if(userRoll < cpuRoll)
            {
                
                Console.Write("You lost! Try again!");
            }
            else
            {
                Console.WriteLine("Tie!");
            }*/


           /* int userRoll;
            int cpuRoll;
            int rolls = 0;
            int userScore = 0;
            int cpuScore = 0;

            Random rnd = new Random();

            while(rolls < 3)
            {
                userRoll = rnd.Next(1, 7);
                cpuRoll = rnd.Next(1, 7);

                Console.WriteLine($"You rolled {userRoll}, CPU rolled {cpuRoll}");
                
                if(userRoll > cpuRoll)
                {
                    //userScore = userScore + 1;
                    userScore++;
                }
                else if(userRoll < cpuRoll)
                {
                    cpuScore++;
                }
                else
                {
                    continue;
                }

                //rolls = rolls +1;
                rolls++;
                Console.ReadLine();
            }

            if(userScore > cpuScore)
            {
                Console.WriteLine("Congratulation! You won!");
            }
            else if(userScore < cpuScore)
            {
                Console.WriteLine("Oops, you lost. Try again.");
            }
            else
            {
                Console.WriteLine("Tie. Nobody wins or loses");
            }
            Console.WriteLine($"You scored {userScore}, CPU scored {cpuScore}");*/



            /*Random rnd = new Random();
            int randomNumber = rnd.Next(1, 6);
            Console.WriteLine($"CPU generated {randomNumber}");

            switch(randomNumber)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("CPU generated nothing");
                    break;
            }
            Console.WriteLine("One");*/

            Console.WriteLine("Pick a color (red, black, blue): ");
            string answer = Console.ReadLine();

            switch(answer)
            {
                case "red":
                    Console.WriteLine("You are a romantic type");
                    break;
                case "black":
                    Console.WriteLine("You are a loner");
                    break;
                case "blue":
                    Console.WriteLine("You are in love with the sea");
                    break;
                default:
                    Console.WriteLine("Cannot recognize the color");
                    break;
            }
        

            Console.ReadLine();



        }
    }
}
