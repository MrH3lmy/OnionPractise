using AutoMapper;
using Managment.Application.DTOs.LeaveRequest;
using Managment.Application.Features.LeaveRequest.Requests.Queries;
using Managment.Application.Features.LeaveTypes.Requests.Queries;
using Managment.Application.Presistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Features.LeaveRequest.Handlers.Queries
{
    public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDtos>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        
        public async Task<LeaveRequestDtos> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var LeaveRequest = await _leaveRequestRepository.Get(request.id);
            return _mapper.Map<LeaveRequestDtos>(LeaveRequest);
        }
    }
}
