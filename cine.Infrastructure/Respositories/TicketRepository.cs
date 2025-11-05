using cine.Domain.Entities;
using cine.Domain.Interfaces;
using cine.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace cine.Infrastructure.Respositories;

public class TicketRepository : ITicketRepository
{
    private readonly AppDbContext _context;

    public TicketRepository(AppDbContext context)
    {
        _context = context;
    }
    
    
    // ------------------------------------------
    
    // Get By Id:
    public async Task<Ticket?> GetByIdAsync(int id)
    {
        return await _context.tickets_tb.FindAsync(id);
    }

    
    // Get All:
    public async Task<IEnumerable<Ticket>> GetAllAsync()
    {
        return await _context.tickets_tb.ToListAsync();
    }
    
    
    // Create:
    public async Task<Ticket> CreateAsync(Ticket ticket)
    {
        _context.tickets_tb.Add(ticket);
        await _context.SaveChangesAsync();
        return ticket;
    }

    
    // Update:
    public Task<Ticket?> UpdateAsync(Ticket ticket)
    {
        throw new NotImplementedException();
    }

    
    // Delete:
    public async Task<bool> DeleteAsync(int id)
    {
        var ticketToDelete = await _context.tickets_tb.FindAsync(id);

        if (ticketToDelete == null)
            return false;

        _context.tickets_tb.Remove(ticketToDelete);
        await _context.SaveChangesAsync();
        return true;
    }


}
