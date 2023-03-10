using AutoMapper;
using Managment.Application.Features.LeaveTypes.Requests.Commands;
using Managment.Application.Presistence.Contracts;
using Managment.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeRequestCommandHandler : IRequestHandler<CreateLeaveTypeRequestCommand, int>
    {
        private readonly ILeaveTypRepository _leaveTypRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeRequestCommandHandler(ILeaveTypRepository leaveTypRepository,IMapper mapper)
        {
            _leaveTypRepository = leaveTypRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveTypeRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);
            leaveType = await _leaveTypRepository.Add(leaveType);

            return leaveType.Id;

        }
    }
}
