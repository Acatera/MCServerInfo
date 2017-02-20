namespace serverInfo
{
    public class Member
    {
        public string Name { get; set; }
        public bool IsOnline { get; set; }
        public string OnlineTime { get; set; }
        public double TotalHoursOnServer { get; set; }
        public int LoginCount { get; set; }
        public string LastSeen { get; set; }
    }
}
