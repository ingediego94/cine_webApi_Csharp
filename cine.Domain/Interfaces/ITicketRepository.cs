using cine.Domain.Entities;

namespace cine.Domain.Interfaces;

public interface ITicketRepository
{
    Task<Ticket?> GetByIdAsync(int id);
    Task<IEnumerable<Ticket>> GetAllAsync();
    Task<Ticket> CreateAsync(Ticket ticket);
    Task<Ticket?> UpdateAsync(Ticket ticket);
    Task<bool> DeleteAsync(int id);
}