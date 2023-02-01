using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Enums;
using AccountManagement.Contract.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagementApi.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class DemandPacketController : ControllerBase
    {
        private readonly IDemandPacketService _demandPacketService;

        public DemandPacketController(IDemandPacketService demandPacketService)
        {
            _demandPacketService = demandPacketService;
        }
        [HttpPost]
        [MapToApiVersion("1")]
        public async Task<ExecutDemandPacketStatus> ExecutDemandPacket([FromBody] ExecutDemandPacketRequest request)
        {
            var packet = await _demandPacketService.ExecutDemandPacket(request);
            return packet;
        }


    }
}
