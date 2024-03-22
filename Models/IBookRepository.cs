using Mission11_Breshears.Models;

namespace Mission11_Breshears.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
