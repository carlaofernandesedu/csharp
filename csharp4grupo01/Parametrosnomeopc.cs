using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp4grupo01
{
    public class Parametrosnomeopc
    {
        public static int CalcularBMI(int peso, int altura)
        {
            return (peso * 703) / altura * altura; 
        }

        public static int CalcularBMI2(int peso =1 , int altura = 1)
        {
            return (peso * 703) / altura * altura; 
        }

        
    }
}
