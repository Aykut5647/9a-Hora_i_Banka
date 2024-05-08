using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hora
{
    internal class Person
    {
        public int age;
        public string name;
        public string grad;
        private int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        { get { return name; } 
          set {  name = value; } 
        }
        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }
    }
}
