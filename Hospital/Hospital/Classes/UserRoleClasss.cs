using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{
    public class UserRoleClasss
    {
        public const string AdminRole = "admin";
        public const string ReceptionistRole = "receptionist";

        public static bool IsAdmin(string role)
        {
            return string.Equals(role, AdminRole, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsReceptionist(string role)
        {
            return string.Equals(role, ReceptionistRole, StringComparison.OrdinalIgnoreCase);
        }


    }
}
