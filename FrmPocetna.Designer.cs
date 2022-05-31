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
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvPopis = new System.Windows.Forms.DataGridView();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnUredivanje = new System.Windows.Forms.Button();
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
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(356, 639);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(144, 54);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Generiranje izvještaja";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // dgvPopis
            // 
            this.dgvPopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopis.Location = new System.Drawing.Point(17, 24);
            this.dgvPopis.Name = "dgvPopis";
            this.dgvPopis.Size = new System.Drawing.Size(661, 492);
            this.dgvPopis.TabIndex = 2;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(13, 639);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(137, 53);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "Uredi status zahtjeva";
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnUredivanje
            // 
            this.btnUredivanje.Location = new System.Drawing.Point(188, 639);
            this.btnUredivanje.Name = "btnUredivanje";
            this.btnUredivanje.Size = new System.Drawing.Size(137, 53);
            this.btnUredivanje.TabIndex = 4;
            this.btnUredivanje.Text = "Uredi zahtjev";
            this.btnUredivanje.UseVisualStyleBackColor = true;
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 710);
            this.Controls.Add(this.btnUredivanje);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.dgvPopis);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnUnos);
            this.Name = "FrmPocetna";
            this.Text = "Popis zahtjeva za nabavu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dgvPopis;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnUredivanje;
    }
}