using System.Collections.Generic;
namespace Summaries.Data;
public class BookService : IBookService
{
    public void AddBook(Book book)
    {
        Data.Books.Add(book);
    }

    public void DeleteBook(int id)
    {
        var book = Data.Books.FirstOrDefault(x => x.Id == id);
        Data.Books.Remove(book);
    }

    public List<Book> GetAllBooks()
    {
        return Data.Books.ToList();
    }

    public Book GetBookById(int id) => Data.Books.FirstOrDefault(x => x.Id == id);

    public void UpdateBook(int id, Book newBook)
    {
        var oldBook = Data.Books.FirstOrDefault(x => x.Id == id);
        if(oldBook != null)
        {
            oldBook.Title = newBook.Title;
            oldBook.Description = newBook.Description;
            oldBook.Author = newBook.Author;
            oldBook.Rate = newBook.Rate;
            oldBook.DateStart = newBook.DateStart;
            oldBook.DateRead = newBook.DateRead;
        }
    }
}