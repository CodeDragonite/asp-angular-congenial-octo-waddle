using Microsoft.AspNetCore.Mvc;
using Summaries.Data;

namespace Summaries.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IBookService _service;

    public BooksController(ILogger<WeatherForecastController> logger, IBookService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpPost("AddBook")]
    public IActionResult AddBook([FromBody] Book book)
    {
        _service.AddBook(book);
        return Ok();
    }

    [HttpGet("[action]")]
    public IActionResult GetBooks()
    {
        var allBooks = _service.GetAllBooks();
        return Ok(allBooks);
    }

    [HttpPut("UpdateBook/{id}")]
    public IActionResult UpdateBook(int id, [FromBody] Book book)
    {
        _service.UpdateBook(id, book);
        return Ok(book);
    }

    [HttpDelete("DeleteBook/{id}")]
    public IActionResult DeleteBook(int id)
    {
        _service.DeleteBook(id);
        return Ok();
    }


    [HttpGet("SingleBook/{id}")]
    public IActionResult GetBookById(int id)
    {
        var book = _service.GetBookById(id);
        return Ok(book);
    }
}
