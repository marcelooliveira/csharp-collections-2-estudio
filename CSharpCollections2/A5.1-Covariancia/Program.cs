using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5._1_Covariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazendo cast de string para objeto");
            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);
            Console.WriteLine();
            ///<image url="$(ProjectDir)\Slides\img1.png" scale=""/>

            Console.WriteLine("Então podemos fazer cast de List<string> para List<object>?");
            List<string> meses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            //List<object> listaObj = meses; // essa linha não compila!
            Console.WriteLine();

            Console.WriteLine("Agora trabalhando com arrays");
            var mesesArray = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            object meuObjeto = mesesArray;
            Console.WriteLine(meuObjeto);
            Console.WriteLine();
            ///<image url="$(ProjectDir)\Slides\img2.png" scale=""/>


            Console.WriteLine("Podemos fazer cast de string[] para object[]?");
            ///<image url="$(ProjectDir)\Slides\img3.png" scale=""/>

            object[] objArray = mesesArray;
            Console.WriteLine(objArray);
            foreach (var item in objArray)
            {
                Console.WriteLine(item);
            }
            //MAS ATENÇÃO! objArray que recebeu cast de string[]
            //  não pode receber um int!
            //objArray[0] = 123;
            //Console.WriteLine(objArray[0]);
            Console.WriteLine();

            // mas cast de List<string> para IEnumerable<object> funciona...
            IEnumerable<object> enumObj = meses;
            Console.WriteLine(enumObj);
            Console.WriteLine();
            foreach (var item in enumObj)
            {
                Console.WriteLine(item);
            }
        }
    }
}
