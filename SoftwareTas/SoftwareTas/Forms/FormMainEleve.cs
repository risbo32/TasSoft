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
using TelegramSender;

namespace SoftwareTas.Forms
{
    public partial class FormMainEleve : Form
    {
        public FormMainEleve()
        {
            InitializeComponent();
        }

        private void btnAddEleve_Click(object sender, EventArgs e)
        {
            new FormRevision1().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifEleve_Click(object sender, EventArgs e)
        {
            Eleve eleve = new Eleve { Name="Eleve ", Surname="Demo", Id=1, Matricule="EVEDMO" };
            new FormRevision1(eleve).ShowDialog();
        }
    }
}
