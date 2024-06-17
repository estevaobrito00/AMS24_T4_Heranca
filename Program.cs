using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Person person = new Person();
        
        Console.WriteLine("Digite se a conta é Pessoal ou Juridica");
        string selecao = Console.ReadLine();

        if (selecao == "Pessoal"|| selecao == "pessoal")
        { 
           AccountPerson accountPerson = new AccountPerson();
           Console.WriteLine($"Id: {accountPerson.Id}"); 
           Console.WriteLine($"Seu nome é: {accountPerson.AccountName}"); 
           Console.WriteLine($"O numero da sua conta é: {accountPerson.Account}"); 
           Console.WriteLine($"Seu Agência é: {accountPerson.AccountAgency}"); 
           accountPerson.Balance();
        }
        else if(selecao == "Juridica" || selecao == "juridica")
        {
           BusingssPerson bussingssperson = new BusingssPerson();
           Console.WriteLine($"Id: {bussingssperson.Id}"); 
           Console.WriteLine($"Seu nome é: {bussingssperson.Name}"); 
           Console.WriteLine($"O numero da sua conta é: {bussingssperson.BusingssCNPJ}"); 
           Console.WriteLine($"Seu Agência é: {bussingssperson.Agency}"); 
           bussingssperson.Balance();
        }

    }

}