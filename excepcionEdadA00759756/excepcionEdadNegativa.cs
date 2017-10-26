using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepcionEdadA00759756
{
    class excepcionEdadNegativa : Exception 
    {
        public excepcionEdadNegativa()
        {
            Console.WriteLine("Edad no valida"); 

        }

        public excepcionEdadNegativa(string mensaje):base(mensaje)
        {

        }
        public excepcionEdadNegativa(string mensaje, Exception innerE): base(mensaje, innerE)
        
        {

        }
    }
}
