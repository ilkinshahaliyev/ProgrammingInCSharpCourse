using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ApiUrl = "https://dog.ceo/api/breeds/image/random";

            string path = @"C:\Users\ilkin\Documents\DogImages";

            HttpClient httpClient = new HttpClient();

            var result = httpClient.GetStringAsync(ApiUrl).Result;

            var dogs = JsonConvert.DeserializeObject<Dogs>(result);

            WebClient photoClient = new WebClient();

            Uri uri = new Uri(dogs.MessageLink);

            photoClient.DownloadFile(uri, path + @"\photo.jpg");
        }
    }
}
