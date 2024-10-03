using System;
using System.Collections.Generic;

public static class ConsoleUtils
{
    public static int SelecionarLivro(List<Livro> livros)
    {
        if (livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro disponível.");
            return -1; // Retorna -1 se não houver livros
        }

        int index = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Use < e > para navegar entre os livros e pressione Enter para selecionar:");

            // Exibe a lista de livros
            for (int i = 0; i < livros.Count; i++)
            {
                if (i == index)
                    Console.WriteLine($"> {livros[i].Titulo}"); // Indica o livro selecionado
                else
                    Console.WriteLine($"  {livros[i].Titulo}");
            }

            var key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.RightArrow) // Navega para a direita
            {
                index = (index + 1) % livros.Count;
            }
            else if (key.Key == ConsoleKey.LeftArrow) // Navega para a esquerda
            {
                index = (index - 1 + livros.Count) % livros.Count;
            }
            else if (key.Key == ConsoleKey.Enter) // Seleciona o livro
            {
                return livros[index].Id; // Retorna o ID do livro selecionado
            }
        }
    }
}