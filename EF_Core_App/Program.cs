using EF_Core_App;

using var dbContext = new BookContext();

var book = new Book("Amazing book");
for (int i = 0; i < 599; i++)
{
    book.Pages.Add(new Page(i, $"Content - {i}"));
}
dbContext.Books.Add(book);
dbContext.SaveChanges();

//var page = new Page(1, "some page text");

//dbContext.Pages.Add(page);
//dbContext.SaveChanges();

//dbContext.Pages.Remove(page);
//dbContext.SaveChanges();

//var result = dbContext.Pages.FirstOrDefault(x => x.Id == new Guid("02283196-1E27-4B29-95AE-ACD157591E66"));
//dbContext.Pages.Remove(result);
//dbContext.SaveChanges();
