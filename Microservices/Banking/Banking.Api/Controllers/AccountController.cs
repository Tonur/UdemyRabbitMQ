using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Application.Interfaces;
using Banking.Application.Models;
using Banking.Domain.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Api.Controllers
{
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccounts()
        {
            try
            {
                var accounts = await _accountService.GetAccounts();
                return Ok(accounts);
            }
            catch (Exception e)
            {
                return StatusCode(503, e.Message);
            }
        }

        [HttpPost("Transfer")]
        public async Task<ActionResult<IEnumerable<Account>>> Transfer([FromBody] AccountTransfer accountTransfer)
        {
            try
            {
                var accounts = await _accountService.Transfer(accountTransfer);
                return Ok(accounts);
            }
            catch (Exception e)
            {
                return StatusCode(503, e.Message);
            }
        }
    }
}
