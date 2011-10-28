using System.Collections.Generic;

namespace AutoMapperDemo.Domain
{
    public interface IRepository
    {
        List<Team> GetTeams();
    }
}