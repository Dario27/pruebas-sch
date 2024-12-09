using Microsoft.EntityFrameworkCore;

namespace pruebasch.Models
{
    public class ModelContext: DbContext
    {
       public ModelContext(DbContextOptions<ModelContext >options) : base(options){ }

        public  DbSet<MarcasAutos> MARCAS_AUTOS { get; set; }
    }
}
