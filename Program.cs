using System;

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        // Adicionando usuários
        while (true)
        {
            Console.WriteLine("Deseja adicionar um usuário? (s/n)");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "n") break;

            Console.Write("Digite o ID do usuário: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o email do usuário: ");
            string email = Console.ReadLine();

            biblioteca.AdicionarUsuario(id, nome, email);
            Console.WriteLine("Usuário adicionado com sucesso!");
        }

        // Adicionando livros
        while (true)
        {
            Console.WriteLine("Deseja adicionar um livro? (s/n)");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "n") break;

            Console.Write("Digite o ID do livro: ");
            int livroId = int.Parse(Console.ReadLine());

            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();

            biblioteca.Registro.AdicionarLivro(livroId, titulo, autor);
            Console.WriteLine("Livro adicionado com sucesso!");
        }

        // Listando livros
        Console.WriteLine("\nLivros registrados:");
        biblioteca.Registro.ListarLivros();

        // Registrando um empréstimo
        while (true)
        {
            Console.WriteLine("Deseja registrar um empréstimo? (s/n)");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "n") break;

            Console.Write("Digite o ID do usuário que está emprestando: ");
            int usuarioId = int.Parse(Console.ReadLine());

            // Selecionando o livro
            int livroId = ConsoleUtils.SelecionarLivro(biblioteca.Registro.Livros);
            if (livroId == -1) continue; // Se não houver livros, volta ao loop

            Usuario usuarioParaEmprestar = biblioteca.Usuarios.Find(u => u.Id == usuarioId);

            if (usuarioParaEmprestar != null)
            {
                Livro livroParaEmprestar = biblioteca.Registro.BuscarLivro(livroId);
                Emprestimo emprestimo = new Emprestimo(1, livroParaEmprestar, usuarioParaEmprestar);
                biblioteca.RegistrarEmprestimo(emprestimo);
                Console.WriteLine($"Empréstimo registrado: {usuarioParaEmprestar.Nome} emprestou '{livroParaEmprestar.Titulo}'.");
            }
            else
            {
                Console.WriteLine("Usuário inválido.");
            }
        }

        // Listando livros após o empréstimo
        Console.WriteLine("\nLivros após o empréstimo:");
        biblioteca.Registro.ListarLivros();

        // Exibindo informações dos empréstimos
        Console.WriteLine("\nDetalhes dos empréstimos:");
        biblioteca.ListarEmprestimos();

        // Mantendo o console aberto
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
