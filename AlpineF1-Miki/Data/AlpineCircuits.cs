namespace AlpineF1_Miki
{
    public class AplineCircuits
    {
        public int id { get; set; }
        public string? track_name { get; set; }
        public string? track_location { get; set; }
        public string? date_added { get; set; }
    }

    public class AplineCircuitPoints
    {
        public int id { get; set; }
        public string? track_name { get; set; }
        public string? track_location { get; set; }
        public string? circuit_points { get; set; }
    }

    public class PagedCircuitPoints
    {
        public string Points { get; set; }
        public int TotalPoints { get; set; }
    }
}