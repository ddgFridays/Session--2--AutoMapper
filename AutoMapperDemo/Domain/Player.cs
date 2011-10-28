namespace AutoMapperDemo.Domain
{
    public class Player
    {
        public string Name { get; set; }
        public FootballTeam Team { get; set; }
        public Position Position { get; set; }
        public decimal Value { get; set; }
        public int Points { get; set; }
    }

    public enum FootballTeam
    {
        ManUtd,
        ManCity,
        Chelsea,
        Newcastle,
        Liverpool,
        Tottenham,
        AstonVilla,
        Stoke,
        Norwich,
        Swansea,
        QPR,
        Fulham,
        Everton,
        Wolves,
        Arsenal,
        Sunderland,
        WestBrom,
        Wigan,
        Blackburn,
        Bolton
    }

    public enum Position
    {
        GoalKeeper,
        Defender,
        Midfielder,
        Forward
    }
}
