using gelateca.solidaria.domain.Entities;

namespace gelateca.solidaria.domain.Interfaces;

public interface IBookRepository
{
    Task<IEnumerable<Librarie>> GetLibrariesAsync();
    Task<Librarie> GetByIdAsync(int? id);
    //Task<Book> GetBooksLibraryAsync(int? id);
    Task<Librarie> CreateAsync(Librarie librarie);
    Task<Librarie> UpdateAsync(Librarie librarie);
    Task<Librarie> RemoveAsync(Librarie librarie);
}
