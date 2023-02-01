using AccountManagement.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Interfaces.Services
{
    public interface ICustomerService
    {
        Task Add(AddCustomerRequest request);
        Task<GetCustomerInfoResponse> GetCustomerInfo(GetCustomerInfoRequest request);
        Task<GetCustomerByDemandPacketIdResponse> GetCustomersByDemandPacketId(GetCustomerByDemandPacketIdRequest request);
    }
}
