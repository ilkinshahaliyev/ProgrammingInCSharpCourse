using System;
using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User ilkin = new User
            {
                Name = "Ilkin",
                Surname = "Shahaliyev",
                Age = 19,
                Country = "Azerbaijan"
            };
            User nurlan = new User
            {
                Name = "Nurlan",
                Surname = "Valizada",
                Age = 28,
                Country = "Azerbaijan"
            };
            User shahali = new User
            {
                Name = "Shahali",
                Surname = "Shahaliyev",
                Age = 17,
                Country = "Azerbaijan"
            };
            User ahmet = new User
            {
                Name = "Ahmet",
                Surname = "Ozkan",
                Age = 9,
                Country = "Turkey"
            };
            User emre = new User
            {
                Name = "Emre",
                Surname = "Ozcelik",
                Age = 7,
                Country = "Turkey"
            };
            User ehmed = new User
            {
                Name = "Ehmed",
                Surname = "Aliyev",
                Age = 22,
                Country = "Azerbaijan"
            };
            User mark = new User
            {
                Name = "Mark",
                Surname = "Tayson",
                Age = 27,
                Country = "USA"
            };
            User cemil = new User
            {
                Name = "Cemil",
                Surname = "Memmedov",
                Age = 20,
                Country = "Azerbaijan"
            };
            User akif = new User
            {
                Name = "Akif",
                Surname = "Salayev",
                Age = 39,
                Country = "Azerbaijan"
            };
            User cihan = new User
            {
                Name = "Cihan",
                Surname = "Cavlak",
                Age = 32,
                Country = "Turkey"
            };

            UserManager userManager = new UserManager();
            userManager.AddUser(ilkin);
            userManager.AddUser(nurlan);
            userManager.AddUser(shahali);
            userManager.AddUser(ahmet);
            userManager.AddUser(emre);
            userManager.AddUser(ehmed);
            userManager.AddUser(mark);
            userManager.AddUser(cemil);
            userManager.AddUser(akif);
            userManager.AddUser(cihan);

            var userList = userManager.GetAllUsers();

            var listResult = GetListAsString(userList);

            Console.WriteLine(listResult);

            Console.WriteLine("--------------");

            var conditionList = userManager.GetUserAgeGreaterThan20();

            var conditionResult = GetListAsString(conditionList);

            Console.WriteLine(conditionResult);

            Console.WriteLine("--------------");

            var conditionList2 = userManager.RemoveAllUsersCountryIsTurkeyAgeLowerThan10();

            var conditionResult2 = GetListAsString(conditionList2);

            Console.WriteLine(conditionResult2);

            Console.ReadKey();
        }

        public static string GetListAsString(List<User> userList)
        {
            string listString = string.Empty;

            foreach (var user in userList)
            {
                listString += $"{user.Name} {user.Surname} {user.Age} {user.Country}, ";
            }

            listString = listString.Trim(' ');
            listString = listString.Trim(',');

            return listString;
        }
    }
}
