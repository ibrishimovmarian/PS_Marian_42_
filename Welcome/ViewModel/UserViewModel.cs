using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user;

        public UserViewModel(User user)
        {
            _user = user;
        }   

        public string name 
        {
            get { return _user.Name; }
            set { _user.Name = value; } 
        }

        public string password 
        {
            get { return _user.Password; }
            set { _user.Password = value; } 
        }

        public UserRolesEnum roles 
        {
            get { return _user.Roles; } 
            set { _user.Roles = value; }    
        }
        public string FacultiNumber 
        {
            get { return _user.FacultiNumber; }
            set { _user.FacultiNumber = value; }
        }
        public string Email 
        {
            get { return _user.Email; }
            set { _user.Email = value; }   
        }
    }
}
