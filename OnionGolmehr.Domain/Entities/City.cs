using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionGolmehr.Domain.Entities;

public class City
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string? Description { get; set; }
    public Guid CountryId { get; set; }

    // ✅ Navigation property
    public Country Country { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public City(string name, Guid countryId, Country country)
    {
        Name = name;
        CountryId = countryId;
        Country = country;
    }
}

