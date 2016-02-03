using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo08koulu
{
    class Program
    {
        static void Main(string[] args)
        {
            Noppa noppa = new Noppa();
            Console.Write("monta kertaa noppa lentää ");
            string kerta = Console.ReadLine();        
            int number;
            bool result = int.TryParse(kerta, out number);
            for (int i=1;i<= number; i++)
            {
            
                int luku = noppa.Heita(); //1-6
                Console.WriteLine("Luku on {0}", luku);
           
         
            }
            int average;
            average = (/ number);///TÄHÄN RATKAISU 
            Console.WriteLine("keskiarvo on {0}", average);

        }
    }
}
