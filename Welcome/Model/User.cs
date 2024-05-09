using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Welcome.Others;
using System.Security.Cryptography;

namespace Welcome.Model
{
    public class User
    {
        private string name;
        private string password;
        private UserRolesEnum roles;
        private string facultiNumber;
        private string email;   

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public UserRolesEnum Roles
        {
            get { return roles; }
            set { roles = value; }
        }
        
        public string FacultiNumber 
        {
            get { return facultiNumber; }
            set { facultiNumber = value; }
        }
        public string Email 
        {
            get { return email; }
            set { email = value; }
        }
       public static string EncryptPassword(string password)
        {
            char[] encryptedChars = new char[password.Length];

            for (int i = 0; i < password.Length; i++)
            {
                encryptedChars[i] = (char)(password[i] + 1);
            }

            return new string(encryptedChars);
        }
    }
}
