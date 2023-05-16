using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryGroup13
{
    public class Admin : AppUser
    {
        
       public Admin(string fullname, string email, string phone, string password) : base(fullname, email, phone, password)
        {

        }

        public Admin()
        {

        }
        
        //Why is location here? You do not need to have this here  Done


        //Why is CreateTourTime here? You do not need to have this here Done

    }
}
