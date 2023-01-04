using AutoMapper;
using Managment.Application.DTOs.LeaveAllocation;
using Managment.Application.DTOs.LeaveRequest;
using Managment.Application.DTOs.LeaveType;
using Managment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequestDtos, LeaveRequest>().ReverseMap();
            CreateMap<LeaveAlloction, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();


        }
    }
}
