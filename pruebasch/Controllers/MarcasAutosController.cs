using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pruebasch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebasch.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarcasAutosController : Controller
    {
        private readonly ModelContext _context;
        public MarcasAutosController(ModelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<MarcasAutos> GetMarcasAutos()
        {
            var rsponse = _context.MARCAS_AUTOS.ToList();
            return rsponse;
        }
    }
}
