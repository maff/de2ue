namespace DE2_UE_Fahrradkurier
{
    partial class MainWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFahrer = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridFahrer = new System.Windows.Forms.DataGridView();
            this.buttonNewDriver = new System.Windows.Forms.Button();
            this.de2_uebung_fahrradkurierDataSet = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet();
            this.fahrerAnzeigenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fahrerAnzeigenTableAdapter = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSetTableAdapters.FahrerAnzeigenTableAdapter();
            this.anredeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geburtsdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sVNummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridFahrerTable = new System.Windows.Forms.DataGridView();
            this.de2_uebung_fahrradkurierDataSet1 = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet1();
            this.fahrerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fahrerTableAdapter = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet1TableAdapters.FahrerTableAdapter();
            this.fahrerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geburtsdatumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sVNummerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passNummerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabFahrer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFahrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrerAnzeigenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFahrerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFahrer);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 603);
            this.tabControl1.TabIndex = 2;
            // 
            // tabFahrer
            // 
            this.tabFahrer.Controls.Add(this.dataGridFahrerTable);
            this.tabFahrer.Controls.Add(this.dataGridFahrer);
            this.tabFahrer.Controls.Add(this.panel1);
            this.tabFahrer.Location = new System.Drawing.Point(4, 22);
            this.tabFahrer.Name = "tabFahrer";
            this.tabFahrer.Padding = new System.Windows.Forms.Padding(3);
            this.tabFahrer.Size = new System.Drawing.Size(1030, 577);
            this.tabFahrer.TabIndex = 0;
            this.tabFahrer.Text = "Fahrer";
            this.tabFahrer.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1030, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.buttonNewDriver);
            this.panel1.Location = new System.Drawing.Point(6, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 31);
            this.panel1.TabIndex = 2;
            // 
            // dataGridFahrer
            // 
            this.dataGridFahrer.AutoGenerateColumns = false;
            this.dataGridFahrer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFahrer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anredeDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.telefonnummerDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.strasseDataGridViewTextBoxColumn,
            this.pLZDataGridViewTextBoxColumn,
            this.ortDataGridViewTextBoxColumn,
            this.landDataGridViewTextBoxColumn,
            this.geburtsdatumDataGridViewTextBoxColumn,
            this.sVNummerDataGridViewTextBoxColumn,
            this.passnummerDataGridViewTextBoxColumn});
            this.dataGridFahrer.DataSource = this.fahrerAnzeigenBindingSource;
            this.dataGridFahrer.Location = new System.Drawing.Point(7, 7);
            this.dataGridFahrer.Name = "dataGridFahrer";
            this.dataGridFahrer.Size = new System.Drawing.Size(1014, 214);
            this.dataGridFahrer.TabIndex = 3;
            // 
            // buttonNewDriver
            // 
            this.buttonNewDriver.Location = new System.Drawing.Point(910, 5);
            this.buttonNewDriver.Name = "buttonNewDriver";
            this.buttonNewDriver.Size = new System.Drawing.Size(105, 23);
            this.buttonNewDriver.TabIndex = 2;
            this.buttonNewDriver.Text = "Neuer Fahrer";
            this.buttonNewDriver.UseVisualStyleBackColor = true;
            this.buttonNewDriver.Click += new System.EventHandler(this.buttonNewDriver_Click);
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
            // anredeDataGridViewTextBoxColumn
            // 
            this.anredeDataGridViewTextBoxColumn.DataPropertyName = "Anrede";
            this.anredeDataGridViewTextBoxColumn.HeaderText = "Anrede";
            this.anredeDataGridViewTextBoxColumn.Name = "anredeDataGridViewTextBoxColumn";
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            // 
            // telefonnummerDataGridViewTextBoxColumn
            // 
            this.telefonnummerDataGridViewTextBoxColumn.DataPropertyName = "Telefonnummer";
            this.telefonnummerDataGridViewTextBoxColumn.HeaderText = "Telefonnummer";
            this.telefonnummerDataGridViewTextBoxColumn.Name = "telefonnummerDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // strasseDataGridViewTextBoxColumn
            // 
            this.strasseDataGridViewTextBoxColumn.DataPropertyName = "Strasse";
            this.strasseDataGridViewTextBoxColumn.HeaderText = "Strasse";
            this.strasseDataGridViewTextBoxColumn.Name = "strasseDataGridViewTextBoxColumn";
            // 
            // pLZDataGridViewTextBoxColumn
            // 
            this.pLZDataGridViewTextBoxColumn.DataPropertyName = "PLZ";
            this.pLZDataGridViewTextBoxColumn.HeaderText = "PLZ";
            this.pLZDataGridViewTextBoxColumn.Name = "pLZDataGridViewTextBoxColumn";
            // 
            // ortDataGridViewTextBoxColumn
            // 
            this.ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            this.ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            // 
            // landDataGridViewTextBoxColumn
            // 
            this.landDataGridViewTextBoxColumn.DataPropertyName = "Land";
            this.landDataGridViewTextBoxColumn.HeaderText = "Land";
            this.landDataGridViewTextBoxColumn.Name = "landDataGridViewTextBoxColumn";
            // 
            // geburtsdatumDataGridViewTextBoxColumn
            // 
            this.geburtsdatumDataGridViewTextBoxColumn.DataPropertyName = "Geburtsdatum";
            this.geburtsdatumDataGridViewTextBoxColumn.HeaderText = "Geburtsdatum";
            this.geburtsdatumDataGridViewTextBoxColumn.Name = "geburtsdatumDataGridViewTextBoxColumn";
            // 
            // sVNummerDataGridViewTextBoxColumn
            // 
            this.sVNummerDataGridViewTextBoxColumn.DataPropertyName = "SVNummer";
            this.sVNummerDataGridViewTextBoxColumn.HeaderText = "SVNummer";
            this.sVNummerDataGridViewTextBoxColumn.Name = "sVNummerDataGridViewTextBoxColumn";
            // 
            // passnummerDataGridViewTextBoxColumn
            // 
            this.passnummerDataGridViewTextBoxColumn.DataPropertyName = "Passnummer";
            this.passnummerDataGridViewTextBoxColumn.HeaderText = "Passnummer";
            this.passnummerDataGridViewTextBoxColumn.Name = "passnummerDataGridViewTextBoxColumn";
            // 
            // dataGridFahrerTable
            // 
            this.dataGridFahrerTable.AutoGenerateColumns = false;
            this.dataGridFahrerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFahrerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fahrerIDDataGridViewTextBoxColumn,
            this.personIDDataGridViewTextBoxColumn,
            this.geburtsdatumDataGridViewTextBoxColumn1,
            this.sVNummerDataGridViewTextBoxColumn1,
            this.passNummerDataGridViewTextBoxColumn1});
            this.dataGridFahrerTable.DataSource = this.fahrerBindingSource;
            this.dataGridFahrerTable.Location = new System.Drawing.Point(7, 227);
            this.dataGridFahrerTable.Name = "dataGridFahrerTable";
            this.dataGridFahrerTable.Size = new System.Drawing.Size(846, 192);
            this.dataGridFahrerTable.TabIndex = 4;
            // 
            // de2_uebung_fahrradkurierDataSet1
            // 
            this.de2_uebung_fahrradkurierDataSet1.DataSetName = "de2_uebung_fahrradkurierDataSet1";
            this.de2_uebung_fahrradkurierDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fahrerBindingSource
            // 
            this.fahrerBindingSource.DataMember = "Fahrer";
            this.fahrerBindingSource.DataSource = this.de2_uebung_fahrradkurierDataSet1;
            // 
            // fahrerTableAdapter
            // 
            this.fahrerTableAdapter.ClearBeforeFill = true;
            // 
            // fahrerIDDataGridViewTextBoxColumn
            // 
            this.fahrerIDDataGridViewTextBoxColumn.DataPropertyName = "Fahrer_ID";
            this.fahrerIDDataGridViewTextBoxColumn.HeaderText = "Fahrer_ID";
            this.fahrerIDDataGridViewTextBoxColumn.Name = "fahrerIDDataGridViewTextBoxColumn";
            this.fahrerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "Person_ID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "Person_ID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            // 
            // geburtsdatumDataGridViewTextBoxColumn1
            // 
            this.geburtsdatumDataGridViewTextBoxColumn1.DataPropertyName = "Geburtsdatum";
            this.geburtsdatumDataGridViewTextBoxColumn1.HeaderText = "Geburtsdatum";
            this.geburtsdatumDataGridViewTextBoxColumn1.Name = "geburtsdatumDataGridViewTextBoxColumn1";
            // 
            // sVNummerDataGridViewTextBoxColumn1
            // 
            this.sVNummerDataGridViewTextBoxColumn1.DataPropertyName = "SVNummer";
            this.sVNummerDataGridViewTextBoxColumn1.HeaderText = "SVNummer";
            this.sVNummerDataGridViewTextBoxColumn1.Name = "sVNummerDataGridViewTextBoxColumn1";
            // 
            // passNummerDataGridViewTextBoxColumn1
            // 
            this.passNummerDataGridViewTextBoxColumn1.DataPropertyName = "PassNummer";
            this.passNummerDataGridViewTextBoxColumn1.HeaderText = "PassNummer";
            this.passNummerDataGridViewTextBoxColumn1.Name = "passNummerDataGridViewTextBoxColumn1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 628);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "Fahrradkurier";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFahrer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFahrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrerAnzeigenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFahrerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFahrer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridFahrer;
        private System.Windows.Forms.Button buttonNewDriver;
        private de2_uebung_fahrradkurierDataSet de2_uebung_fahrradkurierDataSet;
        private System.Windows.Forms.BindingSource fahrerAnzeigenBindingSource;
        private DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSetTableAdapters.FahrerAnzeigenTableAdapter fahrerAnzeigenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn anredeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn landDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geburtsdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sVNummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridFahrerTable;
        private de2_uebung_fahrradkurierDataSet1 de2_uebung_fahrradkurierDataSet1;
        private System.Windows.Forms.BindingSource fahrerBindingSource;
        private DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet1TableAdapters.FahrerTableAdapter fahrerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fahrerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geburtsdatumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sVNummerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passNummerDataGridViewTextBoxColumn1;
    }
}

