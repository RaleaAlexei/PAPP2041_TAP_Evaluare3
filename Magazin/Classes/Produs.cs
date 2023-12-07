using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.Classes
{
    public class Produs
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public DateTime DataProducției { get; set; }
        public DateTime TermenValabilitate { get; set; }
        public double Pret { get; set; }
    }
}
