using BisnessLogic;
using DataAccess;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Tweet_Repository Tweets = new Tweet_Repository();
            //List<Tweet> twt = Tweets.ReadTweets("family_tweets2014.txt");
            //Console.WriteLine($"{twt.Count}");
                                                        //Console.WriteLine($"{twt[0].Latitude}");
                                                        //Console.WriteLine($"{twt[0].Longitude}");

            //Sentiment_Repository sentiments = new Sentiment_Repository();
            //List<Sentiment> sentmt = sentiments.ReadSentiments("sentiments.csv");
            //Console.WriteLine($"{sentmt.Count}");

            //Check_Sentiment chkSentiment = new Check_Sentiment();
            //chkSentiment.Check(twt, sentmt);

            //foreach (Tweet t in twt)
            //{
            //    Console.WriteLine($"{t.Sentiment}");
            //}

            USA_States_Coordinates_Repository coor = new USA_States_Coordinates_Repository();
            List<State> states = coor.Read_USAmap_Coordinates("states.json");

            foreach(State st in states)
            {
                Console.WriteLine($"{st.Name}");
                foreach(Geographic_Coordinates geoc in st.Coordinates)
                {
                    Console.WriteLine($"{geoc.Latitude}");
                    Console.WriteLine($"{geoc.Longitude}");
                    Console.WriteLine();
                }
                Console.WriteLine($"-------------------------");
            }
        }
    }
}