using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp4grupo01
{
    public class Covarianca
    {
        //1 Caso que gera erro em tempo de execução -> do mais generico para o derivado
        //Compila porem em tempo de execucao nao consegue lidar com os tipos string e objetos ao mesmo tempo
        public static void CarregarCovariancia1()
        {
            object[] arrObjetos = new string[] { "0", "1" };
            arrObjetos[0] = "linha 0";
            arrObjetos[1] = new object();
        }

        //2 Caso que nao gera erro em tempo de execução -> do mais generico para o derivado
        //Compila porem em tempo de execucao sempre tipo mais generico
        public static void CarregarCovariancia2()
        {
            object[] arrObjetos = new object[2];
            arrObjetos[0] = "linha 0";
            arrObjetos[1] = new object();
            foreach (var item in arrObjetos)
            {
                Console.WriteLine(item);
            }
        }

        // Caso que nao gera erro em tempo de execução -> do mais generico para o derivado
        //Compila porem em tempo de execucao são do mesmo tipo 
        public static void CarregarCovariancia3()
        {
            IEnumerable<string> itens = new List<string>() {"1","2","3"};
            PercorreObjetos(itens); 
        }

        public static void PercorreObjetos( IEnumerable<object> lista) 
        {
            foreach( object item in lista) 
            {
                Console.WriteLine(item); 
            }
        }

    }
}
