using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas.components
{
    /// <summary>
    /// TextBox pour les numeros Orange
    /// </summary>
    public class OrangePhoneTextBox : PhoneTextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }
    }
}
