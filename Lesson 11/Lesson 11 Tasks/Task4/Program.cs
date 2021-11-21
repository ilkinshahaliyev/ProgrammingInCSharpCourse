using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            bool isCountinue;

            const string ApiUrl = "https://dog.ceo/api/breeds/image/random";

            HttpClient httpClient = new HttpClient();

            Console.WriteLine("Starting... \n");

            do
            {
                var result = await httpClient.GetStringAsync(ApiUrl);

                var dogs = JsonConvert.DeserializeObject<Dogs>(result);

                Console.WriteLine(dogs.MessageLink + "\n");

                Console.WriteLine("Do you want to continue ? true/false \n");

                isCountinue = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();

            } while (isCountinue);

            Console.ReadKey();
        }
    }
}
