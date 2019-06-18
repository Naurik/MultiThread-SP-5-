using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankSystemOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankSynch = new BankSystemSynch();
            var bank = new Bank();
            bank.Money = 600;
            var threads = new Thread[4];

            int j = 0;
            while (j != 4)
            {
                threads[j] = new Thread(bank.Add);
                j++;
                threads[j] = new Thread(bank.Withdrow);
                j++;
            }

            foreach (var thread in threads)
            {
                thread.Start();
            }


            bankSynch.Money = 600;


            //Console.WriteLine("---------------------------------------");
            //for (int i = 0; i < threads.Length; i++)
            //{
            //    threads[i] = new Thread(bankSynch.Add);
            //}


            //for (int i = 0; i < threads.Length; i++)
            //{
            //    threads[i] = new Thread(bankSynch.Withdrow);
            //}

            //foreach (var thread in threads)
            //{
            //    thread.Start();
            //}
            Console.ReadLine();
        }
    }
}
