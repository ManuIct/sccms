namespace sccms.Models;

public class Category
{
    public Category(string title)
    {
        Title = title;
        NumberOfArticles = 0;
    }
    public string Title { get; set; }
    public int NumberOfArticles { get; set; }

}