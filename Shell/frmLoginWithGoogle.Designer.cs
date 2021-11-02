namespace Shell
{
    partial class frmLoginWithGoogle
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
            this.dragonComboBoox1 = new Ji.Controls.DragonComboBoox();
            this.SuspendLayout();
            // 
            // dragonComboBoox1
            // 
            this.dragonComboBoox1.Location = new System.Drawing.Point(132, 47);
            this.dragonComboBoox1.Name = "dragonComboBoox1";
            this.dragonComboBoox1.Size = new System.Drawing.Size(509, 306);
            this.dragonComboBoox1.TabIndex = 0;
            // 
            // frmLoginWithGoogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dragonComboBoox1);
            this.Name = "frmLoginWithGoogle";
            this.Text = "Đăng nhập với Google";
            this.ResumeLayout(false);

        }

        #endregion

        private Ji.Controls.DragonComboBoox dragonComboBoox1;
    }
}