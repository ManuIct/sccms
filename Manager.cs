using System.Transactions;
using sccms.Models;

namespace sccms;

public interface IManager
{
    static abstract List<Author> Authors { get; }
    static abstract List<Category> Categories { get; }
    static abstract List<Article> Articles { get; }

    static abstract Article CreateArticle(string title, string text, DateTime publicationDate, Category category, Author author);
    static abstract Author CreateAuthor(string name, string surname);
    static abstract Category CreateCategory(string title);
    static abstract Comment CreateComment(ICommentabile comentabile, Author author, string text, DateTime dataPubblicazione);
}

public class Manager : ICommentabile
{
    // Removed unused static field 'commentabile'

    public static List<Author> Authors { get; } = [];
    public static List<Category> Categories { get; } = [];
    public static List<Article> Articles { get; } = [];
    public List<Comment> Comments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public static Author CreateAuthor(string name, string surname)
    {
        Author a = new Author(name, surname);
        Author.Add(a);
        return a;
    }

    public static Category CreateCategory(string title)
    {
        Category c = new(title);
        Categories.Add(c);
        return c;
    }

    public static Article CreateArticle(string title, string text, DateTime publicationDate, Category category, Author author)
    {
        Article c = new Article(title, text, publicationDate, category, author);
        Articles.Add(c);
        category.NumberOfArticles++;
        return c;
    }

    public static Comment CreateComment(ICommentabile comentabile, Author author, string text, DateTime dataPubblicazione)
    {
        Comment c = new Comment(author, dataPubblicazione, text);
        comentabile.Comments.Add(c);
        return c;
    }
}