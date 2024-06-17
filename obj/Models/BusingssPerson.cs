using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace AMST4_Heranca.obj.Models
{
    public class BusingssPerson : Person
    {
         public BusingssPerson()
        {
            BusingssName = Name;
            BusingssCNPJ = Account;
            BusingssAgency = Agency;
        }

    public string BusingssName { get; set; }
    public int BusingssCNPJ { get; set;}
    public double BusingssAgency { get; set; }
    public double SpecialRate { get; set; }

    public override void Balance()
    {
        VBalance = (Deposit - Withdrawn)*0.9;
        Console.WriteLine("O seu saldo atual é:" + VBalance);
    }
    }
}