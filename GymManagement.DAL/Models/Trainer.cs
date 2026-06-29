using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManagement.DAL.Models.Enums;

namespace GymManagement.DAL.Models
{
    public class Trainer : GymUser
    {
        //Hire Date is CreatedAt of Base Entity
        public Specialty Specialty { get; set; }
    }
}