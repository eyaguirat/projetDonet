using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW.Models
{
    public class Distinction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int BonusMerite { get; set; }
        public Citoyen DecernePar { get; set; }
        public Citoyen DecerneA { get; set; }
    }
}
