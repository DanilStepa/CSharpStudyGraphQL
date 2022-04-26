namespace JamesBond.Data;

/// <summary>
/// Bond. James Bond
/// </summary>
public class Bond : BaseEntity
{
    /// <summary>
    /// Actor Name
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Films in which this bond was involved
    /// </summary>
    public List<Movie>? Movies { get; set; }
}
