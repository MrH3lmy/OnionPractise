using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Managment.Domain
{
    public  class LeaveType : BaseDomainEntity
    {
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }
        public LeaveType leaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public String   RequestComments { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

    }
}
