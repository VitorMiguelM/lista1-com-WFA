namespace lista_1_com_WFA
{
    partial class Exercício01
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
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cbSucessor = new System.Windows.Forms.CheckBox();
            this.cbAntecessor = new System.Windows.Forms.CheckBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.BackColor = System.Drawing.Color.Transparent;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(12, 9);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(430, 20);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Digite um número e escolha uma das opções abaixo:";
            this.lblEnunciado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEnunciado.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(12, 65);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(66, 16);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número:";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(101, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // cbSucessor
            // 
            this.cbSucessor.AutoSize = true;
            this.cbSucessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSucessor.Location = new System.Drawing.Point(225, 65);
            this.cbSucessor.Name = "cbSucessor";
            this.cbSucessor.Size = new System.Drawing.Size(92, 20);
            this.cbSucessor.TabIndex = 3;
            this.cbSucessor.Text = "Sucessor";
            this.cbSucessor.UseVisualStyleBackColor = true;
            // 
            // cbAntecessor
            // 
            this.cbAntecessor.AutoSize = true;
            this.cbAntecessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAntecessor.Location = new System.Drawing.Point(333, 67);
            this.cbAntecessor.Name = "cbAntecessor";
            this.cbAntecessor.Size = new System.Drawing.Size(105, 20);
            this.cbAntecessor.TabIndex = 4;
            this.cbAntecessor.Text = "Antecessor";
            this.cbAntecessor.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(101, 108);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 49);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 128);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(83, 16);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // Exercício01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 196);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.cbAntecessor);
            this.Controls.Add(this.cbSucessor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEnunciado);
            this.Name = "Exercício01";
            this.Text = "Exercício01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.CheckBox cbSucessor;
        private System.Windows.Forms.CheckBox cbAntecessor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}