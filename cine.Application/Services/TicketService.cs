using cine.Application.Interfaces;
using cine.Domain.Entities;
using cine.Domain.Interfaces;

namespace cine.Application.Services;

public class TicketService : ITicketService
{
    private readonly ITicketRepository _ticketRepository;

    public TicketService( ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }
    
    // ------------------------------------------------
    
    // Get By Id:
    public async Task<Ticket> GetByIdAsync(int id)
    {
        return await _ticketRepository.GetByIdAsync(id);
    }

    
    // Get All:
    public async Task<IEnumerable<Ticket>> GetAllAsync()
    {
        return await _ticketRepository.GetAllAsync();
    }

    
    // Create:
    public async Task<Ticket> CreateAsync(Ticket ticket)
    {
        return await _ticketRepository.CreateAsync(ticket);
    }

    
    // Update:
    public async Task<bool> UpdateAsync(Ticket ticket)
    {
        var existing = _ticketRepository.GetByIdAsync(ticket.Id);

        if (existing == null)
            return false;

        await _ticketRepository.UpdateAsync(ticket);

        return true;
    }

    
    // Delete:
    public async Task<bool> DeleteAsync(int id)
    {
        var existing = await _ticketRepository.GetByIdAsync(id);

        if (existing == null)
            return false;

        return await _ticketRepository.DeleteAsync(id);
    }
}