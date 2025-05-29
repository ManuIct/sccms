using sccms;

var jc = Manager.CreateAuthor("John", "Cena");
var rr = Manager.CreateAuthor("Roman", "Reigns");

var tuts = Manager.CreateCategory("Tutorial");
var english = Manager.CreateCategory("English");

Manager.CreateArticle("c#", "oop", DateTime.Now, tuts, jc);
Manager.CreateArticle("present continuous", "I'm going at home", DateTime.Now, english, rr);

foreach (var category in Manager.Categories)
{
  Console.WriteLine($"Totale articoli {category.Title}: {category.NumberOfArticles} ");
}

Console.WriteLine("*** Article ***");

foreach (var article in Manager.Articles)
{
  Console.WriteLine(article.Title);
  Console.WriteLine($"di {article.Author?.FullName}");
  Console.WriteLine();
  Console.WriteLine(article.Text);
  Console.WriteLine();
}

Console.WriteLine($"Totale autori: {Manager.Authors.Count}");
Console.WriteLine($"Totale categoria: {Manager.Categories.Count}");
Console.WriteLine($"Totale articoli: {Manager.Articles.Count}");

var user = Manager.CreateAuthor("Utente", "Commentatore");
Manager.CreateComment(jc, user, "Congratulazioni per il tuo 17° titolo mondiale", DateTime.Now);
Manager.CreateComment(rr, user, "Congratulazioni per tuo regno longevo da campione del mondo", DateTime.Now);
Manager.CreateComment(Manager.Articles[0], user, "Ottimo", DateTime.Now);

Console.WriteLine(new string('_',100));
Console.WriteLine($"Commenti a: {Manager.Articles[0].Title}");
foreach (var c in Manager.Articles[0].Comments)
{
  Console.WriteLine($"{c.Text} - di {c.Author.FullName}");
} 