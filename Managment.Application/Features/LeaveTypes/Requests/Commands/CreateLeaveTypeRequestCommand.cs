using Managment.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeRequestCommand : IRequest<int>
    {
        // One pattern is to write all the fields in the actual request 
        // Another pattern => 

        public LeaveTypeDto LeaveTypeDto { get; set; }
            
            }
}
