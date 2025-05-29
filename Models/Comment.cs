using System.Security.Cryptography.X509Certificates;

namespace sccms.Models;

public class Comment : ICommentabile
{
    private string? text;

    public Comment(Author author, DateTime dataPubblicazione, string testo)
    {
        Author = author;
        DatePubblicazione = dataPubblicazione;
        Text = text;
    }
    public Author Author { get; set; }
    public DateTime DatePubblicazione { get; set; }
    public string Text { get; set; }
    public List<Comment> Comments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
