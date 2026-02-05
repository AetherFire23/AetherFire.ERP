using AetherFire23.Commons.Domain.Entities;

namespace AetherFire23.ERP.Domain.Entity;

public class Company : EntityBase
{
    public required string CompanyName { get; set; }

    public virtual ICollection<Warehouse> Warehouses { get; set; } = [];

    private Company()
    {
    }

    public static Company Create(string name)
    {
        Company company = new()
        {
            CompanyName = name
        };

        return company;
    }
}