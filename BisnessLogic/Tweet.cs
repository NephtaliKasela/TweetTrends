namespace BisnessLogic
{
    public class Tweet
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public List<string> Message { get; set; }
        public double Sentiment { get; set; }
    }
}