using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class UserManager
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public List<User> GetUserAgeGreaterThan20()
        {
            return _users.Where(user => user.Age > 20).ToList();
        }

        public List<User> RemoveAllUsersCountryIsTurkeyAgeLowerThan10()
        {
            var userList = _users.Where(user => (user.Country == "Turkey") && (user.Age < 10)).ToList();

            foreach (var user in userList)
            {
                _users.Remove(user);
            }

            return _users;
        }
    }
}
