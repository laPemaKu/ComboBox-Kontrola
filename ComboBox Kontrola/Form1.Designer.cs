namespace ComboBox_Kontrola
{
    partial class Form1
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
            this.cbbOdabir = new System.Windows.Forms.ComboBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbbOdabir
            // 
            this.cbbOdabir.FormattingEnabled = true;
            this.cbbOdabir.Items.AddRange(new object[] {
            "1D",
            "1E",
            "2D",
            "3D",
            "4D"});
            this.cbbOdabir.Location = new System.Drawing.Point(43, 48);
            this.cbbOdabir.Name = "cbbOdabir";
            this.cbbOdabir.Size = new System.Drawing.Size(121, 21);
            this.cbbOdabir.TabIndex = 0;
            this.cbbOdabir.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(43, 93);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.ReadOnly = true;
            this.txtRezultat.Size = new System.Drawing.Size(121, 20);
            this.txtRezultat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.cbbOdabir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbOdabir;
        private System.Windows.Forms.TextBox txtRezultat;
    }
}

