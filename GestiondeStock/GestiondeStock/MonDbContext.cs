using System.Data.Entity;

namespace GestiondeStock
{
    public class MonDbContext : DbContext
    {
        public MonDbContext() : base("name=MaChaineDeConnexion")
        {
        }

        public DbSet<Produit> Produits { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}