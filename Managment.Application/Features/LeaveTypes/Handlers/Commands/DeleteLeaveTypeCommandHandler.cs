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
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand>
    {
        private readonly ILeaveTypRepository _leaveTypRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveTypeCommandHandler(ILeaveTypRepository leaveTypRepository , IMapper mapper)
        {
            _leaveTypRepository = leaveTypRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypRepository.Get(request.Id);
            await _leaveTypRepository.Delete(leaveType);
            return Unit.Value;
        }
    }
}
