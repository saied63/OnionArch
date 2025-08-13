using Xunit;
using Moq;
using OnionGolmehr.Domain.Entities;

public class ExampleTests
{
    [Fact]
    public void EntityCanBeCreated()
    {
        var product = new ProductEntity("Sample", 9.99m);
        Assert.Equal("Sample", product.Name);
    }
}
