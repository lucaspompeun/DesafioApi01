using DesafioApi01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi01.Service
{
    public static class TaxaService
    {
        static Taxa TaxaJuros { get; set; }

        static TaxaService()
        {
            TaxaJuros = new Taxa { ValorTaxa = 0.1 };
        }

        public static Taxa GetTaxaJuros()
        {
            return TaxaJuros;
        }
    }
}
