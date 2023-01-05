using AutoMapper;
using Managment.Application.DTOs.LeaveAllocation;
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
    public class GetLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
    {
        private readonly ILeaveAlloctionRepository _alloctionRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationDetailRequestHandler(ILeaveAlloctionRepository alloctionRepository, IMapper mapper)
        {
            _alloctionRepository = alloctionRepository;
            _mapper = mapper;
        }
        public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _alloctionRepository.GetLeaveAllocationWithDetails(request.id);
            return _mapper.Map<LeaveAllocationDto>(leaveAllocation);
        }
    }
}
