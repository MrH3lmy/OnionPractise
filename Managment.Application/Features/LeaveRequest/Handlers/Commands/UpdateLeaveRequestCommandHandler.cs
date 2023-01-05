using AutoMapper;
using Managment.Application.Features.LeaveRequest.Requests.Commands;
using Managment.Application.Presistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Features.LeaveRequest.Handlers.Commands
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository , IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveRequestRepository.Get(request.leaveRequestDto.Id);
            _mapper.Map(request.leaveRequestDto, leaveType);
            await _leaveRequestRepository.Update(leaveType);
            return Unit.Value;
        }
    }
}
