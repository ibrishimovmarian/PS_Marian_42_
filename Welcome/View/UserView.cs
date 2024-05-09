using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public void Display()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("User: " + _viewModel.name);
            Console.WriteLine("Role: " + _viewModel.roles);
            Console.WriteLine("Faculti Number: " + _viewModel.FacultiNumber);
            Console.WriteLine("Email: " + _viewModel.Email);
            Console.WriteLine("\n");
        }
        public void DisplayUser()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Welcome to the Detailed View");     
            Console.WriteLine("Here, you can see all the detailed information about the user.");
            Console.WriteLine($"User: {_viewModel.name}");
            Console.WriteLine($"Role: {_viewModel.roles.ToString()}");
            Console.WriteLine($"Faculty Number: {_viewModel.FacultiNumber}");
            Console.WriteLine($"Email: {_viewModel.Email}");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\n");
        }
    }
}
