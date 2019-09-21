using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTas.data
{
    public class Eleve
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Matricule { get; set; } = "STD";
        public Departement Departement { get; set; }
    }
}
