using System;
using System.Collections.Generic;

#nullable disable

namespace Softlock_Solutions.Models
{
    public partial class EmployeeWorkLife
    {
        public int EmployeeNumber { get; set; }
        public string OverTime { get; set; }
        public string TotalWorkingYears { get; set; }
        public string TrainingTimesLastYear { get; set; }
        public string WorkLifeBalance { get; set; }
        public string YearsAtCompany { get; set; }
        public string YearsInCurrentRole { get; set; }
        public string YearsSinceLastPromotion { get; set; }
        public string YearsWithCurrManager { get; set; }
    }
}
