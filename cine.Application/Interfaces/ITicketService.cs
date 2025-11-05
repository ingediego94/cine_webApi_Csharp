using cine.Domain.Entities;

namespace cine.Application.Interfaces;

public interface ITicketService
{
    Task<Ticket> GetByIdAsync(int id);
    Task<IEnumerable<Ticket>> GetAllAsync();
    Task<Ticket> CreateAsync(Ticket ticket);
    Task<bool> UpdateAsync(Ticket ticket);
    Task<bool> DeleteAsync(int id);
}