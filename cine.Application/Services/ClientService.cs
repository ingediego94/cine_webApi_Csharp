using cine.Application.Interfaces;
using cine.Domain.Entities;
using cine.Domain.Interfaces;

namespace cine.Application.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }
    
    // ------------------------------------------

    // Get By Id:
    public async Task<Client> GetByIdAsync_(int id)
    {
        return await _clientRepository.GetByIdAsync(id);
    }

    
    // Get All:
    public async Task<IEnumerable<Client>> GetAllAsync_()
    {
        return await _clientRepository.GetAllAsync();
    }

    
    // Create:
    public async Task<Client> CreateAsync_(Client client)
    {
        return await _clientRepository.CreateAsync(client);
    }

    
    // Update:
    public async Task<bool> UpdateAsync_(Client client)
    {
        var existing = await _clientRepository.GetByIdAsync(client.Id);
        
        if (existing == null)
            return false;

        await _clientRepository.UpdateAsync(client);
        
        return true;
    }

    
    // Delete:
    public async Task<bool> DeleteAsync_(int id)
    {
        var clientToDelete = _clientRepository.GetByIdAsync(id);

        if (clientToDelete == null)
            return false;

        return await _clientRepository.DeleteAsync(id);
    }
}