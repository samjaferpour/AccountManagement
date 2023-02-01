using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Domain.Entities;
using AccountManagement.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Persistence.Implimentation.Repositories
{
    public class DemandPacketRepository : IDemandPacketRepository
    {
        private readonly AccountManagementDbContext _dbcontext;

        public DemandPacketRepository(AccountManagementDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<DemandPacket> FindById(Guid id)
        {
            var demandpacket = await _dbcontext.DemandPackets
                           .FirstOrDefaultAsync(p => p.Id == id);
            return demandpacket;
        }
        public async Task<Guid> InsertAsync(DemandPacket demandpacket)
        {
            await _dbcontext.DemandPackets.AddAsync(demandpacket);
            return demandpacket.Id;
        }
        public void SetDemandPacketStatus(DemandPacket demandPacket)
        {
            _dbcontext.DemandPackets.Update(demandPacket);
        }
        public async Task<int> GetCountOfDemands(Guid letterId)
        {
            var demands = await _dbcontext.DemandPackets.Where(p => p.LetterId == letterId)
                 .CountAsync();
            return demands;
        }
    }
}
