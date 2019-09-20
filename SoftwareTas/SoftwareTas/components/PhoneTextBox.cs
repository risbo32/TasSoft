using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas.components
{
    public class PhoneTextBox : TextBox
    {
        private int MaxLengthPhone = 10;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("S'il vous plait, seulement des chiffres");
              
                e.Handled = true;
            }
            if (this.Text.Length > MaxLengthPhone)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    MessageBox.Show("Longeur maxi 10 chiffres");
                    e.Handled = true;
                }
            }
        }

    }
}
