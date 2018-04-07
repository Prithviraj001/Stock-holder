using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Simulator
{
    public class User
    {
        private string FirstName, LastName;

        public User()
        {

        }

        public User(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
