using Managment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Presistence.Contracts
{
    public interface ILeaveAlloctionRepository : IGenericRepository<LeaveAlloction>
    {
        Task<LeaveAlloction> GetLeaveAllocationWithDetails(int id);
        Task<List<LeaveAlloction>> GetLeaveAllocationWithDetails();
    }
}
