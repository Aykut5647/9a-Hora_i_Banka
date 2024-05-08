using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            //MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            //MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMethod");
            //if (oldestMemberMethod == null || addMemberMethod == null)
            //{
            //    throw new Exception();
            //}
            Person person = new Person();

            Console.WriteLine("N=");
            int n= int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Kak se kazsas? ");
                    person.name = Console.ReadLine();
                Console.WriteLine("Na kolko godini si?");
                person.age=int.Parse(Console.ReadLine());

            }
            for(int i=0;i<n;i++)
            { Console.WriteLine(person.name); }
          

            account.ID = 1;
            Console.WriteLine("Kolko shte vkarvas? ");
            account.Deposit(30);
            Console.WriteLine("Kolko shte teglish? ");
            account.Withdraw(20);
            Console.WriteLine(account.ToString());


            
            //if (account.Withdraw > account.balance)
            //{
            //    Console.WriteLine("Ne ti dostigat 10");
            //}
            //if (account.Withdraw <= account.balance)
            //{
            //    Console.WriteLine("Ne ti dostigat 10");
            //}

        }
    }
}
