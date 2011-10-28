using System;
using System.Linq;
using AutoMapper;
using AutoMapperDemo.Domain;
using AutoMapperDemo.DTO;
using AutoMapperDemo.Mapping;
using StructureMap;

namespace AutoMapperDemo
{
    public static class Bootstrapper
    {
        public static void Bootstrap()
        {
            BootstrapIoC();
            BootstrapMapping();
        }

        private static void BootstrapIoC()
        {
            ObjectFactory.Initialize(config => config.For<IRepository>().Use<Repository>());
            ObjectFactory.AssertConfigurationIsValid();
        }

        private static void BootstrapMapping()
        {
            Mapper.CreateMap<string, int>().ConvertUsing<StringToIntConverter>();
            Mapper.AddFormatter<DateTimeFormatter>();

            Mapper.CreateMap<Team, TeamDTO>()
                .BeforeMap((team, teamDTO) => Console.WriteLine("Mapping: " + team.Name))
                .ForMember(team => team.UserSupports, opt => opt.NullSubstitute("doesn't support a team"))
                .ForMember(team => team.Points,
                           opt => opt.ResolveUsing(team => team.Players.Sum(player => player.Points)))
                .ForMember(team => team.Value,
                           opt =>
                           {
                               opt.ResolveUsing<TeamValueResolver>();
                               opt.AddFormatter<CurrencyInMillionsFormatter>();
                           })
                .AfterMap((team, teamDTO) => Console.WriteLine("Mapped: " + teamDTO.Name));

            Mapper.AssertConfigurationIsValid();
        }
    }
}