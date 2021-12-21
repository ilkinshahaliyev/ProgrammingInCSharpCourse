using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            const string apiUrl = "https://catfact.ninja/fact";

            var httpClient = new HttpClient();

            bool isContinue;

            Console.WriteLine("\t\t\t\tStarting to show Cat Facts from API :\n");

            do
            {
                var result = await httpClient.GetStringAsync(apiUrl);

                var catInfo = JsonConvert.DeserializeObject<CatInfo>(result);

                Console.WriteLine($"Fact : {catInfo.Fact} \n");

                Console.WriteLine("Should another fact be shown? (true / false)");
                isContinue = Convert.ToBoolean(Console.ReadLine());

                Console.Write(Environment.NewLine);

            } while (isContinue);

            Console.ReadKey();
        }
    }
}
