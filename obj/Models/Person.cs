using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace AMST4_Heranca.obj.Models
{
    public class Person
    {
            public Person()
        {
            Id = Guid.NewGuid();
            Name = "Estevão Gabriel Feitosa Brito";
            Account = CPF;
            CPF = 0987654321;
            Agency = "Nubank";
            Desposit = 7000;
            Withdraw = 700;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CPF { get; set; }
        public string Agency { get; set; }
        public string Account { get; set; }
        public double Withdraw { get; set;}
        public double Deposit { get; set; }
        public double VBalance { get; set;}
    }

    public virtual void Balance()
    {
        VBalance = Deposit - Withdraw;
    }
}