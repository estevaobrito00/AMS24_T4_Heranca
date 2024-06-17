using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace AMST4_Heranca.obj.Models
{
    public class AccountPerson : Person
    {
        public AccountPerson()
        {
            AccountName = Name;
            AccountCPF = CPF;
            AccountAgency = Agency;
        }

    public string AccountName { get; set; }
    public int AccountCPF { get; set;}
    public string AccountAgency { get; set;}

    public override void Balance()
    {
        VBalance = (Deposit - Withdraw)*1.03;
        Console.WriteLine("O seu saldo atual é:" + VBalance);
    }
    }
}