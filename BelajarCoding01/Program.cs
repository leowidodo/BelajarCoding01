using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarCoding01
{
    class Program
    {
        static void Main(string[] args)
        {

            var acc = new AccountPayable();
            acc.AddPays(new employee());
            acc.AddPays(new Contractor());
            acc.Pays();
            Console.ReadKey();
        }

        class AccountPayable
        {
            private IList<Worker> workers = new List<Worker>();

            internal void AddPays(Worker worker)
            {
                workers.Add(worker);
            }

            internal void Pays()
            {
                foreach (var work in workers)
                {
                    work.PaySalary();
                }
            }
        }

        abstract class Worker
        {
            protected abstract string AcceptPayment();
            internal void PaySalary()
            {
                Console.WriteLine($"{AcceptPayment()}");
            }
        }

        class employee : Worker
        {
            protected override string AcceptPayment()
            {
                return "Employee";
            }
        }
        class Contractor : Worker
        {
            protected override string AcceptPayment()
            {
                return "Contractor";
            }
        }

    }
}
