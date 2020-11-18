using System;
using System.Collections.Generic;

#nullable disable

namespace Softlock_Solutions.Models
{
    public partial class Employee
    {
        public int EmployeeNumber { get; set; }
        public int Age { get; set; }
        public int DailyRate { get; set; }
        public string Department { get; set; }
        public string Education { get; set; }
        public string EducationField { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
    }
}
