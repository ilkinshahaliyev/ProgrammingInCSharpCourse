using System;
using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

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

            user.AddUserToList(ilkin);
            user.AddUserToList(nurlan);
            user.AddUserToList(shahali);
            user.AddUserToList(ahmet);
            user.AddUserToList(emre);
            user.AddUserToList(ehmed);
            user.AddUserToList(mark);
            user.AddUserToList(cemil);
            user.AddUserToList(akif);
            user.AddUserToList(cihan);

            Console.WriteLine("All users : \n");

            var a = user.GetAllUsers();

            var result = GetListAsString(a);
            Console.WriteLine(result);

            Console.WriteLine("-----------");

            Console.WriteLine("Users that age is greater than 20 : \n");

            var b = user.GetUsersAgeGreaterThan20();
            var result2 = GetListAsString(b);
            Console.WriteLine(result2);

            Console.WriteLine("-----------");

            Console.WriteLine("Remove from list users that country is belongs to Turkey and age is lower than 10 : \n");

            var c = user.GetUsersThatBelongsTurkeyAndAgeLowerThan10();
            var result3 = GetListAsString(c);
            Console.WriteLine(result3);

            Console.ReadKey();
        }

        public static string GetListAsString(List<User> list)
        {
            var str = string.Empty;

            foreach (var user in list)
            {
                str += user.Name + " " + user.Surname + " " + user.Age + " " + user.Country + ", ";
            }

            str = str.TrimEnd(' ');
            str = str.TrimEnd(',');

            return str;
        }
    }
}
