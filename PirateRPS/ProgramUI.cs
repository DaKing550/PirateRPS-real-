using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateRPS
{
   public class ProgramUI
    {
        public void Run()
        {
            // Console.Writeline($"You won that round... your health is at {variable} and the enemy is at {enemyvariable}");
                // keep track of win total

                Random random = new Random();
                bool playAgain = true;
                string player;
                string computer;
                int win = 0;
                int loss = 0;

            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "laser" && player != "netting" && player != "cannon")
                {
                    Console.WriteLine("ARR, Welcome to Robot Pirate Island! it be PIRATES vs ROBOTS, Choose your weapon.\n" +
                            "LASER, CANNON, NETTING.");
                    player = Console.ReadLine();
                    player = player.ToLower();
                }

                switch (player)
                {
                    case "paper":
                        if  (computer == "scissors")
                        {
                            Console.WriteLine("Arrgh matey, ya lost... git gud");
                            loss++;
                        Console.WriteLine($"Your record stands at {win} and {loss}");
                        }
                        else if (computer == "rock")
                        {
                            Console.WriteLine("Congrats me Friend.... ya won one");
                                win++;
                            Console.WriteLine($"you stand at {win} wins and {loss} losses ");
                        }
                        else
                        {
                            Console.WriteLine("Oops.. try again bucko");
                        
                        }
                        break;
                    case "rock":
                        if (computer == "paper")
                        {
                            Console.WriteLine("Arrgh matey, ya lost... git gud");
                            loss++;
                        Console.WriteLine($"Your record stands at {win} and {loss}");
                        }
                        else if (computer == "scissors")
                        {
                            Console.WriteLine("Congrats me Friend.... ya won one");
                                win++;
                            Console.WriteLine($"you stand at {win} wins and {loss} losses ");
                        }
                        else
                        {
                            Console.WriteLine("Oops.. try again bucko");
                        }
                        break;

                    case "scissors":
                        if (computer == "rock")
                        {
                            Console.WriteLine("Arrgh matey, ya lost... git gud");
                            loss++;
                        Console.WriteLine($"Your record stands at {win} and {loss}");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("Congrats me Friend.... ya won one");
                                win++;
                            Console.WriteLine($"you stand at {win} wins and {loss} losses ");
                        }
                        else
                        {
                            Console.WriteLine("Oops.. try again bucko");
                        }
                        break;
                }


            }
        }
    }   
}
