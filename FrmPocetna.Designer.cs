namespace Zadaca_3
{
    partial class FrmPocetna
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.dgvPopis = new System.Windows.Forms.DataGridView();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnTrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(532, 639);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(146, 54);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos novog zahtjeva";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // dgvPopis
            // 
            this.dgvPopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopis.Location = new System.Drawing.Point(17, 24);
            this.dgvPopis.Name = "dgvPopis";
            this.dgvPopis.Size = new System.Drawing.Size(661, 492);
            this.dgvPopis.TabIndex = 2;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(17, 639);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(147, 52);
            this.btnBrisi.TabIndex = 6;
            this.btnBrisi.Text = "Izbriši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(532, 554);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(146, 52);
            this.btnTrazi.TabIndex = 7;
            this.btnTrazi.Text = "Pretraživanje";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 710);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.dgvPopis);
            this.Controls.Add(this.btnUnos);
            this.Name = "FrmPocetna";
            this.Text = "Popis zahtjeva za nabavu";
            this.Load += new System.EventHandler(this.FrmPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.DataGridView dgvPopis;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnTrazi;
    }
}