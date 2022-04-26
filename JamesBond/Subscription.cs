using JamesBond.Data;

namespace JamesBond;

public class Subscription
{
    /// <summary>
    /// Created new Bond
    /// </summary>
    /// <param name="bond"></param>
    /// <returns></returns>
    [Subscribe]
    public Bond OnBondCreated([EventMessage] Bond bond) => bond;
}