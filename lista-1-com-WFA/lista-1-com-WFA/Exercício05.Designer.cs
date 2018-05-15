namespace lista_1_com_WFA
{
    partial class Exercício05
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeDoCarro = new System.Windows.Forms.TextBox();
            this.mtbValorDoCarro = new System.Windows.Forms.MaskedTextBox();
            this.mtbValorDeCadaParcela = new System.Windows.Forms.MaskedTextBox();
            this.nupQuantidadeDeParcelas = new System.Windows.Forms.NumericUpDown();
            this.btnResultado = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeDeParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do carro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor do carro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de cada parcela:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade de parcelas:";
            // 
            // txtNomeDoCarro
            // 
            this.txtNomeDoCarro.Location = new System.Drawing.Point(133, 25);
            this.txtNomeDoCarro.Name = "txtNomeDoCarro";
            this.txtNomeDoCarro.Size = new System.Drawing.Size(181, 20);
            this.txtNomeDoCarro.TabIndex = 4;
            // 
            // mtbValorDoCarro
            // 
            this.mtbValorDoCarro.Location = new System.Drawing.Point(133, 64);
            this.mtbValorDoCarro.Mask = "000.000.00";
            this.mtbValorDoCarro.Name = "mtbValorDoCarro";
            this.mtbValorDoCarro.Size = new System.Drawing.Size(58, 20);
            this.mtbValorDoCarro.TabIndex = 5;
            // 
            // mtbValorDeCadaParcela
            // 
            this.mtbValorDeCadaParcela.Location = new System.Drawing.Point(185, 109);
            this.mtbValorDeCadaParcela.Mask = "00.000";
            this.mtbValorDeCadaParcela.Name = "mtbValorDeCadaParcela";
            this.mtbValorDeCadaParcela.Size = new System.Drawing.Size(40, 20);
            this.mtbValorDeCadaParcela.TabIndex = 6;
            // 
            // nupQuantidadeDeParcelas
            // 
            this.nupQuantidadeDeParcelas.Location = new System.Drawing.Point(198, 144);
            this.nupQuantidadeDeParcelas.Name = "nupQuantidadeDeParcelas";
            this.nupQuantidadeDeParcelas.Size = new System.Drawing.Size(43, 20);
            this.nupQuantidadeDeParcelas.TabIndex = 7;
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnResultado.ForeColor = System.Drawing.Color.Black;
            this.btnResultado.Location = new System.Drawing.Point(133, 189);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 8;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(69, 218);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(201, 108);
            this.txtResultado.TabIndex = 9;
            // 
            // Exercício05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 354);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.nupQuantidadeDeParcelas);
            this.Controls.Add(this.mtbValorDeCadaParcela);
            this.Controls.Add(this.mtbValorDoCarro);
            this.Controls.Add(this.txtNomeDoCarro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exercício05";
            this.Text = "Exercício05";
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeDeParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeDoCarro;
        private System.Windows.Forms.MaskedTextBox mtbValorDoCarro;
        private System.Windows.Forms.MaskedTextBox mtbValorDeCadaParcela;
        private System.Windows.Forms.NumericUpDown nupQuantidadeDeParcelas;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}