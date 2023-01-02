﻿using AutoMapper;
using Managment.Application.DTOs;
using Managment.Application.Features.LeaveAllocation.Requests.Queries;
using Managment.Application.Presistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Features.LeaveAllocation.Handlers.Queries
{
    public class GetLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, List<LeaveAllocationDto>>
    {
        private readonly ILeaveAlloctionRepository _alloctionRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationDetailRequestHandler(ILeaveAlloctionRepository alloctionRepository, IMapper mapper)
        {
            _alloctionRepository = alloctionRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _alloctionRepository.Get(request.id);
            return _mapper.Map<List<LeaveAllocationDto>>(leaveAllocation);
        }
    }
}