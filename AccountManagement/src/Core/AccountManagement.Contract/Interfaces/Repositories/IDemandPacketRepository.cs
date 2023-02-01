using AccountManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Interfaces.Repositories
{
    public interface IDemandPacketRepository
    {
        Task<DemandPacket> FindById(Guid id);
        Task<Guid> InsertAsync(DemandPacket demandpacket);
        void SetDemandPacketStatus(DemandPacket demandPacket);
    }
}
