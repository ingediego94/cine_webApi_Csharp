using cine.Domain.Entities;

namespace cine.Application.Interfaces;

public interface IClientService
{
    Task<Client> GetByIdAsync_(int id);
    Task<IEnumerable<Client>> GetAllAsync_();
    Task<Client> CreateAsync_(Client client);
    Task<bool> UpdateAsync_(Client client);
    Task<bool> DeleteAsync_(int id);
}