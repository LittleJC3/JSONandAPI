/*
 * Name: John Ciulla
 * Email: ciullajn@mail.uc.edu
 * Assignment: Assignment 11
 * Course/Semester: IT 3045C Fall 2021
 * Description: Pulls info from about music artists
 * Citations: https://developer.napster.com/api/v2.2
 */
using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ciullajn_Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            String apiKey = "OWFmYjljYzUtMGVkYy00YzcxLWIwOTYtMmMxYTY2MTE2YTFh";
            String musicInfoURL = "https://api.napster.com/v2.2/artists/art.978?apikey=" + apiKey;
            //String test = 
            Console.WriteLine(musicInfoURL);
            WebClient wc = new WebClient();
            string jsonStuffs = wc.DownloadString(musicInfoURL);
            JObject jsonObject = JObject.Parse(jsonStuffs);
            Console.WriteLine(jsonObject["artists"].ToString());
        }
    }
}
