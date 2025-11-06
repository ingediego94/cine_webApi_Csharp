namespace cine.Application.Dto;

public class MovieCreateUpdateDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string MovieCode { get; set; }
}