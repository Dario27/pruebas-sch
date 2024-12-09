using pruebasch.Controllers;
using pruebasch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testing.test
{
    public class MarcasAutoGetAll
    {
        [Fact]
        public void GetAll()
        {
            var marcasautos = new MarcasAutosController(new ModelContext());
            marcasautos.GetMarcasAutos();
        }

    }
}
