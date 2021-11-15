using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class AccountTest
    {
        public static void Main(string[] args)
        {
            Account account1 = new Account(50.00M);
            Account account2 = new Account(-7.53M);

            Console.WriteLine("Account balance:{0:c}", account1.Balance);
            Console.WriteLine("Account balance:{0:c}", account2.Balance);


            decimal depositAmount;

            Console.WriteLine("enter deposit amount for account1: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("adding {0:c} to account balance\n",depositAmount);
            account1.Credit(depositAmount);


            Console.WriteLine("account 1 balance is {0:c}",account1.Balance);
            Console.WriteLine("account 2 balance is {0:c}\n", account2.Balance);



            Console.WriteLine("ENter deposit amount for account2: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:c} to account 2 balance\n",depositAmount);
            account2.Credit(depositAmount);

            Console.WriteLine("Account balance:{0:c}", account1.Balance);
            Console.WriteLine("Account balance:{0:c}", account2.Balance);
            

        }

    }    
}
