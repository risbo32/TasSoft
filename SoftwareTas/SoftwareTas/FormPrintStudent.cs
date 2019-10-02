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

namespace SoftwareTas
{
    public partial class FormPrintStudent : Form
    {
        private Departement currentDepartement = null;
        public FormPrintStudent()
        {
            InitializeComponent();
        }

        public FormPrintStudent(Departement departement) : this()
        {
            this.currentDepartement= departement;
        }

        private void FormPrintStudent_Load(object sender, EventArgs e)
        {
            List<Eleve> eleves = DataProvider.GetStudentData();
            dataGridView1.DataSource = eleves;
            printDocument1.DocumentName = "Liste eleves CLASSE xxx";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            printDocument1.Print();
        }
    }
}
