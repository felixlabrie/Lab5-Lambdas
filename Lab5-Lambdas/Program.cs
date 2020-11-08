using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
           
            List<int> intList = new List<int> { 6, 5, 4, 3, 2, 1, 7, 10, 1 };

            // Q1 Members under five

            List<int> underFive = intList.Where(x => x < 5).ToList();

            // Q2 Lowest number

            int smallestNum = intList.Min();

            // Q3 Members lower than average of list

            List<int> lessAvg = intList.Where(y => y < intList.Average()).ToList();




            // Part 2

            Dictionary<int, string> indexedList = new Dictionary<int, string>(); indexedList.Add(1, "Green Division");
            indexedList.Add(2, "Yellow Division");
            indexedList.Add(3, "Blue Division");
            indexedList.Add(4, "Pink Division");
            indexedList.Add(5, "Dark Blue Division");

            // Q4 Records with blue



            // Q5 Records which color has more than 4 letters



            // Q6 Statement that converts to bank accounts where amount is 10,000x the ID






            // Part 3

            List<Account> accountList = new List<Account>();
            accountList.Add(new Account { id = 123, name = "Eastern Division", balance = 12332.33 });
            accountList.Add(new Account { id = 234, name = "Western Division", balance = 22333333.22 });
            accountList.Add(new Account { id = 345, name = "Northern Division", balance = 2184.34 });
            accountList.Add(new Account { id = 456, name = "Southern Division", balance = 999222.00 });
            accountList.Add(new Account { id = 567, name = "Champlain Wireless Division", balance = 00.01 });

            // Q7 Average of balances



            // Q8 Average value of balances where balance > 10,000



            // Q9 Bank account where balance > 10,000

        }

        
    }
    
}
