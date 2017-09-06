using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._3_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjunto de alunos:
            ISet<string> alunos =
                new SortedSet<string>()
                {
                    "Vanessa Tonini",
                    "Ana Losnak",
                    "Rafael Nercessian",
                    "Priscila Stuani"
                };

            //adicionar: Rafael Rollo
            alunos.Add("Rafael Rollo");
            //adicionar: Fabio Gushiken
            alunos.Add("Fabio Gushiken");
            //adicionar: Fabio Gushiken
            alunos.Add("Fabio Gushiken");
            //adicionar: FABIO GUSHIKEN
            alunos.Add("FABIO GUSHIKEN");

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            ///este conjunto é subconjunto do outro? IsSubsetOf


            ///este conjunto é superconjunto do outro? IsSupersetOf

            ///os conjuntos contêm os mesmos elementos? SetEquals

            ///subtrai os elementos da outra coleção que também estão neste conjunto - ExceptWith

            ///intersecção dos conjuntos - IntersectWith

            ///somente em um ou outro conjunto - SymmetricExceptWith

            ///união de conjuntos - UnionWith

        }
    }
}
