namespace _03_gerador_senhas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPass = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.numChars = new System.Windows.Forms.NumericUpDown();
            this.checkUpper = new System.Windows.Forms.CheckBox();
            this.checkNum = new System.Windows.Forms.CheckBox();
            this.checkSym = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numChars)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPass
            // 
            this.lstPass.FormattingEnabled = true;
            this.lstPass.Location = new System.Drawing.Point(10, 12);
            this.lstPass.Name = "lstPass";
            this.lstPass.Size = new System.Drawing.Size(182, 251);
            this.lstPass.TabIndex = 0;
            this.lstPass.SelectedValueChanged += new System.EventHandler(this.lstPass_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº chars:";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(198, 220);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(139, 42);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "GERAR SENHAS";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // numChars
            // 
            this.numChars.Location = new System.Drawing.Point(200, 31);
            this.numChars.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numChars.Name = "numChars";
            this.numChars.Size = new System.Drawing.Size(96, 20);
            this.numChars.TabIndex = 3;
            this.numChars.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // checkUpper
            // 
            this.checkUpper.AutoSize = true;
            this.checkUpper.Location = new System.Drawing.Point(200, 69);
            this.checkUpper.Name = "checkUpper";
            this.checkUpper.Size = new System.Drawing.Size(129, 17);
            this.checkUpper.TabIndex = 4;
            this.checkUpper.Text = "Utilizar MAIÚSCULAS";
            this.checkUpper.UseVisualStyleBackColor = true;
            // 
            // checkNum
            // 
            this.checkNum.AutoSize = true;
            this.checkNum.Location = new System.Drawing.Point(201, 92);
            this.checkNum.Name = "checkNum";
            this.checkNum.Size = new System.Drawing.Size(100, 17);
            this.checkNum.TabIndex = 5;
            this.checkNum.Text = "Utilizar núm3r0s";
            this.checkNum.UseVisualStyleBackColor = true;
            // 
            // checkSym
            // 
            this.checkSym.AutoSize = true;
            this.checkSym.Location = new System.Drawing.Point(200, 115);
            this.checkSym.Name = "checkSym";
            this.checkSym.Size = new System.Drawing.Size(102, 17);
            this.checkSym.TabIndex = 6;
            this.checkSym.Text = "Utilizar s!mbo!os";
            this.checkSym.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(198, 156);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copiar";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 274);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.checkSym);
            this.Controls.Add(this.checkNum);
            this.Controls.Add(this.checkUpper);
            this.Controls.Add(this.numChars);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPass);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Senhas";
            ((System.ComponentModel.ISupportInitialize)(this.numChars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.NumericUpDown numChars;
        private System.Windows.Forms.CheckBox checkUpper;
        private System.Windows.Forms.CheckBox checkNum;
        private System.Windows.Forms.CheckBox checkSym;
        private System.Windows.Forms.Button btnCopy;
    }
}

