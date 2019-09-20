namespace SoftwareTas
{
    partial class FormTaskInProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prgrssBar = new System.Windows.Forms.ProgressBar();
            this.lblProgess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prgrssBar
            // 
            this.prgrssBar.Location = new System.Drawing.Point(53, 54);
            this.prgrssBar.Name = "prgrssBar";
            this.prgrssBar.Size = new System.Drawing.Size(366, 23);
            this.prgrssBar.Step = 1;
            this.prgrssBar.TabIndex = 0;
            this.prgrssBar.Value = 10;
            // 
            // lblProgess
            // 
            this.lblProgess.AutoSize = true;
            this.lblProgess.Location = new System.Drawing.Point(227, 32);
            this.lblProgess.Name = "lblProgess";
            this.lblProgess.Size = new System.Drawing.Size(35, 13);
            this.lblProgess.TabIndex = 1;
            this.lblProgess.Text = "label1";
            // 
            // FormTaskInProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 114);
            this.Controls.Add(this.lblProgess);
            this.Controls.Add(this.prgrssBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTaskInProgress";
            this.ShowInTaskbar = false;
            this.Text = "Taches en arriere plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgrssBar;
        private System.Windows.Forms.Label lblProgess;
    }
}