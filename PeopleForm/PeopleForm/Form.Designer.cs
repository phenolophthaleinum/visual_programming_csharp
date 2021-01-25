namespace PeopleForm
{
    partial class MainForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.last_nameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.nameRichBox = new System.Windows.Forms.RichTextBox();
            this.last_nameRichBox = new System.Windows.Forms.RichTextBox();
            this.positionCombo = new System.Windows.Forms.ComboBox();
            this.womanRadio = new System.Windows.Forms.RadioButton();
            this.manRadio = new System.Windows.Forms.RadioButton();
            this.birthCombo = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(56, 49);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 14);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // last_nameLabel
            // 
            this.last_nameLabel.AutoSize = true;
            this.last_nameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_nameLabel.Location = new System.Drawing.Point(56, 79);
            this.last_nameLabel.Name = "last_nameLabel";
            this.last_nameLabel.Size = new System.Drawing.Size(62, 14);
            this.last_nameLabel.TabIndex = 1;
            this.last_nameLabel.Text = "Last Name:";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(56, 110);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(70, 14);
            this.positionLabel.TabIndex = 2;
            this.positionLabel.Text = "Stanowisko:";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.Location = new System.Drawing.Point(56, 141);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(29, 14);
            this.sexLabel.TabIndex = 3;
            this.sexLabel.Text = "Płeć";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLabel.Location = new System.Drawing.Point(56, 170);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(85, 14);
            this.birthLabel.TabIndex = 4;
            this.birthLabel.Text = "Rok urodzenia:";
            // 
            // nameRichBox
            // 
            this.nameRichBox.Location = new System.Drawing.Point(158, 46);
            this.nameRichBox.Name = "nameRichBox";
            this.nameRichBox.Size = new System.Drawing.Size(219, 21);
            this.nameRichBox.TabIndex = 5;
            this.nameRichBox.Text = "";
            // 
            // last_nameRichBox
            // 
            this.last_nameRichBox.Location = new System.Drawing.Point(158, 76);
            this.last_nameRichBox.Name = "last_nameRichBox";
            this.last_nameRichBox.Size = new System.Drawing.Size(219, 21);
            this.last_nameRichBox.TabIndex = 6;
            this.last_nameRichBox.Text = "";
            // 
            // positionCombo
            // 
            this.positionCombo.FormattingEnabled = true;
            this.positionCombo.Items.AddRange(new object[] {
            "Student",
            "Profesor",
            "Doktor",
            "Inny"});
            this.positionCombo.Location = new System.Drawing.Point(158, 107);
            this.positionCombo.Name = "positionCombo";
            this.positionCombo.Size = new System.Drawing.Size(219, 21);
            this.positionCombo.TabIndex = 7;
            // 
            // womanRadio
            // 
            this.womanRadio.AutoSize = true;
            this.womanRadio.Location = new System.Drawing.Point(158, 141);
            this.womanRadio.Name = "womanRadio";
            this.womanRadio.Size = new System.Drawing.Size(61, 17);
            this.womanRadio.TabIndex = 8;
            this.womanRadio.TabStop = true;
            this.womanRadio.Text = "Kobieta";
            this.womanRadio.UseVisualStyleBackColor = true;
            // 
            // manRadio
            // 
            this.manRadio.AutoSize = true;
            this.manRadio.Location = new System.Drawing.Point(299, 141);
            this.manRadio.Name = "manRadio";
            this.manRadio.Size = new System.Drawing.Size(78, 17);
            this.manRadio.TabIndex = 9;
            this.manRadio.TabStop = true;
            this.manRadio.Text = "Mężczyzna";
            this.manRadio.UseVisualStyleBackColor = true;
            // 
            // birthCombo
            // 
            this.birthCombo.FormattingEnabled = true;
            this.birthCombo.Location = new System.Drawing.Point(158, 170);
            this.birthCombo.Name = "birthCombo";
            this.birthCombo.Size = new System.Drawing.Size(219, 21);
            this.birthCombo.TabIndex = 10;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(158, 392);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 23);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Usuń osobę";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(26, 52);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Nadpisz dane";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(158, 334);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(94, 23);
            this.newButton.TabIndex = 13;
            this.newButton.Text = "Utwórz osobę";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(283, 334);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(94, 23);
            this.nextButton.TabIndex = 14;
            this.nextButton.Text = "Nast. osoba";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(32, 334);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(94, 23);
            this.prevButton.TabIndex = 15;
            this.prevButton.Text = "Poprz. osoba";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(283, 392);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(94, 23);
            this.saveFileButton.TabIndex = 16;
            this.saveFileButton.Text = "Zapis do pliku";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Location = new System.Drawing.Point(132, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 115);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funkcje osoby";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(421, 22);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.birthCombo);
            this.Controls.Add(this.manRadio);
            this.Controls.Add(this.womanRadio);
            this.Controls.Add(this.positionCombo);
            this.Controls.Add(this.last_nameRichBox);
            this.Controls.Add(this.nameRichBox);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.last_nameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Formularz";
            this.groupBox1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label last_nameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.RichTextBox nameRichBox;
        private System.Windows.Forms.RichTextBox last_nameRichBox;
        private System.Windows.Forms.ComboBox positionCombo;
        private System.Windows.Forms.RadioButton womanRadio;
        private System.Windows.Forms.RadioButton manRadio;
        private System.Windows.Forms.ComboBox birthCombo;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

