using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas.components
{
    public class MtnPhoneTextBox : PhoneTextBox
    {
        

       static string mtnNumberPattern = @"651[0-9]{6}|67[0-9]{7}";

        Regex rx = new Regex(mtnNumberPattern,
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (rx.IsMatch(this.Text))
            {
                this.BackColor =this.colorSucces;
            }
            else
            {
                this.BackColor = colorError;
            }
            
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
        }

        /// <summary>
        /// Permet de dire si le numero entre est un numero mtn valide
        /// </summary>
        /// <returns></returns>
        public override bool IsPhoneNumberValid()
        {
            return rx.IsMatch(mtnNumberPattern);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MtnPhoneTextBox
            // 
            this.Mask = "00-00-00-00";
            this.Text = "  -  -  -";
            this.ResumeLayout(false);

        }
    }
}
