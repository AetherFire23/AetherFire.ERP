using AetherFire23.Commons.Domain.Entities;

namespace AetherFire23.ERP.Domain.Entity;

public class User : EntityBase
{
    // Small tension that needs to get clarified : required Guid but nullable company... 
    // However it may be mor efficient to just set with id sometimes, most of the time, also it doesnt rely on the 
    // fact that ef core is tracking the entity. 
    public required Guid CompanyId { get; set; }
    public Company? Company { get; set; }
    public required string Username { get; set; } = string.Empty;

    public static User Create(string username, Guid companyId)
    {
        var user = new User()
        {
            CompanyId = companyId,
            Username = username,
        };

        return user;
    }
}