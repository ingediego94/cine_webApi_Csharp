namespace cine.Domain.Entities;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string DocNumber { get; set; }
    public string Email { get; set; }
    public bool Active { get; set; }
    
    // Relation with other tables
    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}