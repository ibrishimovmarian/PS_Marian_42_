using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace WelcomeExtended.Data
{
    public class UserData
    {
        private List<User> _users;
        private int _nextId;
        public UserData()
        {
            _nextId = 0;
            _users = new List<User>();
        }

        public void addUser(User user)
        {
            user.id = _nextId++;
            _users.Add(user);
        }

        public void deleteUser(User user)
        {
            _users.Remove(user);
        }

        public bool ValidateUser(string name, string password)
        {
            foreach (var user in _users)
            {
                if (user.Names == name && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateUserLambda(string name, string password)
        {
            return _users.Where(x => x.Names == name && x.Password == password)
                .FirstOrDefault() != null ? true : false;
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret = from user in _users
                      where user.Names == name && user.Password == password
                      select user.id;

            return ret != null ? true : false;
        }

        public User GetUser(string name, string password)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Името и паролата не могат да бъдат празни.");
            }

            var user = _users.FirstOrDefault(u => u.Name == name && u.Password == password);

            if (user == null)
            {
                throw new InvalidOperationException("Потребител с такова име и парола не беше намерен.");
            }

            return user;
        }
        public void AssignUserRole(string name, string password, UserRolesEnum role)
        {
            var user = GetUser(name, password);
            if (user != null)
            {
                user.Role = role;
            }
            else
            {
                throw new Exception($"User with name {name} not found.");
            }
        }

        public void SetActive(string name, string password, DateTime expires)
        {
            var user = GetUser(name, password);
            if (user != null)
            {
                user.IsActive = true;
                user.Expires = expires;
            }
            else
            {
                throw new Exception($"User with name {name} not found.");
            }
        }
        public void AddUser(User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Name == user.Name);
            if (existingUser != null)
            {
                throw new ArgumentException($"User with name {user.Name} already exists.");
            }

            _users.Add(user);
        }
    }
}