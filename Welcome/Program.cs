using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{ 
    public class Prognram
    {
        public static object View1 { get; private set; }

        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Name = "Marian";
            user1.Password = "zxcvbnm";
            user1.Roles = Others.UserRolesEnum.STUDENT;
            user1.FacultiNumber = "121221123";
            user1.Email = "marian@abv.bg";

            User user2 = new User();
            user2.Name = "Joro";
            user2.Password = "123456789";
            user2.Roles = Others.UserRolesEnum.PROFESSOR;
            user2.Email = "joro_123@abv.bg";

            UserViewModel userViewModel1 = new UserViewModel(user1);
            UserViewModel userViewModel2 = new UserViewModel(user2);

            UserView view1 = new UserView(userViewModel1);
            UserView view2 = new UserView(userViewModel2);

            view1.Display();
            view2.Display();

            view1.DisplayUser();
            view2.DisplayUser();

            {
                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();

                string encryptedPassword = User.EncryptPassword(password);

                Console.WriteLine("Encrypt Password: " + encryptedPassword);
            }
        }

        private static string EncryptPassword(string? password)
        {
            throw new NotImplementedException();
        }
    }
}