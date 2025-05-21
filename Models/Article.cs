namespace sccms.Models;

public class Article
{
    public Article(string title, string text, DateTime publicationDate, Category category, Author author)
    {
        Title = title;
        Text = text;
        PublicationDate = publicationDate;
        Category = category;
        Author = author; 
    }
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime PublicationDate { get; set; }
    public Category? Category { get; set; }
    public Author? Author { get; set; }

}