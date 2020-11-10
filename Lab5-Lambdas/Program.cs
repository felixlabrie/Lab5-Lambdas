using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

            Console.WriteLine("Q1 Members of the list under five: ");

            underFive.ForEach(Console.WriteLine);

            Console.WriteLine("______________________\n");

            // Q2 Lowest number

            Console.WriteLine("Q2 Lowest number: ");

            int smallestNum = intList.Min();

            Console.WriteLine(smallestNum);

            Console.WriteLine("______________________\n");

            // Q3 Members lower than average of list

            Console.WriteLine("Q3 Members lower than the average of the list: ");

            List<int> lessAvg = intList.Where(y => y < intList.Average()).ToList();

            lessAvg.ForEach(Console.WriteLine);

            Console.WriteLine("______________________\n");

            // Part 2

            Dictionary<int, string> indexedList = new Dictionary<int, string>(); 
            indexedList.Add(1, "Green Division");
            indexedList.Add(2, "Yellow Division");
            indexedList.Add(3, "Blue Division");
            indexedList.Add(4, "Pink Division");
            indexedList.Add(5, "Dark Blue Division");

            // Q4 Records with blue

            Console.WriteLine("Q4 Records with the word blue: ");

            var recBlue = indexedList.Where(x => x.Value.Contains("Blue")).ToList();

            foreach(var n in recBlue)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("______________________\n");

            // Q5 Records which color has more than 4 letters

            Console.WriteLine("Q5 Colors with more than 4 letters: ");

            var moreThan4 = indexedList.Where(y => y.Value.TrimEnd("Division".ToCharArray()).Length > 5);

            foreach(var t in moreThan4)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("______________________\n");

            // Q6 Statement that converts to bank accounts where amount is 10,000x the ID

            Console.WriteLine("Q6 Convert to bank accounts with ID x 10,000 = balance: ");

            var accounts = indexedList.Select(x => new Account() { id = x.Key, name = x.Value, balance = x.Key * 10000 }).ToList();

            foreach(var s in accounts)
            {
                Console.WriteLine(s.toString());
            }

            Console.WriteLine("______________________\n");

            // Part 3

            List<Account> accountList = new List<Account>();
            accountList.Add(new Account { id = 123, name = "Eastern Division", balance = 12332.33 });
            accountList.Add(new Account { id = 234, name = "Western Division", balance = 22333333.22 });
            accountList.Add(new Account { id = 345, name = "Northern Division", balance = 2184.34 });
            accountList.Add(new Account { id = 456, name = "Southern Division", balance = 999222.00 });
            accountList.Add(new Account { id = 567, name = "Champlain Wireless Division", balance = 00.01 });

            // Q7 Average of balances

            Console.WriteLine("Q7 Average of the balances: ");

            var averageAcc = accountList.Select(x => x.balance).Average();

            Console.WriteLine("The average is " + averageAcc.ToString("C", CultureInfo.CurrentCulture));

            Console.WriteLine("______________________\n");

            // Q8 Average value of balances where balance > 10,000

            Console.WriteLine("Q8 Average balance of accounts with balance over 10,000: ");

            List<Account> filtList = accountList.Where(x => x.balance > 10000).ToList();
            var averageAccFilt = filtList.Select(x => x.balance).Average();

            Console.WriteLine("The average balance for the accounts with over $10,000 is : " + averageAccFilt.ToString("C", CultureInfo.CurrentCulture));

            Console.WriteLine("______________________\n");

            // Q9 Bank account where balance > 10,000

            Console.WriteLine("Q9 Accounts with a balance of over $10,000: ");

            foreach(var f in filtList)
            {
                Console.WriteLine(f.toString());
            }

            Console.WriteLine("______________________\n");

        }

        
    }
    
}
