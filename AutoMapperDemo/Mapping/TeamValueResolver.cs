using System.Linq;
using AutoMapper;
using AutoMapperDemo.Domain;

namespace AutoMapperDemo.Mapping
{
    public class TeamValueResolver : ValueResolver<Team, decimal>
    {
        protected override decimal ResolveCore(Team source)
        {
            return source.Players.Sum(player => player.Value);
        }
    }
}