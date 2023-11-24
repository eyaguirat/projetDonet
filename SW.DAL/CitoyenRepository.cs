using SW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW.DAL
{
    public class CitoyenRepository
    {
        public SWDBContext Context { get; set; }
        public CitoyenRepository(SWDBContext context)
        {
            Context = context;
        }

        public List<Citoyen> GetAll()
        {
            return Context.Citoyens.ToList();
        }
    }
}
