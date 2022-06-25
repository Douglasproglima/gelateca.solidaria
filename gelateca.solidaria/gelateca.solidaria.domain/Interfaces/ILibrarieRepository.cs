using gelateca.solidaria.domain.Entities;

namespace gelateca.solidaria.domain.Interfaces;

public interface ILibrarieRepository
{
    Task<IEnumerable<Book>> GetBooksAsync();
    Task<Book> GetByIdAsync(int? id);
    Task<Book> CreateAsync(Book book);
    Task<Book> UpdateAsync(Book book);
    Task<Book> RemoveAsync(Book book);
}
