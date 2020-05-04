using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanel.Shared.DTOs
{
    public class TransferDTO
    {
        public int From { get; set; }
        public int To { get; set; }
        public decimal Amount { get; set; }
    }
}
