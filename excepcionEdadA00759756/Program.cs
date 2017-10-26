using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepcionEdadA00759756
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Edad:");
            int edad = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                if (edad < 0)
                {
                    throw new excepcionEdadNegativa();
                }
            }
            catch (excepcionEdadNegativa)
            {
                
            }

          

            


        }
    }
}
