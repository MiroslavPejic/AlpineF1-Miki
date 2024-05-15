namespace AlpineF1_Miki
{
    public class WeatherData
    {
        public Location Location { get; set; }
        public CurrentCondition Current { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string TimeZoneId { get; set; }
        public long LocalTimeEpoch { get; set; }
        public DateTime LocalTime { get; set; }
    }

    public class CurrentCondition
    {
        public long LastUpdatedEpoch { get; set; }
        public DateTime LastUpdated { get; set; }
        public double TempC { get; set; }
        public double TempF { get; set; }
        public int IsDay { get; set; }
        public Condition Condition { get; set; }
        public double WindMph { get; set; }
        public double WindKph { get; set; }
        public int WindDegree { get; set; }
        public string WindDirection { get; set; }
        public double PressureMb { get; set; }
        public double PressureIn { get; set; }
        public double PrecipMm { get; set; }
        public double PrecipIn { get; set; }
        public int Humidity { get; set; }
        public int Cloud { get; set; }
        public double FeelsLikeC { get; set; }
        public double FeelsLikeF { get; set; }
        public double VisibilityKm { get; set; }
        public double VisibilityMiles { get; set; }
        public double UV { get; set; }
        public double GustMph { get; set; }
        public double GustKph { get; set; }
    }

    public class Condition
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public int Code { get; set; }
    }
}