using sccms.Models;

namespace sccms;

public class Manager
{
    public static List<Author> Authors { get; } = [];
    public static List<Category> Categories { get; } = [];
    public static List<Article> Articles { get; } = [];
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

    internal static void CreateArticle(string v1, string v2, DateTime now)
    {
        throw new NotImplementedException();
    }
}