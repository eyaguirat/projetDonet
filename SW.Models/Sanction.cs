using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW.Models
{
    public class Sanction
    {
        public DateTime Date { get; set; }
        public int MalusMerite { get; set; }
        public Citoyen InfligePar { get; set; }
        public Citoyen InfligeA { get; set; }
    }
}
