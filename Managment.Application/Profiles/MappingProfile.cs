using AutoMapper;
using Managment.Application.DTOs;
using Managment.Application.DTOs.LeaveRequest;
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
