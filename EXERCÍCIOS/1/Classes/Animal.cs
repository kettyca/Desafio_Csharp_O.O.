using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Classes
{
    public class Animal
    {
        public string? animal;
        public string? raca { get; set; }
        public int tamanho { get; set; }

        public virtual void Apresentar(string animal, string raca, int tamanho) {
            Console.WriteLine("\t\t. . .");
            Console.WriteLine($"\t\t{animal}");            
            Console.WriteLine($"\t\tRaça: " + raca);
            Console.WriteLine($"\t\tTamanho: {tamanho}cm");
        }
        public virtual void EmitirSom() {
            Console.WriteLine("\t\tSom do animal\n");
        }

    }
}
