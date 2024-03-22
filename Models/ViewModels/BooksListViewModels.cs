using BookStore.Models.ViewModels;
using Mission11_Breshears.Models;
using Mission11_Breshears.Models;

namespace Mission11_Breshears.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}