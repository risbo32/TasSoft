using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTas
{
   public class Departement
    {
        public int IdDepartement { get; set; }
        public string Nom { get; set; }
        public Departement Parent { get; set; }

        public List<Departement> sousDepartements { get; set; } = new List<Departement>();
    }
}
