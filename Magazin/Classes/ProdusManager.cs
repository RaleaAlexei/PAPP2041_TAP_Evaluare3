using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.Classes
{
    internal class ProdusManager
    {
        private MagazinDbContext dbContext;
        public ProdusManager()
        {
            dbContext = new MagazinDbContext();
        }
        public void AdaugaProdus(Produs produs)
        {
            dbContext.Produse.Add(produs);
            dbContext.SaveChanges();
        }
        public List<Produs> GetProduse()
        {
            return dbContext.Produse.ToList();
        }

        public Produs GetProdusById(int id)
        {
            return dbContext.Produse.Find(id);
        }
        public void EditeazaProdus(Produs produs)
        {
            var existingProdus = dbContext.Produse.Find(produs.Id);
            if (existingProdus != null)
            {
                existingProdus.Denumire = produs.Denumire;
                existingProdus.DataProducției = produs.DataProducției;
                existingProdus.TermenValabilitate = produs.TermenValabilitate;
                existingProdus.Pret = produs.Pret;
                dbContext.SaveChanges();
            }
        }
        public void StergeProdus(int id)
        {
            var produs = dbContext.Produse.Find(id);
            if (produs != null)
            {
                dbContext.Produse.Remove(produs);
                dbContext.SaveChanges();
            }
        }
    }
}
