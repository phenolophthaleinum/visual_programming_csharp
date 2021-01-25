namespace excel_reader
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadButton = new System.Windows.Forms.Button();
            this.showTable = new System.Windows.Forms.Button();
            this.showChart = new System.Windows.Forms.Button();
            this.sheetCombo = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.filenameStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(95, 49);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(105, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Wczytaj arkusz";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // showTable
            // 
            this.showTable.Enabled = false;
            this.showTable.Location = new System.Drawing.Point(95, 78);
            this.showTable.Name = "showTable";
            this.showTable.Size = new System.Drawing.Size(105, 23);
            this.showTable.TabIndex = 1;
            this.showTable.Text = "Pokaż arkusz";
            this.showTable.UseVisualStyleBackColor = true;
            this.showTable.Click += new System.EventHandler(this.showTable_Click);
            // 
            // showChart
            // 
            this.showChart.Enabled = false;
            this.showChart.Location = new System.Drawing.Point(95, 107);
            this.showChart.Name = "showChart";
            this.showChart.Size = new System.Drawing.Size(105, 23);
            this.showChart.TabIndex = 2;
            this.showChart.Text = "Pokaż wykres";
            this.showChart.UseVisualStyleBackColor = true;
            this.showChart.Click += new System.EventHandler(this.showChart_Click);
            // 
            // sheetCombo
            // 
            this.sheetCombo.FormattingEnabled = true;
            this.sheetCombo.Location = new System.Drawing.Point(206, 51);
            this.sheetCombo.Name = "sheetCombo";
            this.sheetCombo.Size = new System.Drawing.Size(121, 21);
            this.sheetCombo.TabIndex = 3;
            this.sheetCombo.SelectedIndexChanged += new System.EventHandler(this.sheetCombo_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filenameStrip});
            this.statusStrip1.Location = new System.Drawing.Point(1, 179);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(404, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // filenameStrip
            // 
            this.filenameStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filenameStrip.Name = "filenameStrip";
            this.filenameStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filenameStrip.Size = new System.Drawing.Size(48, 17);
            this.filenameStrip.Text = "Gotowy";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 201);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.sheetCombo);
            this.Controls.Add(this.showChart);
            this.Controls.Add(this.showTable);
            this.Controls.Add(this.loadButton);
            this.MaximumSize = new System.Drawing.Size(420, 240);
            this.MinimumSize = new System.Drawing.Size(420, 240);
            this.Name = "MainWindow";
            this.Text = "Czytnik Excela";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button showTable;
        private System.Windows.Forms.Button showChart;
        private System.Windows.Forms.ComboBox sheetCombo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel filenameStrip;
    }
}

