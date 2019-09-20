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
    public partial class FormRevision1 : Form
    {
        public FormRevision1()
        {
            InitializeComponent();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }
            else
            {
                if (textBox6.Text.Length < 10)
                {
                  
                }
                else
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                        MessageBox.Show("Texte trop long");
                    }
                }
            }

        }
            
    }
}
