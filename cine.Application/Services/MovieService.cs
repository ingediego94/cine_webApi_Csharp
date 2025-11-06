using System.Runtime.CompilerServices;
using cine.Application.Interfaces;
using cine.Domain.Entities;
using cine.Domain.Interfaces;

namespace cine.Application.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;
    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    // -----------------------------------------------
    
    // Get By Id:
    public async Task<Movie> GetByIdAsync_(int id)
    {
        return await _movieRepository.GetByIdAsync(id);
    }

    
    // Get All:
    public async Task<IEnumerable<Movie>> GetAllAsync_()
    {
        return await _movieRepository.GetAllAsync();
    }

    
    // Create:
    public async Task<Movie> CreateAsync_(Movie movie)
    {
        return await _movieRepository.CreateAsync(movie);
    }

    
    // Update:
    public async Task<bool> UpdateAsync_(Movie movie)
    {
        var existing = await _movieRepository.GetByIdAsync(movie.Id);

        if (existing == null)
            return false;

        await _movieRepository.UpdateAsync(movie);
        
        return true;
    }

    
    // Delete:
    public async Task<bool> DeleteAsync_(int id)
    {
        var movieToDelete = _movieRepository.GetByIdAsync(id);

        if (movieToDelete == null)
            return false;
        
        return await _movieRepository.DeleteAsync(id);
    }
}