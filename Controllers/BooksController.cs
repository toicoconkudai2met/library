using library.data;
using library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace library.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryContext _context;

        public BooksController(LibraryContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _context.Books
                .Include(b => b.Author) // Nạp thông tin tác giả
                .Include(b => b.Category) // Nạp thông tin thể loại
                .Select(b => new BookViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    PublishYear = b.PublishYear,
                    AuthorName = b.Author.Name, // Lấy tên tác giả
                    CategoryName = b.Category.Name // Lấy tên thể loại
                })
                .ToListAsync();

            return View(books);
        }
    }
}
