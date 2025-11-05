using cine.Domain.Entities;

namespace cine.Domain.Interfaces;

public interface IMovieRepository
{
    Task<Movie?> GetByIdAsync(int id);
    Task<IEnumerable<Movie>> GetAllAsync();
    Task<Movie> CreateAsync(Movie movie);
    Task<Movie?> UpdateAsync(Movie movie);
    Task<bool> DeleteAsync(int id);
}