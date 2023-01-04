using Managment.Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Features.LeaveAllocation.Requests.Queries
{
    public  class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {
    }
}
