using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    internal class Person
    {
        private int age;
        private string name;
        private int accounts;
        public int Age 
        { 
            get { return this.age; } 
            set { this.age = value; } 
        }
        public string Name 
        {
            get { return this.name; }
            set { this.name = value; } 
        }
        public int Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value; }
        }
        public Person(string name,int age)
        {
            this.age = 15;
            this.name = "Aykut";
            this.Accounts = 1;
        }
        public Person(string name,int age,List<BankAccount> accounts)
        {
            this.age = 16;
            this.name = "Georgiev";
            this.accounts = 2;
        }
        public double GetBalance()
        {
            return this.accounts (this.age),(this.name);
        }
    }
}
