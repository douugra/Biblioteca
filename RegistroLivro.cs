using System;
using System.Collections.Generic;

public class RegistroLivro
{
    public List<Livro> Livros;

    public RegistroLivro()
    {
        Livros = new List<Livro>();
    }

    public void AdicionarLivro(int id, string titulo, string autor)
    {
        Livro novoLivro = new Livro(id, titulo, autor);
        Livros.Add(novoLivro);
    }

    public void ListarLivros()
    {
        foreach (var livro in Livros)
        {
            Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor}, Disponível: {livro.Disponivel}");
        }
    }

    public Livro BuscarLivro(int id)
    {
        return Livros.Find(l => l.Id == id);
    }
}
