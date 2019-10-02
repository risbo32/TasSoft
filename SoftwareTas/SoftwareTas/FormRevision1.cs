using SoftwareTas.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas
{
    public partial class FormRevision1 : Form
    {
        private Eleve eleve;
        private Color errorColor  = Color.Red;
        private Color colorSucces = Color.Aqua;

        public FormRevision1()
        {
            InitializeComponent();
        }

        public FormRevision1(Eleve _eleve): this()
        {
            this.eleve = _eleve;
            fillDataField();
        }

        private void fillDataField()
        {
            txtBoxName.Text= eleve.Name;
            txtBoxSurname.Text = eleve.Surname;
            dteNaissance.Value = eleve.DateNaissance;
            txtBoxParentName.Text = eleve.ParentName;
            txtBoxParentSurname.Text = eleve.ParentSurname;
            telOrange.Text = "691377930";
            radioFemale.Checked = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }
           
        }

        private bool isFormValid()
        {
            bool valid = true;

            string NumPattern="[0-9]";
            Regex regex = new Regex(NumPattern,
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

            if (string.IsNullOrEmpty(txtBoxName.Text )|| regex.IsMatch(txtBoxName.Text))
            {
                txtBoxName.BackColor = errorColor;
                valid = false;
            }

            if (string.IsNullOrEmpty(txtBoxSurname.Text) || regex.IsMatch(txtBoxSurname.Text))
            {
                txtBoxName.BackColor = errorColor;
                valid = false;
            }

            if (string.IsNullOrEmpty(txtBoxParentName.Text) || regex.IsMatch(txtBoxParentSurname.Text))
            {
                txtBoxName.BackColor = errorColor;
                valid = false;
            }
            return valid;
        }

        private void departmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.imsdbDataSet);

        }

        private void FormRevision1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'imsdbDataSet.department'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.departmentTableAdapter.Fill(this.imsdbDataSet.department);

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                //Action de demonstration
                MessageBox.Show("Eleve enregistre");
            }   
        }
    }
}
