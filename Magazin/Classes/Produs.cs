using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.Classes
{
    [Table("Produse")]
    public class Produs
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public DateTime DataProducției { get; set; }
        public DateTime TermenValabilitate { get; set; }
        public double Pret { get; set; }
    }
}
