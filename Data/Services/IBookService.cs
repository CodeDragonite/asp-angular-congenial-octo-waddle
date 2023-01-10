namespace Summaries.Data;

public interface IBookService
{
    public List<Book> GetAllBooks();
    public Book GetBookById(int id);
    public void UpdateBook(int id, Book newBook);
    public void DeleteBook(int id);
    public void AddBook(Book book);
}