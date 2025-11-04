namespace cine.Domain.Entities;

public class Ticket
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int MovieId { get; set; }
    public DateTime FunctionDate { get; set; }
    
    // Relation 1:N
    public Client Client { get; set; }
    public Movie Movie { get; set; }
}