using DesafioApi01.Model;
using DesafioApi01.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioApi01Test
{
    [TestClass]
    public class TaxaJurosTest
    {
        [TestMethod]
        public void TaxaJuros()
        {
            Taxa expected = new Taxa { ValorTaxa = 0.01 };

            Taxa actual = TaxaService.GetTaxaJuros();

            Assert.AreEqual(expected.ValorTaxa, actual.ValorTaxa);
        }
    }
}
