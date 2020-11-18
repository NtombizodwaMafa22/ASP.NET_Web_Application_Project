using System;
using System.Collections.Generic;

#nullable disable

namespace Softlock_Solutions.Models
{
    public partial class LoginDatum
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Joblevel { get; set; }
        public string Role { get; set; }
    }
}
