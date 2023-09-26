using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutorisationExample
{
    enum Roles
    {
        Administrator,
        User,
        Master
    }
    internal class User
    {
        private string name;
        private int password;
        private Roles role;
        private string status;
        private string gender;
        private string position;
        public string Name { get { return name; } }
        public int Password { get { return password; } }
        public Roles Role { get { return role; } set { role = value; } }
        public string Status { get { return status; } }
        public string Gender { get { return gender; } }
        public string Position { get { return position; } }

        public User(string name, int password,string status, string gender, string position, Roles role = Roles.User)
        {
            this.name = name;
            this.password = password;
            this.role = role;
            this.status = status;
            this.gender = gender;
            this.position = position;
        }
        
    }
}
