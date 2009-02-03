namespace DE2_UE_Fahrradkurier
{
    partial class Fahrer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label anredeLabel;
            System.Windows.Forms.Label vornameLabel;
            System.Windows.Forms.Label nachnameLabel;
            System.Windows.Forms.Label telefonnummerLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label strasseLabel;
            System.Windows.Forms.Label pLZLabel;
            System.Windows.Forms.Label ortLabel;
            System.Windows.Forms.Label landLabel;
            System.Windows.Forms.Label sVNummerLabel;
            System.Windows.Forms.Label passnummerLabel;
            System.Windows.Forms.Label geburtsDatumLabel;
            this.de2_uebung_fahrradkurierDataSet = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet();
            this.fahrerAnzeigenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fahrerAnzeigenTableAdapter = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSetTableAdapters.FahrerAnzeigenTableAdapter();
            this.tableAdapterManager = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSetTableAdapters.TableAdapterManager();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.nachnameTextBox = new System.Windows.Forms.TextBox();
            this.telefonnummerTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.strasseTextBox = new System.Windows.Forms.TextBox();
            this.PLZTextBox = new System.Windows.Forms.TextBox();
            this.ortTextBox = new System.Windows.Forms.TextBox();
            this.landTextBox = new System.Windows.Forms.TextBox();
            this.SVNummerTextBox = new System.Windows.Forms.TextBox();
            this.passnummerTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.geburtsdatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.anredeComboBox = new System.Windows.Forms.ComboBox();
            anredeLabel = new System.Windows.Forms.Label();
            vornameLabel = new System.Windows.Forms.Label();
            nachnameLabel = new System.Windows.Forms.Label();
            telefonnummerLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            strasseLabel = new System.Windows.Forms.Label();
            pLZLabel = new System.Windows.Forms.Label();
            ortLabel = new System.Windows.Forms.Label();
            landLabel = new System.Windows.Forms.Label();
            sVNummerLabel = new System.Windows.Forms.Label();
            passnummerLabel = new System.Windows.Forms.Label();
            geburtsDatumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrerAnzeigenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // anredeLabel
            // 
            anredeLabel.AutoSize = true;
            anredeLabel.Location = new System.Drawing.Point(49, 9);
            anredeLabel.Name = "anredeLabel";
            anredeLabel.Size = new System.Drawing.Size(44, 13);
            anredeLabel.TabIndex = 0;
            anredeLabel.Text = "Anrede:";
            // 
            // vornameLabel
            // 
            vornameLabel.AutoSize = true;
            vornameLabel.Location = new System.Drawing.Point(41, 36);
            vornameLabel.Name = "vornameLabel";
            vornameLabel.Size = new System.Drawing.Size(52, 13);
            vornameLabel.TabIndex = 2;
            vornameLabel.Text = "Vorname:";
            // 
            // nachnameLabel
            // 
            nachnameLabel.AutoSize = true;
            nachnameLabel.Location = new System.Drawing.Point(31, 62);
            nachnameLabel.Name = "nachnameLabel";
            nachnameLabel.Size = new System.Drawing.Size(62, 13);
            nachnameLabel.TabIndex = 4;
            nachnameLabel.Text = "Nachname:";
            // 
            // telefonnummerLabel
            // 
            telefonnummerLabel.AutoSize = true;
            telefonnummerLabel.Location = new System.Drawing.Point(10, 88);
            telefonnummerLabel.Name = "telefonnummerLabel";
            telefonnummerLabel.Size = new System.Drawing.Size(83, 13);
            telefonnummerLabel.TabIndex = 6;
            telefonnummerLabel.Text = "Telefonnummer:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(58, 114);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // strasseLabel
            // 
            strasseLabel.AutoSize = true;
            strasseLabel.Location = new System.Drawing.Point(48, 140);
            strasseLabel.Name = "strasseLabel";
            strasseLabel.Size = new System.Drawing.Size(45, 13);
            strasseLabel.TabIndex = 10;
            strasseLabel.Text = "Strasse:";
            // 
            // pLZLabel
            // 
            pLZLabel.AutoSize = true;
            pLZLabel.Location = new System.Drawing.Point(63, 166);
            pLZLabel.Name = "pLZLabel";
            pLZLabel.Size = new System.Drawing.Size(30, 13);
            pLZLabel.TabIndex = 12;
            pLZLabel.Text = "PLZ:";
            // 
            // ortLabel
            // 
            ortLabel.AutoSize = true;
            ortLabel.Location = new System.Drawing.Point(69, 192);
            ortLabel.Name = "ortLabel";
            ortLabel.Size = new System.Drawing.Size(24, 13);
            ortLabel.TabIndex = 14;
            ortLabel.Text = "Ort:";
            // 
            // landLabel
            // 
            landLabel.AutoSize = true;
            landLabel.Location = new System.Drawing.Point(59, 218);
            landLabel.Name = "landLabel";
            landLabel.Size = new System.Drawing.Size(34, 13);
            landLabel.TabIndex = 16;
            landLabel.Text = "Land:";
            // 
            // sVNummerLabel
            // 
            sVNummerLabel.AutoSize = true;
            sVNummerLabel.Location = new System.Drawing.Point(30, 271);
            sVNummerLabel.Name = "sVNummerLabel";
            sVNummerLabel.Size = new System.Drawing.Size(63, 13);
            sVNummerLabel.TabIndex = 18;
            sVNummerLabel.Text = "SVNummer:";
            // 
            // passnummerLabel
            // 
            passnummerLabel.AutoSize = true;
            passnummerLabel.Location = new System.Drawing.Point(23, 297);
            passnummerLabel.Name = "passnummerLabel";
            passnummerLabel.Size = new System.Drawing.Size(70, 13);
            passnummerLabel.TabIndex = 20;
            passnummerLabel.Text = "Passnummer:";
            // 
            // geburtsDatumLabel
            // 
            geburtsDatumLabel.AutoSize = true;
            geburtsDatumLabel.Location = new System.Drawing.Point(17, 246);
            geburtsDatumLabel.Name = "geburtsDatumLabel";
            geburtsDatumLabel.Size = new System.Drawing.Size(76, 13);
            geburtsDatumLabel.TabIndex = 16;
            geburtsDatumLabel.Text = "Geburtsdatum:";
            // 
            // de2_uebung_fahrradkurierDataSet
            // 
            this.de2_uebung_fahrradkurierDataSet.DataSetName = "de2_uebung_fahrradkurierDataSet";
            this.de2_uebung_fahrradkurierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fahrerAnzeigenBindingSource
            // 
            this.fahrerAnzeigenBindingSource.DataMember = "FahrerAnzeigen";
            this.fahrerAnzeigenBindingSource.DataSource = this.de2_uebung_fahrradkurierDataSet;
            // 
            // fahrerAnzeigenTableAdapter
            // 
            this.fahrerAnzeigenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.Location = new System.Drawing.Point(99, 33);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(201, 20);
            this.vornameTextBox.TabIndex = 2;
            // 
            // nachnameTextBox
            // 
            this.nachnameTextBox.Location = new System.Drawing.Point(99, 59);
            this.nachnameTextBox.Name = "nachnameTextBox";
            this.nachnameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nachnameTextBox.TabIndex = 3;
            // 
            // telefonnummerTextBox
            // 
            this.telefonnummerTextBox.Location = new System.Drawing.Point(99, 85);
            this.telefonnummerTextBox.Name = "telefonnummerTextBox";
            this.telefonnummerTextBox.Size = new System.Drawing.Size(201, 20);
            this.telefonnummerTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(99, 111);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(201, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // strasseTextBox
            // 
            this.strasseTextBox.Location = new System.Drawing.Point(99, 137);
            this.strasseTextBox.Name = "strasseTextBox";
            this.strasseTextBox.Size = new System.Drawing.Size(201, 20);
            this.strasseTextBox.TabIndex = 6;
            // 
            // PLZTextBox
            // 
            this.PLZTextBox.Location = new System.Drawing.Point(99, 163);
            this.PLZTextBox.Name = "PLZTextBox";
            this.PLZTextBox.Size = new System.Drawing.Size(201, 20);
            this.PLZTextBox.TabIndex = 7;
            // 
            // ortTextBox
            // 
            this.ortTextBox.Location = new System.Drawing.Point(99, 189);
            this.ortTextBox.Name = "ortTextBox";
            this.ortTextBox.Size = new System.Drawing.Size(201, 20);
            this.ortTextBox.TabIndex = 8;
            // 
            // landTextBox
            // 
            this.landTextBox.Location = new System.Drawing.Point(99, 215);
            this.landTextBox.Name = "landTextBox";
            this.landTextBox.Size = new System.Drawing.Size(201, 20);
            this.landTextBox.TabIndex = 9;
            // 
            // SVNummerTextBox
            // 
            this.SVNummerTextBox.Location = new System.Drawing.Point(99, 268);
            this.SVNummerTextBox.Name = "SVNummerTextBox";
            this.SVNummerTextBox.Size = new System.Drawing.Size(201, 20);
            this.SVNummerTextBox.TabIndex = 10;
            // 
            // passnummerTextBox
            // 
            this.passnummerTextBox.Location = new System.Drawing.Point(99, 294);
            this.passnummerTextBox.Name = "passnummerTextBox";
            this.passnummerTextBox.Size = new System.Drawing.Size(201, 20);
            this.passnummerTextBox.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(225, 320);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(144, 320);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // geburtsdatumDateTimePicker
            // 
            this.geburtsdatumDateTimePicker.Location = new System.Drawing.Point(99, 242);
            this.geburtsdatumDateTimePicker.Name = "geburtsdatumDateTimePicker";
            this.geburtsdatumDateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.geburtsdatumDateTimePicker.TabIndex = 9;
            // 
            // anredeComboBox
            // 
            this.anredeComboBox.FormattingEnabled = true;
            this.anredeComboBox.Items.AddRange(new object[] {
            "Herr",
            "Frau"});
            this.anredeComboBox.Location = new System.Drawing.Point(99, 6);
            this.anredeComboBox.Name = "anredeComboBox";
            this.anredeComboBox.Size = new System.Drawing.Size(201, 21);
            this.anredeComboBox.TabIndex = 1;
            // 
            // Fahrer
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(322, 355);
            this.ControlBox = false;
            this.Controls.Add(this.anredeComboBox);
            this.Controls.Add(this.geburtsdatumDateTimePicker);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(passnummerLabel);
            this.Controls.Add(this.passnummerTextBox);
            this.Controls.Add(sVNummerLabel);
            this.Controls.Add(this.SVNummerTextBox);
            this.Controls.Add(geburtsDatumLabel);
            this.Controls.Add(landLabel);
            this.Controls.Add(this.landTextBox);
            this.Controls.Add(ortLabel);
            this.Controls.Add(this.ortTextBox);
            this.Controls.Add(pLZLabel);
            this.Controls.Add(this.PLZTextBox);
            this.Controls.Add(strasseLabel);
            this.Controls.Add(this.strasseTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefonnummerLabel);
            this.Controls.Add(this.telefonnummerTextBox);
            this.Controls.Add(nachnameLabel);
            this.Controls.Add(this.nachnameTextBox);
            this.Controls.Add(vornameLabel);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(anredeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fahrer";
            this.Text = "Fahrer";
            this.Load += new System.EventHandler(this.Fahrer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrerAnzeigenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private de2_uebung_fahrradkurierDataSet de2_uebung_fahrradkurierDataSet;
        private System.Windows.Forms.BindingSource fahrerAnzeigenBindingSource;
        private DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSetTableAdapters.FahrerAnzeigenTableAdapter fahrerAnzeigenTableAdapter;
        private DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.TextBox nachnameTextBox;
        private System.Windows.Forms.TextBox telefonnummerTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox strasseTextBox;
        private System.Windows.Forms.TextBox PLZTextBox;
        private System.Windows.Forms.TextBox ortTextBox;
        private System.Windows.Forms.TextBox landTextBox;
        private System.Windows.Forms.TextBox SVNummerTextBox;
        private System.Windows.Forms.TextBox passnummerTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker geburtsdatumDateTimePicker;
        private System.Windows.Forms.ComboBox anredeComboBox;
    }
}