using _1.Classes;

Animal animal1 = new Gato();
Animal animal2 = new Cachorro();
Animal animal3 = new Passaro();

Console.WriteLine("\n\n\t    -------------------------------\n");

animal1.Apresentar("GATO", "Maine Coon", 100);
animal1.EmitirSom();

animal2.Apresentar("CACHORRO", "Akita", 71);
animal2.EmitirSom();

animal3.Apresentar("PÁSSARO", "Pitassilgo", 13);
animal3.EmitirSom();

Console.WriteLine("\t    -------------------------------\n\n");

