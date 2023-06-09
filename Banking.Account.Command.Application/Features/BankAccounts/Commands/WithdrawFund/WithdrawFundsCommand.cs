﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Account.Command.Application.Features.BankAccounts.Commands.WithdrawFund
{
    public class WithdrawFundsCommand : IRequest<bool>
    {
        public string Id { get; set; } = string.Empty;
        public double Amount { get; set; }
    }
}
