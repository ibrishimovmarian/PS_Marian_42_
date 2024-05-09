
using DataLayer.Database;
using DataLayer.Model;
using Microsoft.Extensions.Logging;
using Welcome.Others;

namespace DataLayer
{
    public class Program
    {
        static void Main(string[] args)
        {/*
                using (var context = new DatabaseContext())
                {
                    context.Database.EnsureCreated();
                    context.Add<DatabaseUser>(new DatabaseUser()
                    {
                        Name = "user",
                        Password = "1234",
                        Expires = DateTime.Now,
                        Role = UserRolesEnum.STUDENT,
                        Email = "email",
                        IsActive = true

                    });
                    context.SaveChanges();
                    var users = context.Users.ToList();

                    Console.Write("Enter username: ");
                    string enteredName = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string enteredPassword = Console.ReadLine();

                    bool isValidUser = users.Any(u => u.Name == enteredName);


                    if (isValidUser)
                    {
                        Console.WriteLine("Valid User!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid user!");
                    }
                    Console.ReadKey();
                }

            }*/

            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();

                context.Add(new DatabaseUser()
                {
                    Name = "user",
                    Password = "password",
                    Expires = DateTime.Now,
                    FacultiNumber = "123450",
                    Role = UserRolesEnum.STUDENT,
                    Email = "email"
                });

                context.SaveChanges();

                var users = context.Users.ToList();

                foreach (var user in users)
                {
                    Console.WriteLine($"Name: {user.Name}, Role: {user.Role}, Expires: {user.Expires}, FacultiNumber:{user.FacultiNumber}");
                }

                Console.ReadKey();
            }
        }
    }
}
