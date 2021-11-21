using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            bool isContinue;

            const string url = "https://api.nationalize.io/?name=";

            HttpClient httpClient = new HttpClient();

            Console.WriteLine("Starting... \n");

            do
            {
                Console.Write("Enter name : ");
                string text = Console.ReadLine();

                string apiUrl = $"{url}{text}";

                var result = await httpClient.GetStringAsync(apiUrl);

                Nationalize nationalize = JsonConvert.DeserializeObject<Nationalize>(result);

                Console.WriteLine(nationalize.Name + " " + nationalize.Country + "\n");

                Console.WriteLine("Do you want to continue ? true/false \n");

                isContinue = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();

            } while (isContinue);

            Console.ReadKey();
        }
    }
}
