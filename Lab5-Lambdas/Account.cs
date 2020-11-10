using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab5_Lambdas
{
    class Account
    {
        public int id;
        public string name;
        public double balance;

        public string toString()
        {
            return "ID : " + this.id + " Name : " + this.name + " Balance : " + balance.ToString("C", CultureInfo.CurrentCulture);
        }
    }

    
}
