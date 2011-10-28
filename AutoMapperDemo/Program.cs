using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapperDemo.Domain;
using AutoMapperDemo.DTO;
using StructureMap;

namespace AutoMapperDemo
{
    class Program
    {
        static void Main()
        {
            Bootstrapper.Bootstrap();
            var repository = ObjectFactory.GetInstance<IRepository>();
            var teams = repository.GetTeams();
            
            Console.WriteLine("Displaying Hand Mapped DTOs....");
            Display(HandMapToDTO(teams));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Displaying AutoMapped DTOs....");
            Display(AutoMapToDTO(teams));

            Console.ReadKey();
        }

        private static IEnumerable<TeamDTO> HandMapToDTO(IEnumerable<Team> teams)
        {
            var teamDTOs = new List<TeamDTO>();
            foreach(var team in teams)
            {
                var teamDTO = new TeamDTO
                {
                    Name = team.Name,
                    Entered = team.Entered.ToString(),
                    UserName = team.User.Name,
                    UserSupports = team.User.Supports ?? "doesn't support a team",
                    UserJoined = team.User.Joined.ToString(),
                    UserIPAddress = team.User.GetIPAddress(),
                    Points = team.Players.Sum(player => player.Points),
                    Value = team.Players.Sum(player => player.Value).ToString("C") + " million"
                };
                int transfers;
                int.TryParse(team.Transfers, out transfers);
                teamDTO.Transfers = transfers;
                teamDTOs.Add(teamDTO);
            }
            return teamDTOs;
        }

        private static void Display(IEnumerable<TeamDTO> teams)
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Teams to display: " + teams.Count());
            foreach (var team in teams)
            {
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("{0} (Entered: {1})", team.Name, team.Entered);
                Console.WriteLine("User: " + team.UserName);
                Console.WriteLine("Supports: " + team.UserSupports);
                Console.WriteLine("Joined: " + team.UserJoined);
                Console.WriteLine("IP Address: " + team.UserIPAddress);
                Console.WriteLine("Points: " + team.Points);
                Console.WriteLine("Value: " + team.Value);
                Console.WriteLine("Transfers: " + team.Transfers);
            }
        }

        private static IEnumerable<TeamDTO> AutoMapToDTO(IEnumerable<Team> teams)
        {
            return Mapper.Map<IEnumerable<Team>, IEnumerable<TeamDTO>>(teams);
        }
    }
}