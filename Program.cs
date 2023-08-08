using System;
using System.Collections.Generic;

namespace PlayerAndTeamRequirements
{
    public class Program
    {
        static void Main(string[] args)
        {
            CricketTeam team = new CricketTeam();

            MainMenu:
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Player");
            Console.WriteLine("2. Remove Player");
            Console.WriteLine("3. Get Player by Id");
            Console.WriteLine("4. Get Players by Name");
            Console.WriteLine("5. Get All Players");
            Console.WriteLine("6. Exit");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please Enter Player Id:");
                        int playerId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please Enter Player Name:");
                        string playerName = Console.ReadLine();

                        Console.WriteLine("Please Enter Player Age:");
                        int playerAge = int.Parse(Console.ReadLine());

                        team.AddPlayer(new Player { Id = playerId, Name = playerName, Age = playerAge });
                        goto MainMenu;

                    case 2:
                        Console.WriteLine("Please Enter Player Id to remove:");
                        int playerIdToRemove = int.Parse(Console.ReadLine());

                        team.RemovePlayer(playerIdToRemove);
                        goto MainMenu;

                    case 3:
                        // ... Similar for other cases ...
                        
                    case 6:
                        Console.WriteLine("Exiting the program.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        goto MainMenu;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                goto MainMenu;
            }

            Console.WriteLine();
        }
    }
}
