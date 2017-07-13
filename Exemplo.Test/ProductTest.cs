using Exemplo.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exemplo.Test
{
    [TestClass]
    public class ProductTest
    {
        private Product _product;

        public ProductTest()
        {
            _product = new Product();
            _product.Description = "Product 1";
            _product.IdCategory = 1;
        }

        [TestMethod]
        public void Prudct_Discount_True()
        {
            Assert.IsTrue(_product.IsValid());
        }
    }
}
