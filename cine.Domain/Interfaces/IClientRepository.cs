using cine.Domain.Entities;

namespace cine.Domain.Interfaces;

public interface IClientRepository
{
    Task<Client?> GetByIdAsync(int id);
    Task<IEnumerable<Client>> GetAllAsync();
    Task<bool> DeleteAsync(int id);
    Task<Client> CreateAsync(Client client);
    Task<Client?> UpdateAsync(Client client);
}