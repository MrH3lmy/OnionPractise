using Managment.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Features.LeaveRequest.Requests.Commands
{
    public class UpdateLeaveRequestCommand  : IRequest<Unit>
    {
        public LeaveRequestDtos leaveRequestDto;
        public ChangeLeaveRequestApprovalDto changeLeaveRequestApprovalDto { get; set; }


    }
}
