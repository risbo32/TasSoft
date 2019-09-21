using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas.components
{
   public class CamtelPhoneTextBox: PhoneTextBox
    {
        static string mtnNumberPattern = @"33-[0-9]{2}-[0-9]{2}-[0-9]{2}|22[0-9]-[0-9]{2}-[0-9]{2}-[0-9]{2}";

        Regex rx = new Regex(mtnNumberPattern,
          RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public CamtelPhoneTextBox() : base()
        {
            this.Mask = @"000-00-00-00";
        }


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
            return rx.IsMatch(mtnNumberPattern);
        }


    }
}
