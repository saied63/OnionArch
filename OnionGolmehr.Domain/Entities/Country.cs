using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionGolmehr.Domain.Entities;
public class Country
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string ContinentName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // ✅ Navigation property
    public ICollection<City> Cities { get; set; } = new List<City>();

    public Country(string name, string continentName)
    {
        Name = name;
        ContinentName = continentName;
    }
}

