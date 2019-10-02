using SoftwareTas.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramSender
{
    public partial class FormEtudiant : Form
    {
        Eleve eleve;
        public FormEtudiant()
        {
            InitializeComponent();
        }

        public FormEtudiant(Eleve _eleve):this()
        {
            this.eleve = _eleve;
            if(eleve!= null)
            fillDataFields();
        }

        private void fillDataFields()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataValid())
            {
                //Enregistrement eleve
            }
            else
            {
                //Montrer les erreurs
            }
        }

        private bool dataValid()
        {
            throw new NotImplementedException();
        }
    }
}
