namespace JamesBond.Data;

public class Movie : BaseEntity
{
    /// <summary>
    /// Movie title
    /// </summary>
    public string? Title { get; set; }
    /// <summary>
    /// Movie release date
    /// </summary>
    public DateTime? ReleaseDate { get; set; }
    public long? BondId { get; set; }
    /// <summary>
    /// Bond from this movie
    /// </summary>
    public Bond? Bond { get; set; }
    public long? DirectorId { get; set; }
    /// <summary>
    /// The director of this film
    /// </summary>
    public Director? Director { get; set; }
}