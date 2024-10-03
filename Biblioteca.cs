using System;
using System.Collections.Generic;

public class Biblioteca
{
    public List<Usuario> Usuarios;
    public List<Emprestimo> Emprestimos;
    public RegistroLivro Registro;

    public Biblioteca()
    {
        Usuarios = new List<Usuario>();
        Emprestimos = new List<Emprestimo>();
        Registro = new RegistroLivro();
    }

    public void AdicionarUsuario(int id, string nome, string email)
    {
        Usuario novoUsuario = new Usuario(id, nome, email);
        Usuarios.Add(novoUsuario);
    }

    public void RegistrarEmprestimo(Emprestimo emprestimo)
    {
        Emprestimos.Add(emprestimo);
        emprestimo.LivroEmprestado.Disponivel = false; // Marca o livro como não disponível
    }
    public void ListarEmprestimos()
    {
        foreach (var emprestimo in Emprestimos)
        {
            Console.WriteLine($"Livro: '{emprestimo.LivroEmprestado.Titulo}' " +
                              $"(Disponível: {emprestimo.LivroEmprestado.Disponivel}) " +
                              $"emprestado para ID {emprestimo.UsuarioEmprestimo.Id} " +
                              $"- Usuário: {emprestimo.UsuarioEmprestimo.Nome}, Email: {emprestimo.UsuarioEmprestimo.Email}");
        }
    }
}
