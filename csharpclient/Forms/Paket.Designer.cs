namespace DE2_UE_Fahrradkurier
{
    partial class Paket
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
            System.Windows.Forms.Label titelLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.titelTextBox = new System.Windows.Forms.TextBox();
            this.hoeheTextBox = new System.Windows.Forms.TextBox();
            this.breiteTextBox = new System.Windows.Forms.TextBox();
            this.tiefeTextBox = new System.Windows.Forms.TextBox();
            this.gewichtTextBox = new System.Windows.Forms.TextBox();
            this.fragileComboBox = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            titelLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titelLabel
            // 
            titelLabel.AutoSize = true;
            titelLabel.Location = new System.Drawing.Point(27, 15);
            titelLabel.Name = "titelLabel";
            titelLabel.Size = new System.Drawing.Size(30, 13);
            titelLabel.TabIndex = 4;
            titelLabel.Text = "Titel:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 13);
            label1.TabIndex = 4;
            label1.Text = "Höhe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 13);
            label2.TabIndex = 4;
            label2.Text = "Breite:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(23, 93);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 4;
            label3.Text = "Tiefe:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(8, 119);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 13);
            label4.TabIndex = 4;
            label4.Text = "Gewicht:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(16, 145);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 13);
            label5.TabIndex = 4;
            label5.Text = "Fragile:";
            // 
            // titelTextBox
            // 
            this.titelTextBox.Location = new System.Drawing.Point(63, 12);
            this.titelTextBox.Name = "titelTextBox";
            this.titelTextBox.Size = new System.Drawing.Size(201, 20);
            this.titelTextBox.TabIndex = 0;
            // 
            // hoeheTextBox
            // 
            this.hoeheTextBox.Location = new System.Drawing.Point(63, 38);
            this.hoeheTextBox.Name = "hoeheTextBox";
            this.hoeheTextBox.Size = new System.Drawing.Size(201, 20);
            this.hoeheTextBox.TabIndex = 1;
            // 
            // breiteTextBox
            // 
            this.breiteTextBox.Location = new System.Drawing.Point(63, 64);
            this.breiteTextBox.Name = "breiteTextBox";
            this.breiteTextBox.Size = new System.Drawing.Size(201, 20);
            this.breiteTextBox.TabIndex = 2;
            // 
            // tiefeTextBox
            // 
            this.tiefeTextBox.Location = new System.Drawing.Point(63, 90);
            this.tiefeTextBox.Name = "tiefeTextBox";
            this.tiefeTextBox.Size = new System.Drawing.Size(201, 20);
            this.tiefeTextBox.TabIndex = 3;
            // 
            // gewichtTextBox
            // 
            this.gewichtTextBox.Location = new System.Drawing.Point(63, 116);
            this.gewichtTextBox.Name = "gewichtTextBox";
            this.gewichtTextBox.Size = new System.Drawing.Size(201, 20);
            this.gewichtTextBox.TabIndex = 4;
            // 
            // fragileComboBox
            // 
            this.fragileComboBox.FormattingEnabled = true;
            this.fragileComboBox.Items.AddRange(new object[] {
            "Nein",
            "Ja"});
            this.fragileComboBox.Location = new System.Drawing.Point(63, 142);
            this.fragileComboBox.Name = "fragileComboBox";
            this.fragileComboBox.Size = new System.Drawing.Size(201, 21);
            this.fragileComboBox.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(108, 169);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(189, 169);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Paket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 206);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.fragileComboBox);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(titelLabel);
            this.Controls.Add(this.gewichtTextBox);
            this.Controls.Add(this.tiefeTextBox);
            this.Controls.Add(this.breiteTextBox);
            this.Controls.Add(this.hoeheTextBox);
            this.Controls.Add(this.titelTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Paket";
            this.ShowIcon = false;
            this.Text = "Paket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titelTextBox;
        private System.Windows.Forms.TextBox hoeheTextBox;
        private System.Windows.Forms.TextBox breiteTextBox;
        private System.Windows.Forms.TextBox tiefeTextBox;
        private System.Windows.Forms.TextBox gewichtTextBox;
        private System.Windows.Forms.ComboBox fragileComboBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}