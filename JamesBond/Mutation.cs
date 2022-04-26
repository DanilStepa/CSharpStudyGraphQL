using System.Dynamic;
using HotChocolate.Subscriptions;
using JamesBond.Data;
using Microsoft.EntityFrameworkCore;

namespace JamesBond;

public class Mutation
{
    /// <summary>
    /// Create Bond
    /// </summary>
    /// <param name="bond"></param>
    /// <returns></returns>
    [UseDbContext(typeof(ApplicationDbContext))]
    public async Task<Bond> CreateBond([ScopedService] ApplicationDbContext context, 
                                       [Service] ITopicEventSender sender,Bond bond)
    {
        context.Bond.Add(bond);
        await context.SaveChangesAsync();
        await sender.SendAsync(nameof(Subscription.OnBondCreated), bond);
        return bond;
    }
    /// <summary>
    /// Update Bond
    /// </summary>
    /// <param name="context"></param>
    /// <param name="bond"></param>
    /// <returns></returns>
    [UseDbContext(typeof(ApplicationDbContext))]
    public async Task<Bond> UpdateBond([ScopedService] ApplicationDbContext context, Bond bond)
    {
        context.Entry(bond).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return bond;
    }
    /// <summary>
    /// Delete Bond
    /// </summary>
    /// <param name="context"></param>
    /// <param name="bond"></param>
    /// <returns></returns>
    [UseDbContext(typeof(ApplicationDbContext))]
    public bool DeleteBond([ScopedService] ApplicationDbContext context, long bondId)
    {
        try
        {
            var bond = context.Bond.FirstOrDefault(b => b.Id == bondId);
            if (bond is null) return false;
            context.Remove(bond);
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
}