using Managment.Application.DTOs.Common;
using Managment.Application.DTOs.LeaveType;
using Managment.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Managment.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDtos : BaseDto
    {

        [Display(Name = "Start Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        [Display(Name = "Date Requested")]
        public DateTime DateRequested { get; set; }
        [Display(Name = "Date Actioned")]
        public DateTime DateActioned { get; set; }
        [Display(Name = "Approval State")]
        public bool? Approved { get; set; }
        [Display(Name = "Approver Name")]
        public string ApprovedById { get; set; }
        public bool Cancelled { get; set; }
        [Display(Name = "Employee Comments")]
        [MaxLength(300)]
        public string RequestComments { get; set; }

    }
}
