using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
        private readonly List<User> _users = new();

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public void AddUserToList(User user)
        {
            _users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public List<User> GetUsersAgeGreaterThan20()
        {
            return _users.Where(user => user.Age > 20).ToList();
        }

        public List<User> GetUsersThatBelongsTurkeyAndAgeLowerThan10()
        {
            var list = _users.Where(user => (user.Country == "Turkey") && (user.Age < 10)).ToList();

            foreach (var user in list)
            {
                _users.Remove(user);
            }

            return _users;
        }
    }
}
