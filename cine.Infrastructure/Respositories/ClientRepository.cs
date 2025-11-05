using cine.Domain.Entities;
using cine.Domain.Interfaces;
using cine.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace cine.Infrastructure.Respositories;

public class ClientRepository : IClientRepository
{
    private readonly AppDbContext _context;
    public ClientRepository(AppDbContext context)
    {
        _context = context;
    }
    
    // ----------------------------------------
    
    // Get By Id:
    public async Task<Client?> GetByIdAsync(int id)
    {
        return await _context.clients_tb.FindAsync(id);
    }

    
    // Get All:
    public async Task<IEnumerable<Client>> GetAllAsync()
    {
        return await _context.clients_tb.ToListAsync();
    }
    
    
    // Delete:
    public async Task<bool> DeleteAsync(int id)
    {
        var toDelete = await _context.clients_tb.FindAsync(id);

        if (toDelete == null)
            return false;

        _context.clients_tb.Remove(toDelete);
        await _context.SaveChangesAsync();
        return true;
    }

    
    // Create:
    public async Task<Client> CreateAsync(Client client)
    {
        _context.clients_tb.Add(client);
        await _context.SaveChangesAsync();
        return client;
    }

    
    // Update:
    public async Task<Client?> UpdateAsync(Client client)
    {
        var existingClient = await _context.clients_tb.FindAsync(client);

        if (existingClient == null)
            return null;

        existingClient.Name = client.Name;
        existingClient.DocNumber = client.DocNumber;
        existingClient.Email = client.Email;
        existingClient.Active = client.Active;

        await _context.SaveChangesAsync();

        return existingClient;
    }
}