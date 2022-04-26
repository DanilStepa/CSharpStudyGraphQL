namespace JamesBond.Data;
/// <summary>
/// Film Director
/// </summary>
public class Director : BaseEntity
{
    /// <summary>
    /// Director's name
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Films directed by the director
    /// </summary>
    public List<Movie>? Movies { get; set; }
}