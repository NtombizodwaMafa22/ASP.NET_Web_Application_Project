using System;
using System.Collections.Generic;

#nullable disable

namespace Softlock_Solutions.Models
{
    public partial class CurrentJobInformation
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeCount { get; set; }
        public int HourlyRate { get; set; }
        public string JobInvolvement { get; set; }
        public string JobLevel { get; set; }
        public string JobRole { get; set; }
        public string JobSatisfaction { get; set; }
    }
}
