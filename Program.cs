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