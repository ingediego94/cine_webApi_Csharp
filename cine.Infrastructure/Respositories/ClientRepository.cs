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
    
    // ---------------------------------------------------
    
    //Get By Id:
    public async Task<Client?> GetByIdAsync(int id)
    {
        return await _context.clients_tb.FindAsync(id);
    }

    public Task<IEnumerable<Client>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Client> CreateAsync(Client client)
    {
        throw new NotImplementedException();
    }

    public Task<Client?> UpdateAsync(Client client)
    {
        throw new NotImplementedException();
    }
}