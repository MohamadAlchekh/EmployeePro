using EmployeePro.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePro.Code.Models
{
    internal static class LocalUser
    {
        public static int id { get; set; }
        public static string FullName { get; set; }

        public static string UserName { get; set; }

        public static string Password { get; set; }

        public static string Role { get; set; }

        public static bool IsSecondaryUser { get; set; }

        public static string UserId { get; set; }

        public static string Phone { get; set; }

        public static string Email { get; set; }

        public static string? Address { get; set; }

        public static DateTime CreatedDate { get; set; }

        public static DateTime ModifiedDate { get; set; }


        // Navigation

        public static List<Roles> Roles { get; set; }

        public static List<SystemRecords> SystemRecords { get; set; }


    }
}

