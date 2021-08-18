using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateRPS
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.Writeline($"You won that round... your health is at {variable} and the enemy is at {enemyvariable}");
            // keep track of win total

            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            int win;
            int loss;
            
            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "laser" && player != "netting" && player != "cannon") 
                {
                    Console.WriteLine("ARR, Welcome to Robot pirate Island! it be PIRATES vs ROBOTS, Choose your weapon.\n" +
                            "LASER, CANNON, NETTING.");
                        player = Console.ReadLine();
                        player = player.ToLower();
                }
                

                if (player == computer)
                {
                    Console.WriteLine("ARR, it be a draw!");
                }
            }
        }
    }
}
