using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Classes
{
    public class Cachorro : Animal
    {
        public override void EmitirSom () {
            Console.WriteLine("\t\tSom que emite: Au Au Au\n");
        }
    }
}