using cine.Domain.Entities;

namespace cine.Application.Interfaces;

public interface IMovieService
{
    Task<Movie> GetById(int id);
    Task<IEnumerable<Movie>> GetAll();
    Task<Movie> Create(Movie movie);
    Task<bool> Update(Movie movie);
    Task<bool> Delete(int id);
}