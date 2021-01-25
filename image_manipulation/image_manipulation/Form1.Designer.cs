namespace image_manipulation
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.actionsBox = new System.Windows.Forms.GroupBox();
            this.greenCheck = new System.Windows.Forms.CheckBox();
            this.redCheck = new System.Windows.Forms.CheckBox();
            this.blueCheck = new System.Windows.Forms.CheckBox();
            this.rotate90_rightCheck = new System.Windows.Forms.CheckBox();
            this.mirrorCheck = new System.Windows.Forms.CheckBox();
            this.invertCheck = new System.Windows.Forms.CheckBox();
            this.rotate90_leftCheck = new System.Windows.Forms.CheckBox();
            this.rotate180Check = new System.Windows.Forms.CheckBox();
            this.openButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.filenameStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.zoomBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.actionsBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.zoomBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // actionsBox
            // 
            this.actionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionsBox.Controls.Add(this.greenCheck);
            this.actionsBox.Controls.Add(this.redCheck);
            this.actionsBox.Controls.Add(this.blueCheck);
            this.actionsBox.Controls.Add(this.rotate90_rightCheck);
            this.actionsBox.Controls.Add(this.mirrorCheck);
            this.actionsBox.Controls.Add(this.invertCheck);
            this.actionsBox.Controls.Add(this.rotate90_leftCheck);
            this.actionsBox.Controls.Add(this.rotate180Check);
            this.actionsBox.Location = new System.Drawing.Point(454, 3);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(317, 220);
            this.actionsBox.TabIndex = 1;
            this.actionsBox.TabStop = false;
            this.actionsBox.Text = "Akcje";
            // 
            // greenCheck
            // 
            this.greenCheck.AutoSize = true;
            this.greenCheck.Enabled = false;
            this.greenCheck.Location = new System.Drawing.Point(6, 184);
            this.greenCheck.Name = "greenCheck";
            this.greenCheck.Size = new System.Drawing.Size(87, 17);
            this.greenCheck.TabIndex = 9;
            this.greenCheck.Text = "Tylko zielony";
            this.greenCheck.UseVisualStyleBackColor = true;
            this.greenCheck.Click += new System.EventHandler(this.greenCheck_Click);
            // 
            // redCheck
            // 
            this.redCheck.AutoSize = true;
            this.redCheck.Enabled = false;
            this.redCheck.Location = new System.Drawing.Point(6, 161);
            this.redCheck.Name = "redCheck";
            this.redCheck.Size = new System.Drawing.Size(100, 17);
            this.redCheck.TabIndex = 8;
            this.redCheck.Text = "Tylko czerwony";
            this.redCheck.UseVisualStyleBackColor = true;
            this.redCheck.Click += new System.EventHandler(this.redCheck_Click);
            // 
            // blueCheck
            // 
            this.blueCheck.AutoSize = true;
            this.blueCheck.Enabled = false;
            this.blueCheck.Location = new System.Drawing.Point(6, 138);
            this.blueCheck.Name = "blueCheck";
            this.blueCheck.Size = new System.Drawing.Size(96, 17);
            this.blueCheck.TabIndex = 7;
            this.blueCheck.Text = "Tylko niebieski";
            this.blueCheck.UseVisualStyleBackColor = true;
            this.blueCheck.Click += new System.EventHandler(this.blueCheck_Click);
            // 
            // rotate90_rightCheck
            // 
            this.rotate90_rightCheck.AutoSize = true;
            this.rotate90_rightCheck.Enabled = false;
            this.rotate90_rightCheck.Location = new System.Drawing.Point(6, 69);
            this.rotate90_rightCheck.Name = "rotate90_rightCheck";
            this.rotate90_rightCheck.Size = new System.Drawing.Size(113, 17);
            this.rotate90_rightCheck.TabIndex = 6;
            this.rotate90_rightCheck.Text = "Obróć 90 w prawo";
            this.rotate90_rightCheck.UseVisualStyleBackColor = true;
            this.rotate90_rightCheck.CheckedChanged += new System.EventHandler(this.rotate90_rightCheck_CheckedChanged);
            // 
            // mirrorCheck
            // 
            this.mirrorCheck.AutoSize = true;
            this.mirrorCheck.Enabled = false;
            this.mirrorCheck.Location = new System.Drawing.Point(6, 92);
            this.mirrorCheck.Name = "mirrorCheck";
            this.mirrorCheck.Size = new System.Drawing.Size(107, 17);
            this.mirrorCheck.TabIndex = 3;
            this.mirrorCheck.Text = "Odbicie lustrzane";
            this.mirrorCheck.UseVisualStyleBackColor = true;
            this.mirrorCheck.CheckedChanged += new System.EventHandler(this.mirrorCheck_CheckedChanged);
            // 
            // invertCheck
            // 
            this.invertCheck.AutoSize = true;
            this.invertCheck.Enabled = false;
            this.invertCheck.Location = new System.Drawing.Point(6, 115);
            this.invertCheck.Name = "invertCheck";
            this.invertCheck.Size = new System.Drawing.Size(94, 17);
            this.invertCheck.TabIndex = 2;
            this.invertCheck.Text = "Odwróć kolory";
            this.invertCheck.UseVisualStyleBackColor = true;
            this.invertCheck.CheckedChanged += new System.EventHandler(this.invertCheck_CheckedChanged);
            // 
            // rotate90_leftCheck
            // 
            this.rotate90_leftCheck.AutoSize = true;
            this.rotate90_leftCheck.Enabled = false;
            this.rotate90_leftCheck.Location = new System.Drawing.Point(6, 46);
            this.rotate90_leftCheck.Name = "rotate90_leftCheck";
            this.rotate90_leftCheck.Size = new System.Drawing.Size(106, 17);
            this.rotate90_leftCheck.TabIndex = 1;
            this.rotate90_leftCheck.Text = "Obróć 90 w lewo";
            this.rotate90_leftCheck.UseVisualStyleBackColor = true;
            this.rotate90_leftCheck.CheckedChanged += new System.EventHandler(this.rotate90_leftCheck_CheckedChanged);
            // 
            // rotate180Check
            // 
            this.rotate180Check.AutoSize = true;
            this.rotate180Check.Enabled = false;
            this.rotate180Check.Location = new System.Drawing.Point(6, 23);
            this.rotate180Check.Name = "rotate180Check";
            this.rotate180Check.Size = new System.Drawing.Size(85, 17);
            this.rotate180Check.TabIndex = 0;
            this.rotate180Check.Text = "Obróć o 180";
            this.rotate180Check.UseVisualStyleBackColor = true;
            this.rotate180Check.CheckedChanged += new System.EventHandler(this.rotate180Check_CheckedChanged);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(183, 25);
            this.openButton.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(109, 23);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Wczytaj";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(445, 415);
            this.panel1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filenameStrip,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(798, 22);
            this.statusStrip1.TabIndex = 1;
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
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(3, 16);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(302, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 500;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(25, 25);
            this.saveButton.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.Controls.Add(this.actionsBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 421);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.saveButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.openButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.zoomBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(454, 232);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(317, 146);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // zoomBox
            // 
            this.zoomBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.zoomBox, 2);
            this.zoomBox.Controls.Add(this.trackBar1);
            this.zoomBox.Location = new System.Drawing.Point(3, 76);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.Size = new System.Drawing.Size(311, 67);
            this.zoomBox.TabIndex = 4;
            this.zoomBox.TabStop = false;
            this.zoomBox.Text = "Zoom";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 456);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 470);
            this.Name = "Form1";
            this.Text = "Manipulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.actionsBox.ResumeLayout(false);
            this.actionsBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.zoomBox.ResumeLayout(false);
            this.zoomBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox actionsBox;
        private System.Windows.Forms.CheckBox mirrorCheck;
        private System.Windows.Forms.CheckBox invertCheck;
        private System.Windows.Forms.CheckBox rotate90_leftCheck;
        private System.Windows.Forms.CheckBox rotate180Check;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.CheckBox rotate90_rightCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox redCheck;
        private System.Windows.Forms.CheckBox blueCheck;
        private System.Windows.Forms.CheckBox greenCheck;
        private System.Windows.Forms.GroupBox zoomBox;
        private System.Windows.Forms.ToolStripStatusLabel filenameStrip;
    }
}

