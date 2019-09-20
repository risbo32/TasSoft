using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas.components
{
    /// <summary>
    /// TextBox pour les numeros Orange
    /// </summary>
    public class OrangePhoneTextBox : PhoneTextBox
    {
        static string numberPattern = @"655[0-9]{6}|69[0-9]{7}";
        Regex rx = new Regex(numberPattern,
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (rx.IsMatch(this.Text))
            {
                this.BackColor = this.colorSucces;
            }
            else
            {
                this.BackColor = colorError;
            }
        }

        public override bool IsPhoneNumberValid()
        {
            return rx.IsMatch(numberPattern);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // OrangePhoneTextBox
            // 
            this.Mask = "00-00-00-00";
            this.Text = "  -  -  -";
            this.ResumeLayout(false);

        }
    }
}
