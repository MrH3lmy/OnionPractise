using AutoMapper;
using Managment.Application.Features.LeaveRequest.Requests.Commands;
using Managment.Application.Presistence.Contracts;
using Managment.Domain;
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
            if(request.leaveRequestDto != null)
            {
                var leaveRequest = await _leaveRequestRepository.Get(request.leaveRequestDto.Id);
                _mapper.Map(request.leaveRequestDto, leaveRequest);
                await _leaveRequestRepository.Update(leaveRequest);

            }
            else if(request.changeLeaveRequestApprovalDto != null)
            {
                var leaveRequest = await _leaveRequestRepository.Get(request.changeLeaveRequestApprovalDto.Id);
                await _leaveRequestRepository.ChangeApprovalStatus(leaveRequest , request.changeLeaveRequestApprovalDto.Approved);
            }
          


           
            return Unit.Value;
        }
    }
}
