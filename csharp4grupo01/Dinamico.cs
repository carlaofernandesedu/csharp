using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp4grupo01
{
    public class Dinamico
    {
        public static void CarregaDinamico1()
        {
            dynamic d1 = 1;
            dynamic compute = 4 - d1;
            Console.WriteLine(compute);
            Console.WriteLine(compute.GetType());  
        }

        public static void CarregaDinamico2()
        {
            dynamic d1 = "1";
            dynamic compute = 4 - d1;
            Console.WriteLine(compute);
            
        
        }

        public static void CarregaEstatico1()
        {
            //JA GEROU ERRO EM TEMPO DE COMPILACAO ELE CHECA O TIPO
            /*
            var e1 = "1";
            dynamic compute = 4 - e1;
            Console.WriteLine(compute);  
             */
        }

        public static void CarregaEstatico2()
        {
            // nao deixa implicito var e1;
            var e1 = 1;
            var  compute = 4 - e1;
            Console.WriteLine(compute);
            Console.WriteLine(compute.GetType());
        }
    }
}
