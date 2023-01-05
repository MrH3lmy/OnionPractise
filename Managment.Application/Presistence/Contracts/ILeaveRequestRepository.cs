using Managment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Presistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {

        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestWithDetails();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus);

    }
}
