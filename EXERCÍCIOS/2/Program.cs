using _2.Classes;

Autor autorLivro = new Autor();
autorLivro.nomeAutor = "Alwyn Hamilton";
autorLivro.emailAutor = "imanauthor@gamail.com";

Livro livro = new Livro();
livro.nomeLivro = "Trono de Vidro";

livro.lista.Add(autorLivro);

Console.WriteLine("\n\n\t     .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .");

Console.WriteLine($"\n\t\tLivro: {livro.nomeLivro}");
Console.WriteLine($"\n\t\tAutor do livro: {livro.lista[0].nomeAutor}");
Console.WriteLine($"\n\t\tEmail do livro: {livro.lista[0].emailAutor}");

Console.WriteLine("\n\t     .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .\n\n");
