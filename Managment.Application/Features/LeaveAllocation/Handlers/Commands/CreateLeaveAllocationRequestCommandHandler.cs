using AutoMapper;
using Managment.Application.Features.LeaveAllocation.Requests.Commands;
using Managment.Application.Presistence.Contracts;
using Managment.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Features.LeaveAllocation.Handlers.Commands
{
    public class CreateLeaveAllocationRequestCommandHandler : IRequestHandler<CreateLeaveAllocationRequestCommand, int>
    {
        private readonly ILeaveAlloctionRepository _leaveAlloctionRepository;
        private readonly IMapper _mapper;

        public CreateLeaveAllocationRequestCommandHandler(ILeaveAlloctionRepository leaveAlloctionRepository , IMapper mapper)
        {
            _leaveAlloctionRepository = leaveAlloctionRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveAllocationRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = _mapper.Map<LeaveAlloction>(request.leaveAllocationDto);
            leaveAllocation = await _leaveAlloctionRepository.Add(leaveAllocation);

            return leaveAllocation.Id;
        }
    }
}
