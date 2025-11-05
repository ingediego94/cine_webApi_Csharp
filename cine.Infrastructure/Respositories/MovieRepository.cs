using cine.Domain.Entities;
using cine.Domain.Interfaces;
using cine.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace cine.Infrastructure.Respositories;

public class MovieRepositoryb: IMovieRepository
{
    private readonly AppDbContext _context;

    public MovieRepositoryb(AppDbContext context)
    {
        _context = context;
    }
    
    // ---------------------------------------
    
    // Get By Id:
    public async Task<Movie?> GetByIdAsync(int id)
    {
        return await _context.movies_tb.FindAsync(id);
    }

    
    // Get All:
    public async Task<IEnumerable<Movie>> GetAllAsync()
    {
        return await _context.movies_tb.ToListAsync();
    }

    
    // Create:
    public async Task<Movie> CreateAsync(Movie movie)
    {
        _context.movies_tb.Add(movie);
        await _context.SaveChangesAsync();
        return movie;
    }

    
    // Update:
    public async Task<Movie?> UpdateAsync(Movie movie)
    {
        var existing = await _context.movies_tb.FindAsync(movie.Id);

        if (existing == null)
            return null;

        existing.Title = movie.Title;
        existing.Description = movie.Description;
        existing.ReleaseDate = movie.ReleaseDate;
        existing.MovieCode = movie.MovieCode;

        await _context.SaveChangesAsync();
        return existing;
    }

    
    // Delete:
    public async Task<bool> DeleteAsync(int id)
    {
        var movieToDelete = await _context.movies_tb.FindAsync(id);

        if (movieToDelete == null)
            return false;

        _context.movies_tb.Remove(movieToDelete);
        await _context.SaveChangesAsync();
        return true;
    }
}