namespace DE2_UE_Fahrradkurier
{
    partial class Auftrag
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
            System.Windows.Forms.Label landLabel;
            System.Windows.Forms.Label ortLabel;
            System.Windows.Forms.Label pLZLabel;
            System.Windows.Forms.Label strasseLabel;
            System.Windows.Forms.Label fahrerLabel;
            System.Windows.Forms.Label labelKunde;
            System.Windows.Forms.Label labelStatus;
            System.Windows.Forms.Label labelKilometer;
            this.fahrerComboBox = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.landTextBox = new System.Windows.Forms.TextBox();
            this.ortTextBox = new System.Windows.Forms.TextBox();
            this.PLZTextBox = new System.Windows.Forms.TextBox();
            this.strasseTextBox = new System.Windows.Forms.TextBox();
            this.kundeComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.kilometerTextBox = new System.Windows.Forms.TextBox();
            landLabel = new System.Windows.Forms.Label();
            ortLabel = new System.Windows.Forms.Label();
            pLZLabel = new System.Windows.Forms.Label();
            strasseLabel = new System.Windows.Forms.Label();
            fahrerLabel = new System.Windows.Forms.Label();
            labelKunde = new System.Windows.Forms.Label();
            labelStatus = new System.Windows.Forms.Label();
            labelKilometer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // landLabel
            // 
            landLabel.AutoSize = true;
            landLabel.Location = new System.Drawing.Point(57, 195);
            landLabel.Name = "landLabel";
            landLabel.Size = new System.Drawing.Size(34, 13);
            landLabel.TabIndex = 42;
            landLabel.Text = "Land:";
            landLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ortLabel
            // 
            ortLabel.AutoSize = true;
            ortLabel.Location = new System.Drawing.Point(67, 169);
            ortLabel.Name = "ortLabel";
            ortLabel.Size = new System.Drawing.Size(24, 13);
            ortLabel.TabIndex = 39;
            ortLabel.Text = "Ort:";
            ortLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pLZLabel
            // 
            pLZLabel.AutoSize = true;
            pLZLabel.Location = new System.Drawing.Point(61, 143);
            pLZLabel.Name = "pLZLabel";
            pLZLabel.Size = new System.Drawing.Size(30, 13);
            pLZLabel.TabIndex = 37;
            pLZLabel.Text = "PLZ:";
            pLZLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // strasseLabel
            // 
            strasseLabel.AutoSize = true;
            strasseLabel.Location = new System.Drawing.Point(46, 117);
            strasseLabel.Name = "strasseLabel";
            strasseLabel.Size = new System.Drawing.Size(45, 13);
            strasseLabel.TabIndex = 35;
            strasseLabel.Text = "Strasse:";
            strasseLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fahrerLabel
            // 
            fahrerLabel.AutoSize = true;
            fahrerLabel.Location = new System.Drawing.Point(51, 10);
            fahrerLabel.Name = "fahrerLabel";
            fahrerLabel.Size = new System.Drawing.Size(40, 13);
            fahrerLabel.TabIndex = 26;
            fahrerLabel.Text = "Fahrer:";
            fahrerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelKunde
            // 
            labelKunde.AutoSize = true;
            labelKunde.Location = new System.Drawing.Point(51, 37);
            labelKunde.Name = "labelKunde";
            labelKunde.Size = new System.Drawing.Size(41, 13);
            labelKunde.TabIndex = 26;
            labelKunde.Text = "Kunde:";
            labelKunde.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new System.Drawing.Point(51, 64);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(40, 13);
            labelStatus.TabIndex = 26;
            labelStatus.Text = "Status:";
            labelStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelKilometer
            // 
            labelKilometer.AutoSize = true;
            labelKilometer.Location = new System.Drawing.Point(38, 91);
            labelKilometer.Name = "labelKilometer";
            labelKilometer.Size = new System.Drawing.Size(53, 13);
            labelKilometer.TabIndex = 35;
            labelKilometer.Text = "Kilometer:";
            labelKilometer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fahrerComboBox
            // 
            this.fahrerComboBox.FormattingEnabled = true;
            this.fahrerComboBox.Location = new System.Drawing.Point(97, 7);
            this.fahrerComboBox.Name = "fahrerComboBox";
            this.fahrerComboBox.Size = new System.Drawing.Size(201, 21);
            this.fahrerComboBox.TabIndex = 51;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(142, 218);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 49;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(223, 218);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 48;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // landTextBox
            // 
            this.landTextBox.Location = new System.Drawing.Point(97, 192);
            this.landTextBox.Name = "landTextBox";
            this.landTextBox.Size = new System.Drawing.Size(201, 20);
            this.landTextBox.TabIndex = 43;
            // 
            // ortTextBox
            // 
            this.ortTextBox.Location = new System.Drawing.Point(97, 166);
            this.ortTextBox.Name = "ortTextBox";
            this.ortTextBox.Size = new System.Drawing.Size(201, 20);
            this.ortTextBox.TabIndex = 40;
            // 
            // PLZTextBox
            // 
            this.PLZTextBox.Location = new System.Drawing.Point(97, 140);
            this.PLZTextBox.Name = "PLZTextBox";
            this.PLZTextBox.Size = new System.Drawing.Size(201, 20);
            this.PLZTextBox.TabIndex = 38;
            // 
            // strasseTextBox
            // 
            this.strasseTextBox.Location = new System.Drawing.Point(97, 114);
            this.strasseTextBox.Name = "strasseTextBox";
            this.strasseTextBox.Size = new System.Drawing.Size(201, 20);
            this.strasseTextBox.TabIndex = 36;
            // 
            // kundeComboBox
            // 
            this.kundeComboBox.FormattingEnabled = true;
            this.kundeComboBox.Location = new System.Drawing.Point(97, 34);
            this.kundeComboBox.Name = "kundeComboBox";
            this.kundeComboBox.Size = new System.Drawing.Size(201, 21);
            this.kundeComboBox.TabIndex = 51;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(97, 61);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(201, 21);
            this.statusComboBox.TabIndex = 51;
            // 
            // kilometerTextBox
            // 
            this.kilometerTextBox.Location = new System.Drawing.Point(97, 88);
            this.kilometerTextBox.Name = "kilometerTextBox";
            this.kilometerTextBox.Size = new System.Drawing.Size(201, 20);
            this.kilometerTextBox.TabIndex = 36;
            // 
            // Auftrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 254);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.kundeComboBox);
            this.Controls.Add(this.fahrerComboBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(landLabel);
            this.Controls.Add(this.landTextBox);
            this.Controls.Add(ortLabel);
            this.Controls.Add(this.ortTextBox);
            this.Controls.Add(pLZLabel);
            this.Controls.Add(this.PLZTextBox);
            this.Controls.Add(labelKilometer);
            this.Controls.Add(strasseLabel);
            this.Controls.Add(labelStatus);
            this.Controls.Add(this.kilometerTextBox);
            this.Controls.Add(this.strasseTextBox);
            this.Controls.Add(labelKunde);
            this.Controls.Add(fahrerLabel);
            this.Name = "Auftrag";
            this.Text = "Auftrag";
            this.Load += new System.EventHandler(this.Auftrag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fahrerComboBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox landTextBox;
        private System.Windows.Forms.TextBox ortTextBox;
        private System.Windows.Forms.TextBox PLZTextBox;
        private System.Windows.Forms.TextBox strasseTextBox;
        private System.Windows.Forms.ComboBox kundeComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox kilometerTextBox;
    }
}