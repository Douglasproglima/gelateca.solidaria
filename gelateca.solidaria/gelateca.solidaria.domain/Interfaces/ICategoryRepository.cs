using gelateca.solidaria.domain.Entities;

namespace gelateca.solidaria.domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Book>> GetBooksAsync();
        Task<Librarie> GetByIdAsync(int? id);
        //Task<Book> GetBooksLibraryAsync(int? id);
        Task<Category> CreateAsync(Category librarie);
        Task<Category> UpdateAsync(Category librarie);
        Task<Category> RemoveAsync(Category librarie);
    }
}
