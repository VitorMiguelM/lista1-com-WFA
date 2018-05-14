namespace lista_1_com_WFA
{
    partial class Exercício03
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
            this.nupNumero01 = new System.Windows.Forms.NumericUpDown();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.nupNumero02 = new System.Windows.Forms.NumericUpDown();
            this.btnResultado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumero01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumero02)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(2, 23);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(386, 16);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Escolha dois numeros inteiros para ver as operações: ";
            // 
            // nupNumero01
            // 
            this.nupNumero01.Location = new System.Drawing.Point(86, 59);
            this.nupNumero01.Name = "nupNumero01";
            this.nupNumero01.Size = new System.Drawing.Size(120, 20);
            this.nupNumero01.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(123, 126);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(162, 231);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nupNumero02
            // 
            this.nupNumero02.Location = new System.Drawing.Point(221, 59);
            this.nupNumero02.Name = "nupNumero02";
            this.nupNumero02.Size = new System.Drawing.Size(120, 20);
            this.nupNumero02.TabIndex = 3;
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnResultado.ForeColor = System.Drawing.Color.Black;
            this.btnResultado.Location = new System.Drawing.Point(168, 85);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 35);
            this.btnResultado.TabIndex = 4;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Exercício03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 369);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.nupNumero02);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.nupNumero01);
            this.Controls.Add(this.lblEnunciado);
            this.Name = "Exercício03";
            this.Text = "Exercício03";
            ((System.ComponentModel.ISupportInitialize)(this.nupNumero01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumero02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.NumericUpDown nupNumero01;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.NumericUpDown nupNumero02;
        private System.Windows.Forms.Button btnResultado;
    }
}