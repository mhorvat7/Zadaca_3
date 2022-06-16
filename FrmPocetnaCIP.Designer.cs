namespace Zadaca_3
{
    partial class FrmPocetnaCIP
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
            this.dgvPopisCIP = new System.Windows.Forms.DataGridView();
            this.btnBrisiCIP = new System.Windows.Forms.Button();
            this.btnUnosCIP = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.btnTraziCIP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisCIP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisCIP
            // 
            this.dgvPopisCIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisCIP.Location = new System.Drawing.Point(17, 20);
            this.dgvPopisCIP.Name = "dgvPopisCIP";
            this.dgvPopisCIP.Size = new System.Drawing.Size(672, 413);
            this.dgvPopisCIP.TabIndex = 0;
            // 
            // btnBrisiCIP
            // 
            this.btnBrisiCIP.Location = new System.Drawing.Point(12, 599);
            this.btnBrisiCIP.Name = "btnBrisiCIP";
            this.btnBrisiCIP.Size = new System.Drawing.Size(138, 52);
            this.btnBrisiCIP.TabIndex = 1;
            this.btnBrisiCIP.Text = "Izbriši";
            this.btnBrisiCIP.UseVisualStyleBackColor = true;
            this.btnBrisiCIP.Click += new System.EventHandler(this.btnBrisiCIP_Click);
            // 
            // btnUnosCIP
            // 
            this.btnUnosCIP.Location = new System.Drawing.Point(551, 599);
            this.btnUnosCIP.Name = "btnUnosCIP";
            this.btnUnosCIP.Size = new System.Drawing.Size(138, 52);
            this.btnUnosCIP.TabIndex = 2;
            this.btnUnosCIP.Text = "Unos novog zahtjeva";
            this.btnUnosCIP.UseVisualStyleBackColor = true;
            this.btnUnosCIP.Click += new System.EventHandler(this.btnUnosCIP_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(280, 599);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(138, 52);
            this.btnIzvjestaj.TabIndex = 3;
            this.btnIzvjestaj.Text = "Generiraj izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            // 
            // btnTraziCIP
            // 
            this.btnTraziCIP.Location = new System.Drawing.Point(551, 511);
            this.btnTraziCIP.Name = "btnTraziCIP";
            this.btnTraziCIP.Size = new System.Drawing.Size(137, 52);
            this.btnTraziCIP.TabIndex = 4;
            this.btnTraziCIP.Text = "Pretraživanje";
            this.btnTraziCIP.UseVisualStyleBackColor = true;
            this.btnTraziCIP.Click += new System.EventHandler(this.btnTraziCIP_Click);
            // 
            // FrmPocetnaCIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 663);
            this.Controls.Add(this.btnTraziCIP);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.btnUnosCIP);
            this.Controls.Add(this.btnBrisiCIP);
            this.Controls.Add(this.dgvPopisCIP);
            this.Name = "FrmPocetnaCIP";
            this.Text = "FrmPocetnaCIP";
            this.Load += new System.EventHandler(this.FrmPocetnaCIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisCIP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisCIP;
        private System.Windows.Forms.Button btnBrisiCIP;
        private System.Windows.Forms.Button btnUnosCIP;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.Button btnTraziCIP;
    }
}