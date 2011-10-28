using System;
using System.Collections.Generic;

namespace AutoMapperDemo.Domain
{
    public class Team
    {
        public string Name { get; set; }
        public DateTime Entered { get; set; }

        public User User { get; set; }

        public List<Player> Players { get; set; }
        public string Transfers { get; set; }
    }
}