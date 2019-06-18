using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankSystemOperation
{
    [Synchronization]
    public class BankSystemSynch : ContextBoundObject
    {
        public int Money { get; set; }
        public object locks = new object();

        int i = 1;

        public void Add()
        {
           lock(locks)
           {
                while(Money<1000)
                {
                    Console.WriteLine($"({Thread.CurrentThread.ManagedThreadId})-поток начал {i} операцию, " +
                    $"Банк начал пополнять счет!!!!" + $"{Money}=>{Money += 200}");
                    i++;
                    Thread.Sleep(new Random().Next(2000, 2500));
                }
                
           }
            
        }
        public void Withdrow()
        {
            lock (locks)
            {
                while(Money>200)
                {
                    Console.WriteLine($"({Thread.CurrentThread.ManagedThreadId})-поток начал {i} операцию, " +
                    $"Банк начал снимать со счета!!!!" + $"{Money}=>{Money -= 200}");
                    i++;
                    Thread.Sleep(new Random().Next(2000, 2500));
                }
                
            }
        }
    }
}
