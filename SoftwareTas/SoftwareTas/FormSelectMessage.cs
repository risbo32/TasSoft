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
    public partial class FormSelectMessage : Form
    {
        List<String> elements;
        imsdbDataSet.employeeDataTable selectionEmployes = new imsdbDataSet.employeeDataTable();
        TreeDepartement treeDepartements = new TreeDepartement();
        imsdbDataSet.employeeDataTable employees = new imsdbDataSet.employeeDataTable();
        imsdbDataSet.departmentDataTable departments = new imsdbDataSet.departmentDataTable();

        public FormSelectMessage()
        {
            InitializeComponent();
            Departement college = new Departement { Nom="College charles de gaulles"};
            elements = new List<string>();
            elements.Add("College charles de gaulles");
            elements.Add("Section Anglophone");
            elements.Add("Section Francophone");
            elements.Add("Cm2");
            
            treeDepartements.Visible = false;
           
            departmentTableAdapter1.Fill(departments);
            cmBxListe.DataSource = departments;
            cmBxListe.DisplayMember = "deptname";
            splitContainer1.Panel1.Controls.Add(treeDepartements);

           
            employeeTableAdapter1.Fill(employees);
            listBox1.DataSource = employees;
            
            listBox1.DisplayMember = "empname";
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            new FormTaskInProgress().ShowDialog();
           // MessageBox.Show("Envoyer un message ");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Annulation de l'action");
        }

        private void cmBxListe_DropDown(object sender, EventArgs e)
        {
          //  if (this.Visible == false) return;
            treeDepartements.Visible = true;
            treeDepartements.Width = cmBxListe.Width;
            treeDepartements.Top = cmBxListe.Top +cmBxListe.Height+ 40;
            treeDepartements.Left = cmBxListe.Left;
            treeDepartements.BringToFront();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            new FormTaskInProgress().ShowDialog();
        }

        private void cmBxListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmBxListe.SelectedIndex;
            if (index > 0)
            {
                if(cmBxListe.SelectedItem!= null)
                {
                    selectionEmployes.Rows.Clear();
                    selectionEmployes.Rows.Add();
                    //employees.Where(x => x.deptid == departments.Rows[index]);
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
