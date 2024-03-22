using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Mission11_Breshears.Models.ViewModels;
using Mission11_Breshears.Models;
using BookStore.Models.ViewModels;
// test.

namespace Mission11_Breshears.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var blah = new BooksListViewModel()
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = 5,
                    TotalItems = _repo.Books.Count()

                }
            };

            return View(blah);
        }

    }
}