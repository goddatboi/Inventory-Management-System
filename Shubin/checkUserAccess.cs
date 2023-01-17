using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubin
{
    public class checkUserAccess
    {
        public string Login { get; set; }

        public bool IsAdmin { get; }

        public string Status => IsAdmin ? "Администратор" : "Пользователь";

        public checkUserAccess(string login, bool isAdmin) 
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}
