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

        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string ParentTelOrange { get; set; }
        public string ParentTelMtn { get; set; }
        public string ParentTelNextell { get; set; }
        public string ParentTelCamtel { get; set; }
        public string ParentTelOther { get; set; }
        public DateTime DateNaissance { get; set; } = new DateTime(2001, 1, 1);
        public bool isMale { get; set; } = true;
    }
}
