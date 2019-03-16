using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrEmpty(player.Name))
            {
                Console.WriteLine("player name is null or whitespace");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;


            //using overload method on GetValueOrDefault to specify a default value of -1
            //int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);
            Console.WriteLine($"{days} days since last login");

            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin.Value);
            //}
            //else
            //{

            //    Console.WriteLine("No Value for DaysSinceLastLogin");
            //}

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if (player.IsNoob == null)
            {
                Console.WriteLine("player newbie status is unknown");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("player is newbie");
            }
            else
            {
                Console.WriteLine("player is experienced");
            }
        }
    }
}
