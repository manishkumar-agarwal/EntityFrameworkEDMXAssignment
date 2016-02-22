using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationusingEDMX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!! Welcome to the Telephone System");

            using(var telepehoneSystemDBContext = new TelephoneBillingSystemContext())
            {
                var listOfEmployees = telepehoneSystemDBContext.Employees.ToList();

                foreach(var employee in listOfEmployees)
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }
}
