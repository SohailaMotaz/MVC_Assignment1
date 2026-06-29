using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.DAL.Models
{
    public class Member: GymUser
    {
        public string? Photo {get;set;}
        // Join Date = Created At of Base Entity
    }
}