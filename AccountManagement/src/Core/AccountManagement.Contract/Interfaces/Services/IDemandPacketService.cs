using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Enums;
using AccountManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Interfaces.Services
{
    public interface IDemandPacketService
    {
        Task<DemandPacket> FindById(Guid id);
        Task<ExecutDemandPacketStatus> ExecutDemandPacket(ExecutDemandPacketRequest request);
        Task SetDemandPacketStatus(SetDemandPacketStatusRequest request);
    }
}
