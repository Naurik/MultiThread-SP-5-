using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankSystemOperation
{
    public class Bank
    {
        public int Money { get; set; }

        int i = 1;
        public void Add()
        {
            while(Money<1000)
            {
                Console.WriteLine($"({Thread.CurrentThread.ManagedThreadId})-поток начал {i} операцию, " +
                $"Банк начал пополнять счет!!!!" + $"{Money}=>{Money += 200}");
                i++;
                Thread.Sleep(200);
            }
        }
        public void Withdrow()
        {
         while(Money>200)
            {
                Console.WriteLine($"({Thread.CurrentThread.ManagedThreadId})-поток начал {i} операцию, " +
            $"Банк начал снимать со счета!!!!" + $"{Money}=>{Money -= 200}");
                i++;
                Thread.Sleep(200);
            }
        }
    }
}
