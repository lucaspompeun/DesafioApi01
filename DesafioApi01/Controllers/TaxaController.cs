using DesafioApi01.Model;
using DesafioApi01.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaController : Controller
    {
        public TaxaController()
        {
        }

        [HttpGet]
        [Route("/taxaJuros")]
        public ActionResult<Taxa> Get()
        {
            return TaxaService.GetTaxaJuros();
        }
    }
}
