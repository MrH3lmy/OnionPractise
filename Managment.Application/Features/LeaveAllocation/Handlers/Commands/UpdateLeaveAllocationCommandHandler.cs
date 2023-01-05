using AutoMapper;
using Managment.Application.Features.LeaveAllocation.Requests.Commands;
using Managment.Application.Features.LeaveTypes.Requests.Commands;
using Managment.Application.Presistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Features.LeaveAllocation.Handlers.Commands
{
    public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
    {
        private readonly ILeaveAlloctionRepository _leaveAlloctionRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveAllocationCommandHandler(ILeaveAlloctionRepository leaveAlloctionRepository , IMapper mapper)
        {
            _leaveAlloctionRepository = leaveAlloctionRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAlloction = await _leaveAlloctionRepository.Get(request.leaveAllocationDto.Id);
            _mapper.Map(request.leaveAllocationDto, leaveAlloction);
            await _leaveAlloctionRepository.Update(leaveAlloction);
            return Unit.Value;
        }
    }
}
