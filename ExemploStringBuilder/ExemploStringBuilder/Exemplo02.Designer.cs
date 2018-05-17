namespace ExemploStringBuilder
{
    partial class Exemplo02
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
            this.txtProcessar = new System.Windows.Forms.TextBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProcessar
            // 
            this.txtProcessar.Location = new System.Drawing.Point(48, 21);
            this.txtProcessar.Multiline = true;
            this.txtProcessar.Name = "txtProcessar";
            this.txtProcessar.Size = new System.Drawing.Size(556, 385);
            this.txtProcessar.TabIndex = 0;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(637, 21);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(153, 362);
            this.btnProcessar.TabIndex = 1;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // Exemplo02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 439);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.txtProcessar);
            this.Name = "Exemplo02";
            this.Text = "Exemplo02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcessar;
        private System.Windows.Forms.Button btnProcessar;
    }
}