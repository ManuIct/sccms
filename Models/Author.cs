
namespace sccms.Models;

public class Author : ICommentabile
{
    private static List<Author> authors = new List<Author>();

    public Author(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string FullName { get => $"{Name} {Surname}"; }
    public List<Comment> Comments { get; set; } = new List<Comment>();

    internal static void Add(Author a)
    {
        authors.Add(a);
    }
}