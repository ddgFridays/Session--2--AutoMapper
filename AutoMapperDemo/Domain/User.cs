using System;

namespace AutoMapperDemo.Domain
{
    public class User
    {
        public string Name { get; set; }
        public string Supports { get; set; }
        public int Age { get; set; }
        public DateTime Joined { get; set; }

        public string GetIPAddress()
        {
            return "90.204.246.49";
        }
    }
}