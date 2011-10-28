using System;
using System.Collections.Generic;

namespace AutoMapperDemo.Domain
{
    public class Repository : IRepository
    {
        public List<Team> GetTeams()
        {
            return new List<Team>
            {
                new Team
                {
                        User = new User { Name = "Tom Carroll", Age = 24, Joined = new DateTime(2009, 5, 20) },
                        Name = "Unbelievable Tekkers",
                        Entered = new DateTime(2011, 6, 15),
                        Transfers = "None",
                        Players = new List<Player>
                        {
                            new Player { Name = "Vorm", Value = 4.3m, Points = 37, Position = Position.GoalKeeper, Team = FootballTeam.Swansea },
                            new Player { Name = "Taylor S", Value = 5.0m, Points = 36, Position = Position.Defender, Team = FootballTeam.Newcastle },
                            new Player { Name = "Boswinga", Value = 6.2m, Points = 33, Position = Position.Defender, Team = FootballTeam.Chelsea },
                            new Player { Name = "Williams", Value = 4.6m, Points = 32, Position = Position.Defender, Team = FootballTeam.Swansea },
                            new Player { Name = "Jones", Value = 6.0m, Points = 32, Position = Position.Defender, Team = FootballTeam.ManUtd },
                            new Player { Name = "Silva", Value = 10.1m, Points = 48, Position = Position.Midfielder, Team = FootballTeam.ManCity },
                            new Player { Name = "Nani", Value = 10.2m, Points = 48, Position = Position.Midfielder, Team = FootballTeam.ManUtd },
                            new Player { Name = "Lampard", Value = 11.6m, Points = 42, Position = Position.Midfielder, Team = FootballTeam.Chelsea },
                            new Player { Name = "Young", Value = 10.4m, Points = 45, Position = Position.Midfielder, Team = FootballTeam.ManUtd },
                            new Player { Name = "Aguero", Value = 11.4m, Points = 60, Position = Position.Forward, Team = FootballTeam.ManCity },
                            new Player { Name = "Agbonlahor", Value = 7.1m, Points = 44, Position = Position.Forward, Team = FootballTeam.AstonVilla },
                        }
                },
                new Team
                {
                        User = new User { Name = "Alex Webber", Age = 29, Joined = new DateTime(2007, 7, 2), Supports = "Tottenham" },
                        Name = "Taxi for Vidic",
                        Entered = new DateTime(2011, 6, 4),
                        Transfers = "5",
                        Players = new List<Player>
                        {
                            new Player { Name = "Begovic", Value = 5.1m, Points = 35, Position = Position.GoalKeeper, Team = FootballTeam.Stoke },
                            new Player { Name = "Taylor R", Value = 4.7m, Points = 32, Position = Position.Defender, Team = FootballTeam.Newcastle },
                            new Player { Name = "Boswinga", Value = 6.2m, Points = 33, Position = Position.Defender, Team = FootballTeam.Chelsea },
                            new Player { Name = "Williams", Value = 4.6m, Points = 32, Position = Position.Defender, Team = FootballTeam.Swansea },
                            new Player { Name = "Kompany", Value = 6.0m, Points = 31, Position = Position.Defender, Team = FootballTeam.ManCity },
                            new Player { Name = "Nasri", Value = 9.6m, Points = 41, Position = Position.Midfielder, Team = FootballTeam.ManCity },
                            new Player { Name = "Murphy", Value = 6.2m, Points = 39, Position = Position.Midfielder, Team = FootballTeam.Fulham },
                            new Player { Name = "Larsson", Value = 6.6m, Points = 35, Position = Position.Midfielder, Team = FootballTeam.Sunderland },
                            new Player { Name = "Petrov", Value = 5.8m, Points = 32, Position = Position.Midfielder, Team = FootballTeam.Bolton },
                            new Player { Name = "Rooney", Value = 12.4m, Points = 64, Position = Position.Forward, Team = FootballTeam.ManUtd },
                            new Player { Name = "Suarez", Value = 9.4m, Points = 33, Position = Position.Forward, Team = FootballTeam.Liverpool },
                        }
                }
            };
        }
    }
}