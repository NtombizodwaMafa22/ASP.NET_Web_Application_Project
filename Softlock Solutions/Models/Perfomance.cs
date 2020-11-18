using System;
using System.Collections.Generic;

#nullable disable

namespace Softlock_Solutions.Models
{
    public partial class Perfomance
    {
        public int EmployeeNumber { get; set; }
        public int MonthlyIncome { get; set; }
        public int MonthlyRate { get; set; }
        public string NumCompaniesWorked { get; set; }
        public int PercentSalaryHike { get; set; }
        public int PerformanceRating { get; set; }
        public string RelationshipSatisfaction { get; set; }
        public int StandardHours { get; set; }
    }
}
