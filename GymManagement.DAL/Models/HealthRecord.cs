using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.DAL.Models
{
    public class HealthRecord
    {
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string? Note { get; set; }
        public string BloodType { get; set; }
       
        // Last Updated = UpdatedAt of Base Entity

    }
}