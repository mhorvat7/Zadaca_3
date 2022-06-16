namespace Zadaca_3
{
    partial class FrmPocetnaOdobrenje
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
            this.dgvPopisOdo = new System.Windows.Forms.DataGridView();
            this.btnUnosOdo = new System.Windows.Forms.Button();
            this.btnBrisiOdo = new System.Windows.Forms.Button();
            this.cboPocetnaOdo = new System.Windows.Forms.ComboBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnTraziOdo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisOdo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisOdo
            // 
            this.dgvPopisOdo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisOdo.Location = new System.Drawing.Point(12, 12);
            this.dgvPopisOdo.Name = "dgvPopisOdo";
            this.dgvPopisOdo.Size = new System.Drawing.Size(695, 492);
            this.dgvPopisOdo.TabIndex = 3;
            // 
            // btnUnosOdo
            // 
            this.btnUnosOdo.Location = new System.Drawing.Point(564, 615);
            this.btnUnosOdo.Name = "btnUnosOdo";
            this.btnUnosOdo.Size = new System.Drawing.Size(143, 56);
            this.btnUnosOdo.TabIndex = 4;
            this.btnUnosOdo.Text = "Unos novog zahtjeva";
            this.btnUnosOdo.UseVisualStyleBackColor = true;
            this.btnUnosOdo.Click += new System.EventHandler(this.btnUnosOdo_Click);
            // 
            // btnBrisiOdo
            // 
            this.btnBrisiOdo.Location = new System.Drawing.Point(12, 615);
            this.btnBrisiOdo.Name = "btnBrisiOdo";
            this.btnBrisiOdo.Size = new System.Drawing.Size(143, 56);
            this.btnBrisiOdo.TabIndex = 5;
            this.btnBrisiOdo.Text = "Izbriši";
            this.btnBrisiOdo.UseVisualStyleBackColor = true;
            this.btnBrisiOdo.Click += new System.EventHandler(this.btnBrisiOdo_Click);
            // 
            // cboPocetnaOdo
            // 
            this.cboPocetnaOdo.FormattingEnabled = true;
            this.cboPocetnaOdo.Items.AddRange(new object[] {
            "Odobri",
            "Odbij"});
            this.cboPocetnaOdo.Location = new System.Drawing.Point(250, 535);
            this.cboPocetnaOdo.Name = "cboPocetnaOdo";
            this.cboPocetnaOdo.Size = new System.Drawing.Size(227, 21);
            this.cboPocetnaOdo.TabIndex = 6;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(294, 615);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(143, 56);
            this.btnStatus.TabIndex = 7;
            this.btnStatus.Text = "Promijeni status";
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnTraziOdo
            // 
            this.btnTraziOdo.Location = new System.Drawing.Point(564, 535);
            this.btnTraziOdo.Name = "btnTraziOdo";
            this.btnTraziOdo.Size = new System.Drawing.Size(143, 52);
            this.btnTraziOdo.TabIndex = 8;
            this.btnTraziOdo.Text = "Pretraživanje";
            this.btnTraziOdo.UseVisualStyleBackColor = true;
            this.btnTraziOdo.Click += new System.EventHandler(this.btnTraziOdo_Click);
            // 
            // FrmPocetnaOdobrenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 683);
            this.Controls.Add(this.btnTraziOdo);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.cboPocetnaOdo);
            this.Controls.Add(this.btnBrisiOdo);
            this.Controls.Add(this.btnUnosOdo);
            this.Controls.Add(this.dgvPopisOdo);
            this.Name = "FrmPocetnaOdobrenje";
            this.Text = "FrmPocetnaOdobrenje";
            this.Load += new System.EventHandler(this.FrmPocetnaOdobrenje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisOdo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisOdo;
        private System.Windows.Forms.Button btnUnosOdo;
        private System.Windows.Forms.Button btnBrisiOdo;
        private System.Windows.Forms.ComboBox cboPocetnaOdo;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnTraziOdo;
    }
}