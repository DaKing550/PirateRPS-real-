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
                // current issues: computer stuck on one option
                //computer ending the game before the player says they no longer want to play


                Random random = new Random();
                bool keepPlaying = true;
                string pirate;
                string robot;
                int win = 0;
                int loss = 0;

            while (keepPlaying)
            {
                
                pirate = "";
                robot = "";


                
                switch (random.Next(1,4))
                {
                    case 1:
                        robot = "cannon";
                        break;
                    case 2:
                        robot = "laser";
                        break;
                    case 3:
                        robot = "netting";
                        break;
                }

                while (pirate != "laser" && pirate != "netting" && pirate != "cannon")
                {
                    Console.WriteLine("ARR, Welcome to Robot Pirate Island! it be PIRATES vs ROBOTS, Choose your weapon.\n" +
                            "LASER, CANNON, NETTING.");
                    pirate = Console.ReadLine().ToLower();
                }

                switch (pirate)
                {
                    case "netting":
                        if  (robot == "laser")
                        {
                            Console.WriteLine("Arrgh matey, ya lost... git gud");
                            loss++;
                        Console.WriteLine($"Your record stands at {win} and {loss}");
                        }
                        else if (robot == "cannon")
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
                    case "cannon":
                        if (robot == "netting")
                        {
                            Console.WriteLine("Arrgh matey, ya lost... git gud");
                            loss++;
                        Console.WriteLine($"Your record stands at {win} and {loss}");
                        }
                        else if (robot == "laser")
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

                    case "laser":
                        if (robot == "cannon")
                        {
                            Console.WriteLine("Arrgh matey, ya lost... git gud");
                            loss++;
                        Console.WriteLine($"Your record stands at {win} and {loss}");
                        }
                        else if (robot == "netting")
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
