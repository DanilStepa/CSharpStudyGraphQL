using JamesBond.Data;

namespace JamesBond;


public class Query
{
    /// <summary>
    /// Get Bonds
    /// </summary>
    [UseDbContext(typeof(ApplicationDbContext))]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Bond> GetBonds([ScopedService] ApplicationDbContext context) => context.Bond;

    /// <summary>
    /// Get Movies
    /// </summary>
    [UseDbContext(typeof(ApplicationDbContext))]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Movie> GetMovies([ScopedService] ApplicationDbContext context) => context.Movies;

    /// <summary>
    /// Get Directors
    /// </summary>
    [UseDbContext(typeof(ApplicationDbContext))]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Director> GetDirectors([ScopedService] ApplicationDbContext context) => context.Directors;
}