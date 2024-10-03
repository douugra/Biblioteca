using System;

public class Emprestimo
{
    public int Id;
    public Livro LivroEmprestado;
    public Usuario UsuarioEmprestimo;
    public DateTime DataEmprestimo;
    public DateTime DataDevolucao;

    public Emprestimo(int id, Livro livroEmprestado, Usuario usuarioEmprestimo)
    {
        Id = id;
        LivroEmprestado = livroEmprestado;
        UsuarioEmprestimo = usuarioEmprestimo;
        DataEmprestimo = DateTime.Now;
        DataDevolucao = DataEmprestimo.AddDays(14); // Devolução em 14 dias
    }
}
