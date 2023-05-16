using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace LibraryGroup13
{
    public class AppUser : IdentityUser
    {
        //You do not need to keep track of the AppUserID since it inherts from the IdentityUser Class
        //You also do not need email, phone, password. You only need to have it within the constructor

       // public string AppUserID { get; set; }
        public string Fullname { get; set; }
        //public string Email { get; set; }
        //public string Phone { get; set; }
        //public string Password { get; set; }

        //In your constructor you also need to have username which is equal to email. Your email also needs to be this.Email
        public AppUser(string fullname, string email, string phone, string password)
        {
            this.Fullname = fullname;
            this.UserName = email;
            this.PhoneNumber = phone;
            PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();
            this.PasswordHash = hasher.HashPassword(this, password);
        }

        public AppUser()
        {

        }

        
    }
}