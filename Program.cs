using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string put = "C:/Users/Public";
                       
            string [] ktl= Directory.GetDirectories(put);
            
            foreach (string k in ktl)
            {
                Console.WriteLine("============Каталоги==========");

                Console.WriteLine("{0}",k);

                Console.WriteLine("*******Подкаталоги********");


                foreach ( string kp in Directory.GetDirectories(k))

                    Console.WriteLine("{0}",kp);
                Console.WriteLine();



            }


            Console.ReadKey();

        }
                  

           
         
        
    } 
}
