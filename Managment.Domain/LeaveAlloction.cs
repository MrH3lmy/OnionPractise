using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Managment.Domain
{
    public class LeaveAlloction : BaseDomainEntity
    {
        [Display(Name = "Number Of Days")]

        public int NumberOfDays { get; set; }
        public int Period { get; set; }

        //public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }

        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

    }
}
