using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp4grupo01
{
    class Program
    {
        static void Main(string[] args)
        {
           var teclado =  Console.ReadLine();
           switch (teclado)
           {
               case "parametros" :
                   Console.WriteLine("Executar CalcularBMI normal:"  + Parametrosnomeopc.CalcularBMI(80, 180).ToString());
                   Console.WriteLine("Executar CalcularBMI nome peso e altura:" + Parametrosnomeopc.CalcularBMI(peso:80, altura:180).ToString());
                   Console.WriteLine("Executar CalcularBMI nome altura e peso:" + Parametrosnomeopc.CalcularBMI(altura:180, peso:80).ToString());
                   //Fixo sem ser nomeados devem ser informados primeiro
                   Console.WriteLine("Executar CalcularBMI opcional:" + Parametrosnomeopc.CalcularBMI2().ToString());
                   break;
               case "dinamico":
                   try
                   {
                       Console.WriteLine("Carrega Dinamico gera erro tempo execucao:");
                       Dinamico.CarregaDinamico2(); 
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine(ex.Message);
                   }
                   Console.WriteLine("Carrega Dinamico nao gera erro tempo execucao:");
                   Dinamico.CarregaDinamico1();
                   Console.WriteLine("Carrega Estatico nao gera erro tempo execucao:");
                   Dinamico.CarregaEstatico2();
                   break; 
               case "covariancia":
                   try
                   {
                       Console.WriteLine("Carrega Covariancia1 gera erro tempo execucao:");
                       Covarianca.CarregarCovariancia1(); 
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine(ex.Message);
                   }
                   Console.WriteLine("Carrega Covariancia2 nao gera erro tempo execucao:");
                   Covarianca.CarregarCovariancia2();
                   Console.WriteLine("Carrega Covariancia3 nao gera erro tempo execucao:");
                   Covarianca.CarregarCovariancia3();
                   break;

           }

        }
    }
}
