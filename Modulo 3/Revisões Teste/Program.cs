using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Revisões_Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Asteriscos3();
            Asteriscos5();
            Asteriscos7();
            Asteriscos5();
            Asteriscos3();
            Console.ReadKey();
        }

        
        static void Asteriscos3()
        {

            Console.WriteLine("***");
        }
        static void Asteriscos5()
        {
            Console.WriteLine("*****");
        }
        static void Asteriscos7()
        {
           
          Console.WriteLine("*******");
        }
       

    }     

    
}


