using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            bool isContinue;

            const string url = "https://api.genderize.io/?name=";

            HttpClient httpClient = new HttpClient();

            Console.WriteLine("Starting... \n");

            do
            {
                Console.Write("Enter name : ");
                string text = Console.ReadLine();

                string ApiUrl = $"{url}{text}";

                var result = await httpClient.GetStringAsync(ApiUrl);

                var genderize = JsonConvert.DeserializeObject<Genderize>(result);

                Console.WriteLine(genderize.Name + " " + genderize.Gender + "\n");

                Console.WriteLine("Do you want to continue ? true/false \n");

                isContinue = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();

            } while (isContinue);

            Console.ReadKey();
        }
    }
}
