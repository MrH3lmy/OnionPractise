using AutoMapper;
using Managment.Application.DTOs;
using Managment.Application.Features.LeaveTypes.Requests.Queries;
using Managment.Application.Presistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<List<LeaveAllocationDto>>
    {
        public int id { get; set; }
    }
}
