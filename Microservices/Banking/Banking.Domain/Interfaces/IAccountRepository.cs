using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Banking.Domain.Models;

namespace Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAccounts();
        Task<IEnumerable<Account>> Transfer(int requestFrom, int requestTo, decimal requestAmount);
    }
}
