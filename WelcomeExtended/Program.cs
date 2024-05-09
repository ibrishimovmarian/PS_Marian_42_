using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;

using WelcomeExtended.Helpers;

using WelcomeExtended.Data;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            UserData userData = new UserData();

            User studentUser = new User()
            {
                Name = "student",
                Password = "123",
                Role = UserRolesEnum.STUDENT
            };
            User student2User = new User()
            {
                Names = "Student2",
                Password = "123",
                Role = UserRolesEnum.STUDENT

            };
            User ProfessorUser = new User()
            {
                Names = "Professor",
                Password = "1234",
                Role = UserRolesEnum.PROFESSOR

            };
            User AdminUser = new User()
            {
                Names = "Admin",
                Password = "12345",
                Role = UserRolesEnum.ADMIN

            };


            userData.AddUser(studentUser);

            userData.AddUser(new User() { Name = "Student2", Password = "123", Role = UserRolesEnum.STUDENT });
            userData.AddUser(new User() { Name = "Teacher", Password = "1234", Role = UserRolesEnum.PROFESSOR });
            userData.AddUser(new User() { Name = "Admin", Password = "12345", Role = UserRolesEnum.ADMIN });

            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            bool isValid = UserHelper.ValidateCredentials(username, password);
            if (isValid)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Login failed: Invalid username or password.");
            }
        }
    }
}