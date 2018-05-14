namespace lista_1_com_WFA
{
    partial class Exercício02
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
            this.lblQuantidadeLitros = new System.Windows.Forms.Label();
            this.nupQuantidadeLitros = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidadeAnosConsumidos = new System.Windows.Forms.Label();
            this.lblValorPorLitro = new System.Windows.Forms.Label();
            this.nupQuantidadeAnosConsumidos = new System.Windows.Forms.NumericUpDown();
            this.mtbValorPorLitro = new System.Windows.Forms.MaskedTextBox();
            this.btnTestar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeLitros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeAnosConsumidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantidadeLitros
            // 
            this.lblQuantidadeLitros.AutoSize = true;
            this.lblQuantidadeLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeLitros.Location = new System.Drawing.Point(12, 106);
            this.lblQuantidadeLitros.Name = "lblQuantidadeLitros";
            this.lblQuantidadeLitros.Size = new System.Drawing.Size(182, 20);
            this.lblQuantidadeLitros.TabIndex = 0;
            this.lblQuantidadeLitros.Text = "Quantidade de Litros:";
            // 
            // nupQuantidadeLitros
            // 
            this.nupQuantidadeLitros.Location = new System.Drawing.Point(301, 109);
            this.nupQuantidadeLitros.Name = "nupQuantidadeLitros";
            this.nupQuantidadeLitros.Size = new System.Drawing.Size(120, 20);
            this.nupQuantidadeLitros.TabIndex = 1;
            // 
            // lblQuantidadeAnosConsumidos
            // 
            this.lblQuantidadeAnosConsumidos.AutoSize = true;
            this.lblQuantidadeAnosConsumidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeAnosConsumidos.Location = new System.Drawing.Point(12, 164);
            this.lblQuantidadeAnosConsumidos.Name = "lblQuantidadeAnosConsumidos";
            this.lblQuantidadeAnosConsumidos.Size = new System.Drawing.Size(281, 20);
            this.lblQuantidadeAnosConsumidos.TabIndex = 2;
            this.lblQuantidadeAnosConsumidos.Text = "Quantidade de Anos Consumidos:";
            this.lblQuantidadeAnosConsumidos.Click += new System.EventHandler(this.lblQuantidadeAnosConsumidos_Click);
            // 
            // lblValorPorLitro
            // 
            this.lblValorPorLitro.AutoSize = true;
            this.lblValorPorLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPorLitro.Location = new System.Drawing.Point(12, 209);
            this.lblValorPorLitro.Name = "lblValorPorLitro";
            this.lblValorPorLitro.Size = new System.Drawing.Size(122, 20);
            this.lblValorPorLitro.TabIndex = 3;
            this.lblValorPorLitro.Text = "Valor por litro:";
            // 
            // nupQuantidadeAnosConsumidos
            // 
            this.nupQuantidadeAnosConsumidos.Location = new System.Drawing.Point(301, 167);
            this.nupQuantidadeAnosConsumidos.Name = "nupQuantidadeAnosConsumidos";
            this.nupQuantidadeAnosConsumidos.Size = new System.Drawing.Size(120, 20);
            this.nupQuantidadeAnosConsumidos.TabIndex = 7;
            // 
            // mtbValorPorLitro
            // 
            this.mtbValorPorLitro.Location = new System.Drawing.Point(301, 211);
            this.mtbValorPorLitro.Mask = "00.00";
            this.mtbValorPorLitro.Name = "mtbValorPorLitro";
            this.mtbValorPorLitro.Size = new System.Drawing.Size(34, 20);
            this.mtbValorPorLitro.TabIndex = 8;
            // 
            // btnTestar
            // 
            this.btnTestar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTestar.Location = new System.Drawing.Point(377, 387);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(93, 40);
            this.btnTestar.TabIndex = 11;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = false;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(114, 291);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(274, 78);
            this.txtResultado.TabIndex = 12;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 309);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(96, 20);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "Resultado:";
            // 
            // Exercício02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 439);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.mtbValorPorLitro);
            this.Controls.Add(this.nupQuantidadeAnosConsumidos);
            this.Controls.Add(this.lblValorPorLitro);
            this.Controls.Add(this.lblQuantidadeAnosConsumidos);
            this.Controls.Add(this.nupQuantidadeLitros);
            this.Controls.Add(this.lblQuantidadeLitros);
            this.Name = "Exercício02";
            this.Text = "Exercício02";
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeLitros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeAnosConsumidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantidadeLitros;
        private System.Windows.Forms.NumericUpDown nupQuantidadeLitros;
        private System.Windows.Forms.Label lblQuantidadeAnosConsumidos;
        private System.Windows.Forms.Label lblValorPorLitro;
        private System.Windows.Forms.NumericUpDown nupQuantidadeAnosConsumidos;
        private System.Windows.Forms.MaskedTextBox mtbValorPorLitro;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}