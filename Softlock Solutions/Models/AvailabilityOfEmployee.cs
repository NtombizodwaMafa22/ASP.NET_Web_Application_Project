using System;
using System.Collections.Generic;

#nullable disable

namespace Softlock_Solutions.Models
{
    public partial class AvailabilityOfEmployee
    {
        public int EmployeeNumber { get; set; }
        public string Attrition { get; set; }
        public string BusinessTravel { get; set; }
        public string DistanceFromHome { get; set; }
        public string EnvironmentSatisfaction { get; set; }
        public string Over18 { get; set; }
    }
}
