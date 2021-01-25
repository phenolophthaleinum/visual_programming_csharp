namespace TranslateSeqApp
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.translateButton = new System.Windows.Forms.Button();
            this.seqBox = new System.Windows.Forms.RichTextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.exampleButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sekwencja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(62, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wynik";
            // 
            // translateButton
            // 
            this.translateButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.translateButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.translateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.translateButton.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.translateButton.Location = new System.Drawing.Point(431, 113);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(111, 28);
            this.translateButton.TabIndex = 5;
            this.translateButton.Text = "Translacja";
            this.translateButton.UseVisualStyleBackColor = false;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // seqBox
            // 
            this.seqBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seqBox.Location = new System.Drawing.Point(66, 34);
            this.seqBox.Name = "seqBox";
            this.seqBox.Size = new System.Drawing.Size(476, 76);
            this.seqBox.TabIndex = 6;
            this.seqBox.Text = "";
            this.seqBox.Enter += new System.EventHandler(this.seqBox_Enter);
            this.seqBox.Leave += new System.EventHandler(this.seqBox_Leave);
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputBox.Location = new System.Drawing.Point(66, 176);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(476, 176);
            this.outputBox.TabIndex = 7;
            this.outputBox.Text = "";
            this.outputBox.Enter += new System.EventHandler(this.outputBox_Enter);
            this.outputBox.Leave += new System.EventHandler(this.outputBox_Leave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(608, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStrip
            // 
            this.labelStrip.Name = "labelStrip";
            this.labelStrip.Size = new System.Drawing.Size(118, 17);
            this.labelStrip.Text = "toolStripStatusLabel1";
            // 
            // exampleButton
            // 
            this.exampleButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exampleButton.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exampleButton.Location = new System.Drawing.Point(67, 113);
            this.exampleButton.Name = "exampleButton";
            this.exampleButton.Size = new System.Drawing.Size(111, 28);
            this.exampleButton.TabIndex = 9;
            this.exampleButton.Text = "Przykład";
            this.exampleButton.UseVisualStyleBackColor = true;
            this.exampleButton.Click += new System.EventHandler(this.exampleButton_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 406);
            this.Controls.Add(this.exampleButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.seqBox);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(624, 445);
            this.MinimumSize = new System.Drawing.Size(624, 445);
            this.Name = "Form1";
            this.Text = "Translacja";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.RichTextBox seqBox;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStrip;
        private System.Windows.Forms.Button exampleButton;
    }
}

