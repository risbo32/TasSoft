using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTas.data
{
   public class Departement
    {
        int Id { get; set; }
        private string name = "";
        public string Name { get { return $"{name} " +
                    $"({this.eleves.Count})"; }
                set {
                name = $"{value} ({eleves.Count})";
            } }
        public Departement Parent { get; set; }
        public List<Eleve> Eleves { get {

                return this.eleves;
            } }

        public void  AddELeves(List<Eleve> _eleves)
        {
            this.eleves.AddRange(_eleves);
        }

        private List<Eleve> eleves = new List<Eleve>();
        
        public void AddEleve(Eleve eleve)
        {
            if (eleve != null)
            {
                eleve.Departement = this;
                this.eleves.Add(eleve);
            }
        }

        public List<Departement> SubDepartements
        {
            get { return this.subDepartements; }
        } 

        public void AddDepartement(Departement _departement)
        {
            if (_departement != null)
            {
                _departement.Parent = this;
                subDepartements.Add(_departement);
                if (_departement.Eleves != null)
                {
                    eleves.AddRange(_departement.Eleves);
                }
            }
        }

        private List<Departement> subDepartements = new List<Departement>();
    }
}
