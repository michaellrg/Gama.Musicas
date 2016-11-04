using Gama.Musicas.AcessoDados.Entity.TypeConfiguration;
using Gama.Musicas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Musicas.AcessoDados.Entity.Context
{
    public class MusicasDbContext:DbContext
    {
        public DbSet<Album> Albuns { get; set; }
        public void MusicasDBContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuider)
        {
            modelBuider.Configurations.Add(new AlbumTypeConfiguration());
        }
    }

   
   
}
