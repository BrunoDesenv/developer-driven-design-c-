using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exemplo.Test
{
    /// <summary>
    /// Summary description for Produto
    /// </summary>
    [TestClass]
    public class Produto
    {
        public Produto()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }
    }
}
