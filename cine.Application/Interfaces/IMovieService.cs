using cine.Domain.Entities;

namespace cine.Application.Interfaces;

public interface IMovieService
{
    Task<Movie> GetByIdAsync_(int id);
    Task<IEnumerable<Movie>> GetAllAsync_();
    Task<Movie> CreateAsync_(Movie movie);
    Task<bool> UpdateAsync_(Movie movie);
    Task<bool> DeleteAsync_(int id);
}