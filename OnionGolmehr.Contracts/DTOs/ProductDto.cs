using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionGolmehr.Contracts.DTOs;

public class ProductDto(string name, decimal size)
{
    public string Name { get; set; } = name;
    public decimal Size { get; set; } = size;
}

