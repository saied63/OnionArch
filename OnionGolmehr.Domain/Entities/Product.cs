using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionGolmehr.Domain.Entities
{
    
    public class Product(string name, decimal size)
    {
        public string Name { get; set; } = name;
        public decimal Size { get; set; } = size;
    }
}
