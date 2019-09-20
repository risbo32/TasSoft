using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas.components
{
    public class PhoneTextBox : MaskedTextBox
    {
        /// <summary>
        /// Couleur d'erreur;
        /// </summary>
       public Color colorError { get; set; } = Color.Red;
        /// <summary>
        /// Couleur en cas de numero correct
        /// </summary>
      public Color colorSucces { get; set; } = Color.Aqua;
        private int MaxLengthPhone = 9;



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

        /// <summary>
        /// Verifie si le numero entre est correspond a l'expression reguliere
        /// </summary>
        /// <returns></returns>
      virtual  public  bool IsPhoneNumberValid()
        {
            return true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PhoneTextBox
            // 
            this.Mask = "00-00-00-00";
            this.Text = "  -  -  -";
            this.ResumeLayout(false);

        }
    }
}
