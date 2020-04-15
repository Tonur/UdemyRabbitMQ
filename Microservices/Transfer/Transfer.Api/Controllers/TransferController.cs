using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Transfer.Application.Interfaces;
using Transfer.Domain.Models;

namespace Transfer.Api.Controllers
{
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet("History")]
        public async Task<ActionResult<IEnumerable<TransferLog>>> GetAccounts()
        {
            try
            {
                var accounts = await _transferService.GetTransferLogs();
                return Ok(accounts);
            }
            catch (Exception e)
            {
                return StatusCode(503, e.Message);
            }
        }
    }
}
