namespace SuperMarket2
{
    partial class Form2
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
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.Location = new System.Drawing.Point(57, 55);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(95, 45);
            this.BtnSignIn.TabIndex = 0;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = true;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click_1);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(57, 106);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(95, 45);
            this.BtnRegister.TabIndex = 1;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 202);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnSignIn);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SuperMarket";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Button BtnRegister;
    }
}