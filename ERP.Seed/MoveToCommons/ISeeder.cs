namespace ERP.Seed;

/// <summary>
/// I'll think about if I need playwright to live in another assembly... seeds like a lot of useless separation if I did
/// 
/// </summary>
public interface ISeeder
{
    /// <summary>
    /// The actual seeding process 
    /// </summary>
    /// <returns></returns>
    public Task SetupSeeding();
}