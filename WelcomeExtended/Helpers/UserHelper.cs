using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static string ToString(this User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "The user cannot be null.");
            }
            return $"User: {user.Name}, Role: {user.Role}, Active Until: {user.Expires}";
        }
        public static bool ValidateCredentials(string name, string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("The name field cannot be empty", nameof(name));
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("The password field cannot be empty", nameof(password));
            }

            return _users.Any(u => u.Name == name && u.Password == password);
        }
        public static User GetUser(string name, string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("The name field cannot be empty", nameof(name));
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("The password field cannot be empty", nameof(password));
            }

            return _users.FirstOrDefault(u => u.Name == name && u.Password == password);
        }
        private static List<User> _users = new List<User>();
    }
}