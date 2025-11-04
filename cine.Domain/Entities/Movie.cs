namespace cine.Domain.Entities;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string MovieCode { get; set; }
    
    // Relation with other tables:
    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}