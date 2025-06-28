using BookStoreManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public List<Book> Get()
        {
            // Something happens
            List<Book> books = [new Book { Id = 0, BookFormat = BookFormat.Paperback, ISBN = "ABC", Title = "Spiderman", DatePublished = DateTime.Now.AddYears(-2) },
                                new Book { Id = 1, BookFormat = BookFormat.Paperback, ISBN = "ABC3", Title = "Spiderman3", DatePublished = DateTime.Now.AddYears(-2) }];

            return books;
        }
    }
}
