namespace pc_shop
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.newTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.monitorButton = new System.Windows.Forms.Button();
            this.computerButton = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.RichTextBox();
            this.updateTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.monitor_updateButton = new System.Windows.Forms.Button();
            this.cpu_updateButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.newTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.updateTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.newTab);
            this.tabControl.Controls.Add(this.updateTab);
            this.tabControl.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(424, 315);
            this.tabControl.TabIndex = 0;
            // 
            // newTab
            // 
            this.newTab.Controls.Add(this.tableLayoutPanel2);
            this.newTab.Location = new System.Drawing.Point(4, 24);
            this.newTab.Name = "newTab";
            this.newTab.Padding = new System.Windows.Forms.Padding(3);
            this.newTab.Size = new System.Drawing.Size(416, 287);
            this.newTab.TabIndex = 0;
            this.newTab.Text = "Nowy";
            this.newTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.priceLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.monitorButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.computerButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.priceBox, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.2943F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.7057F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(416, 291);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceLabel.Location = new System.Drawing.Point(301, 115);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 15);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Cena:";
            // 
            // monitorButton
            // 
            this.monitorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.monitorButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monitorButton.Location = new System.Drawing.Point(163, 133);
            this.monitorButton.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.monitorButton.Name = "monitorButton";
            this.monitorButton.Size = new System.Drawing.Size(88, 23);
            this.monitorButton.TabIndex = 2;
            this.monitorButton.Text = "Monitor";
            this.monitorButton.UseVisualStyleBackColor = true;
            this.monitorButton.Click += new System.EventHandler(this.monitorButton_Click);
            // 
            // computerButton
            // 
            this.computerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.computerButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computerButton.Location = new System.Drawing.Point(25, 133);
            this.computerButton.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.computerButton.Name = "computerButton";
            this.computerButton.Size = new System.Drawing.Size(88, 23);
            this.computerButton.TabIndex = 1;
            this.computerButton.Text = "Komputer";
            this.computerButton.UseVisualStyleBackColor = true;
            this.computerButton.Click += new System.EventHandler(this.computerButton_Click);
            // 
            // priceBox
            // 
            this.priceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.priceBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceBox.HideSelection = false;
            this.priceBox.Location = new System.Drawing.Point(301, 133);
            this.priceBox.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(90, 23);
            this.priceBox.TabIndex = 3;
            this.priceBox.Text = "";
            // 
            // updateTab
            // 
            this.updateTab.Controls.Add(this.tableLayoutPanel1);
            this.updateTab.Location = new System.Drawing.Point(4, 24);
            this.updateTab.Name = "updateTab";
            this.updateTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateTab.Size = new System.Drawing.Size(416, 287);
            this.updateTab.TabIndex = 1;
            this.updateTab.Text = "Aktualizacja danych";
            this.updateTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.monitor_updateButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cpu_updateButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 289);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // monitor_updateButton
            // 
            this.monitor_updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monitor_updateButton.Location = new System.Drawing.Point(262, 133);
            this.monitor_updateButton.Name = "monitor_updateButton";
            this.monitor_updateButton.Size = new System.Drawing.Size(100, 23);
            this.monitor_updateButton.TabIndex = 1;
            this.monitor_updateButton.Text = "Monitor";
            this.monitor_updateButton.UseVisualStyleBackColor = true;
            this.monitor_updateButton.Click += new System.EventHandler(this.monitor_updateButton_Click);
            // 
            // cpu_updateButton
            // 
            this.cpu_updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpu_updateButton.Location = new System.Drawing.Point(54, 133);
            this.cpu_updateButton.Name = "cpu_updateButton";
            this.cpu_updateButton.Size = new System.Drawing.Size(100, 23);
            this.cpu_updateButton.TabIndex = 0;
            this.cpu_updateButton.Text = "Procesor";
            this.cpu_updateButton.UseVisualStyleBackColor = true;
            this.cpu_updateButton.Click += new System.EventHandler(this.cpu_updateButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 339);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "MainWindow";
            this.Text = "Kalkulator zestawów komputerowych";
            this.tabControl.ResumeLayout(false);
            this.newTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.updateTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage newTab;
        private System.Windows.Forms.TabPage updateTab;
        private System.Windows.Forms.RichTextBox priceBox;
        private System.Windows.Forms.Button monitorButton;
        private System.Windows.Forms.Button computerButton;
        private System.Windows.Forms.Button monitor_updateButton;
        private System.Windows.Forms.Button cpu_updateButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

