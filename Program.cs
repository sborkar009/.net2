using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazon
{
    class Program
    {
        static void Main(string[] args)
        {
            sbi bank = new sbi()
            {
                userid = "sborkar009",
                enter_amount = 2000

            };
            Console.WriteLine(bank.userid);
            Console.WriteLine(bank.enter_amount);
            Console.ReadKey();
        }
        public class sbi
        {
            public string userid { get; set; }
            private string password { get; set; }

            public int enter_amount { get; set; }
            
        }
    }   
}   
