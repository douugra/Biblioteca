public class Livro
{
    public int Id;
    public string Titulo;
    public string Autor;
    public bool Disponivel;

    public Livro(int id, string titulo, string autor)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        Disponivel = true; // Por padrão, o livro está disponível
    }
}

