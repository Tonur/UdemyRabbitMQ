using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Application.Models;
using Banking.Domain.Models;

namespace Banking.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccounts();
        Task<IEnumerable<Account>> Transfer(AccountTransfer accountTransfer);
    }
}
