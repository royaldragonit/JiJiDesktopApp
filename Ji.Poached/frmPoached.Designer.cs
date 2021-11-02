namespace Ji.Poached
{
    partial class frmPoached
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
            this.ucPoached1 = new Ji.Poached.ucPoached();
            this.SuspendLayout();
            // 
            // ucPoached1
            // 
            this.ucPoached1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ucPoached1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPoached1.Location = new System.Drawing.Point(0, 0);
            this.ucPoached1.Name = "ucPoached1";
            this.ucPoached1.Size = new System.Drawing.Size(1314, 618);
            this.ucPoached1.TabIndex = 0;
            // 
            // frmPoached
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 617);
            this.Controls.Add(this.ucPoached1);
            this.Name = "frmPoached";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ucPoached ucPoached1;
    }
}

