using AutoMapper;
using Managment.Application.Features.LeaveTypes.Requests.Commands;
using Managment.Application.Presistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand,Unit>
    {
        private readonly ILeaveTypRepository _leaveTypRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(ILeaveTypRepository leaveTypRepository , IMapper mapper)
        {
            _leaveTypRepository = leaveTypRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType =  await _leaveTypRepository.Get(request.LeaveTypeDto.Id);
            _mapper.Map(request.LeaveTypeDto, leaveType);
            await _leaveTypRepository.Update(leaveType);
            return Unit.Value;
        }
    }
}
