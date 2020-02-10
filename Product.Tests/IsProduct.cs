using NUnit.Framework;
using Product.Services;

namespace Tests.UnitTests.Services
{

    [TestFixture]
    public class Tests
    {
        ProductService product;
        [SetUp]
        public void SetUp()
        {
            product = new ProductService();
        }
       
        [Test]
        public void Setup()
        {
            
            var result = product.IsPrime(1);
            // int SumResult = product.Sum(1,2);
            // Assert.AreEqual(SumResult, 4);
            Assert.IsFalse(result , "sum not done");
        }
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = product.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }

        [TestCase(2,2)]
        [TestCase(2,1)]
        [TestCase(3,1)]
        public void CheckSum(int a, int b) {
            int SumResult = product.Sum(a, b);
            Assert.AreEqual(SumResult, 4);

        }
    }

}

// https://github.com/dotnet/samples 