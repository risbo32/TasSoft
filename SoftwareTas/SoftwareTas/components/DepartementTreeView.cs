using SoftwareTas.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas.components
{
   public class DepartementTreeView: TreeView
    {
        public Departement departement { get; set; }

        public bool PreFilterMessage(ref Message m)
        {
            
            throw new NotImplementedException();
        }
    }

  
}
