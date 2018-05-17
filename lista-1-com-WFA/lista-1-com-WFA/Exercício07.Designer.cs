namespace lista_1_com_WFA
{
    partial class Exercício07
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMagica = new System.Windows.Forms.Button();
            this.txtMagica = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clique no botão para ver a mágica";
            // 
            // btnMagica
            // 
            this.btnMagica.BackColor = System.Drawing.Color.DarkGray;
            this.btnMagica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagica.Location = new System.Drawing.Point(132, 82);
            this.btnMagica.Name = "btnMagica";
            this.btnMagica.Size = new System.Drawing.Size(126, 41);
            this.btnMagica.TabIndex = 1;
            this.btnMagica.Text = "Ver a mágica";
            this.btnMagica.UseVisualStyleBackColor = false;
            this.btnMagica.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMagica
            // 
            this.txtMagica.BackColor = System.Drawing.Color.DarkGray;
            this.txtMagica.Location = new System.Drawing.Point(144, 129);
            this.txtMagica.Multiline = true;
            this.txtMagica.Name = "txtMagica";
            this.txtMagica.Size = new System.Drawing.Size(100, 88);
            this.txtMagica.TabIndex = 2;
            this.txtMagica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMagica.TextChanged += new System.EventHandler(this.txtMagica_TextChanged);
            // 
            // Exercício07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lista_1_com_WFA.Properties.Resources.ssssssss;
            this.ClientSize = new System.Drawing.Size(379, 248);
            this.Controls.Add(this.txtMagica);
            this.Controls.Add(this.btnMagica);
            this.Controls.Add(this.label1);
            this.Name = "Exercício07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício07";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMagica;
        private System.Windows.Forms.TextBox txtMagica;
    }
}