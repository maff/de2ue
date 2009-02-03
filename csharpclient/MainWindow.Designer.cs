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
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabFahrer = new System.Windows.Forms.TabPage();
            this.fahrerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.de2_uebung_fahrradkurierDataSet1 = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet1();
            this.dataGridViewFahrer = new System.Windows.Forms.DataGridView();
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
            this.fahrerAnzeigenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.de2_uebung_fahrradkurierDataSet = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNewDriver = new System.Windows.Forms.Button();
            this.tabAuftraege = new System.Windows.Forms.TabPage();
            this.fahrerAnzeigenTableAdapter = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSetTableAdapters.FahrerAnzeigenTableAdapter();
            this.fahrerTableAdapter = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet1TableAdapters.FahrerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNeuerAuftrag = new System.Windows.Forms.Button();
            this.dataGridViewAuftraege = new System.Windows.Forms.DataGridView();
            this.de2uebungfahrradkurierDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.de2_uebung_fahrradkurierDataSet2 = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet2();
            this.auftragUebersichtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auftragUebersichtTableAdapter = new DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet2TableAdapters.AuftragUebersichtTableAdapter();
            this.fahrerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gesamtgewichtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startzeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endzeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPanel.SuspendLayout();
            this.tabFahrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fahrerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFahrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrerAnzeigenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabAuftraege.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuftraege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2uebungfahrradkurierDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auftragUebersichtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabFahrer);
            this.tabPanel.Controls.Add(this.tabAuftraege);
            this.tabPanel.Location = new System.Drawing.Point(12, 13);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(1040, 603);
            this.tabPanel.TabIndex = 2;
            // 
            // tabFahrer
            // 
            this.tabFahrer.Controls.Add(this.dataGridViewFahrer);
            this.tabFahrer.Controls.Add(this.panel1);
            this.tabFahrer.Location = new System.Drawing.Point(4, 22);
            this.tabFahrer.Name = "tabFahrer";
            this.tabFahrer.Padding = new System.Windows.Forms.Padding(3);
            this.tabFahrer.Size = new System.Drawing.Size(1032, 577);
            this.tabFahrer.TabIndex = 0;
            this.tabFahrer.Text = "Fahrer";
            this.tabFahrer.UseVisualStyleBackColor = true;
            // 
            // fahrerBindingSource
            // 
            this.fahrerBindingSource.DataMember = "Fahrer";
            this.fahrerBindingSource.DataSource = this.de2_uebung_fahrradkurierDataSet1;
            // 
            // de2_uebung_fahrradkurierDataSet1
            // 
            this.de2_uebung_fahrradkurierDataSet1.DataSetName = "de2_uebung_fahrradkurierDataSet1";
            this.de2_uebung_fahrradkurierDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewFahrer
            // 
            this.dataGridViewFahrer.AllowUserToAddRows = false;
            this.dataGridViewFahrer.AllowUserToDeleteRows = false;
            this.dataGridViewFahrer.AutoGenerateColumns = false;
            this.dataGridViewFahrer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFahrer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewFahrer.DataSource = this.fahrerAnzeigenBindingSource;
            this.dataGridViewFahrer.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewFahrer.Name = "dataGridViewFahrer";
            this.dataGridViewFahrer.ReadOnly = true;
            this.dataGridViewFahrer.Size = new System.Drawing.Size(1015, 528);
            this.dataGridViewFahrer.TabIndex = 3;
            // 
            // anredeDataGridViewTextBoxColumn
            // 
            this.anredeDataGridViewTextBoxColumn.DataPropertyName = "Anrede";
            this.anredeDataGridViewTextBoxColumn.HeaderText = "Anrede";
            this.anredeDataGridViewTextBoxColumn.Name = "anredeDataGridViewTextBoxColumn";
            this.anredeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            this.vornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            this.nachnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonnummerDataGridViewTextBoxColumn
            // 
            this.telefonnummerDataGridViewTextBoxColumn.DataPropertyName = "Telefonnummer";
            this.telefonnummerDataGridViewTextBoxColumn.HeaderText = "Telefonnummer";
            this.telefonnummerDataGridViewTextBoxColumn.Name = "telefonnummerDataGridViewTextBoxColumn";
            this.telefonnummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strasseDataGridViewTextBoxColumn
            // 
            this.strasseDataGridViewTextBoxColumn.DataPropertyName = "Strasse";
            this.strasseDataGridViewTextBoxColumn.HeaderText = "Strasse";
            this.strasseDataGridViewTextBoxColumn.Name = "strasseDataGridViewTextBoxColumn";
            this.strasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLZDataGridViewTextBoxColumn
            // 
            this.pLZDataGridViewTextBoxColumn.DataPropertyName = "PLZ";
            this.pLZDataGridViewTextBoxColumn.HeaderText = "PLZ";
            this.pLZDataGridViewTextBoxColumn.Name = "pLZDataGridViewTextBoxColumn";
            this.pLZDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            this.ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            this.ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            this.ortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // landDataGridViewTextBoxColumn
            // 
            this.landDataGridViewTextBoxColumn.DataPropertyName = "Land";
            this.landDataGridViewTextBoxColumn.HeaderText = "Land";
            this.landDataGridViewTextBoxColumn.Name = "landDataGridViewTextBoxColumn";
            this.landDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // geburtsdatumDataGridViewTextBoxColumn
            // 
            this.geburtsdatumDataGridViewTextBoxColumn.DataPropertyName = "Geburtsdatum";
            this.geburtsdatumDataGridViewTextBoxColumn.HeaderText = "Geburtsdatum";
            this.geburtsdatumDataGridViewTextBoxColumn.Name = "geburtsdatumDataGridViewTextBoxColumn";
            this.geburtsdatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sVNummerDataGridViewTextBoxColumn
            // 
            this.sVNummerDataGridViewTextBoxColumn.DataPropertyName = "SVNummer";
            this.sVNummerDataGridViewTextBoxColumn.HeaderText = "SVNummer";
            this.sVNummerDataGridViewTextBoxColumn.Name = "sVNummerDataGridViewTextBoxColumn";
            this.sVNummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passnummerDataGridViewTextBoxColumn
            // 
            this.passnummerDataGridViewTextBoxColumn.DataPropertyName = "Passnummer";
            this.passnummerDataGridViewTextBoxColumn.HeaderText = "Passnummer";
            this.passnummerDataGridViewTextBoxColumn.Name = "passnummerDataGridViewTextBoxColumn";
            this.passnummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fahrerAnzeigenBindingSource
            // 
            this.fahrerAnzeigenBindingSource.DataMember = "FahrerAnzeigen";
            this.fahrerAnzeigenBindingSource.DataSource = this.de2_uebung_fahrradkurierDataSet;
            // 
            // de2_uebung_fahrradkurierDataSet
            // 
            this.de2_uebung_fahrradkurierDataSet.DataSetName = "de2_uebung_fahrradkurierDataSet";
            this.de2_uebung_fahrradkurierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tabAuftraege
            // 
            this.tabAuftraege.Controls.Add(this.dataGridViewAuftraege);
            this.tabAuftraege.Controls.Add(this.panel2);
            this.tabAuftraege.Location = new System.Drawing.Point(4, 22);
            this.tabAuftraege.Name = "tabAuftraege";
            this.tabAuftraege.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuftraege.Size = new System.Drawing.Size(1032, 577);
            this.tabAuftraege.TabIndex = 1;
            this.tabAuftraege.Text = "Aufträge";
            this.tabAuftraege.UseVisualStyleBackColor = true;
            // 
            // fahrerAnzeigenTableAdapter
            // 
            this.fahrerAnzeigenTableAdapter.ClearBeforeFill = true;
            // 
            // fahrerTableAdapter
            // 
            this.fahrerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(910, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Neuer Fahrer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(910, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Neuer Fahrer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.buttonNeuerAuftrag);
            this.panel2.Location = new System.Drawing.Point(3, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 31);
            this.panel2.TabIndex = 3;
            // 
            // buttonNeuerAuftrag
            // 
            this.buttonNeuerAuftrag.Location = new System.Drawing.Point(910, 5);
            this.buttonNeuerAuftrag.Name = "buttonNeuerAuftrag";
            this.buttonNeuerAuftrag.Size = new System.Drawing.Size(105, 23);
            this.buttonNeuerAuftrag.TabIndex = 2;
            this.buttonNeuerAuftrag.Text = "Neuer Auftrag";
            this.buttonNeuerAuftrag.UseVisualStyleBackColor = true;
            this.buttonNeuerAuftrag.Click += new System.EventHandler(this.buttonNeuerAuftrag_Click);
            // 
            // dataGridViewAuftraege
            // 
            this.dataGridViewAuftraege.AllowUserToAddRows = false;
            this.dataGridViewAuftraege.AllowUserToDeleteRows = false;
            this.dataGridViewAuftraege.AutoGenerateColumns = false;
            this.dataGridViewAuftraege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuftraege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fahrerDataGridViewTextBoxColumn,
            this.kundeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.kilometerDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.gesamtgewichtDataGridViewTextBoxColumn,
            this.startzeitDataGridViewTextBoxColumn,
            this.endzeitDataGridViewTextBoxColumn});
            this.dataGridViewAuftraege.DataSource = this.auftragUebersichtBindingSource;
            this.dataGridViewAuftraege.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewAuftraege.Name = "dataGridViewAuftraege";
            this.dataGridViewAuftraege.ReadOnly = true;
            this.dataGridViewAuftraege.Size = new System.Drawing.Size(1011, 527);
            this.dataGridViewAuftraege.TabIndex = 4;
            // 
            // de2uebungfahrradkurierDataSetBindingSource
            // 
            this.de2uebungfahrradkurierDataSetBindingSource.DataSource = this.de2_uebung_fahrradkurierDataSet;
            this.de2uebungfahrradkurierDataSetBindingSource.Position = 0;
            // 
            // de2_uebung_fahrradkurierDataSet2
            // 
            this.de2_uebung_fahrradkurierDataSet2.DataSetName = "de2_uebung_fahrradkurierDataSet2";
            this.de2_uebung_fahrradkurierDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auftragUebersichtBindingSource
            // 
            this.auftragUebersichtBindingSource.DataMember = "AuftragUebersicht";
            this.auftragUebersichtBindingSource.DataSource = this.de2_uebung_fahrradkurierDataSet2;
            // 
            // auftragUebersichtTableAdapter
            // 
            this.auftragUebersichtTableAdapter.ClearBeforeFill = true;
            // 
            // fahrerDataGridViewTextBoxColumn
            // 
            this.fahrerDataGridViewTextBoxColumn.DataPropertyName = "Fahrer";
            this.fahrerDataGridViewTextBoxColumn.HeaderText = "Fahrer";
            this.fahrerDataGridViewTextBoxColumn.Name = "fahrerDataGridViewTextBoxColumn";
            this.fahrerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kundeDataGridViewTextBoxColumn
            // 
            this.kundeDataGridViewTextBoxColumn.DataPropertyName = "Kunde";
            this.kundeDataGridViewTextBoxColumn.HeaderText = "Kunde";
            this.kundeDataGridViewTextBoxColumn.Name = "kundeDataGridViewTextBoxColumn";
            this.kundeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kilometerDataGridViewTextBoxColumn
            // 
            this.kilometerDataGridViewTextBoxColumn.DataPropertyName = "Kilometer";
            this.kilometerDataGridViewTextBoxColumn.HeaderText = "Kilometer";
            this.kilometerDataGridViewTextBoxColumn.Name = "kilometerDataGridViewTextBoxColumn";
            this.kilometerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gesamtgewichtDataGridViewTextBoxColumn
            // 
            this.gesamtgewichtDataGridViewTextBoxColumn.DataPropertyName = "Gesamtgewicht";
            this.gesamtgewichtDataGridViewTextBoxColumn.HeaderText = "Gesamtgewicht";
            this.gesamtgewichtDataGridViewTextBoxColumn.Name = "gesamtgewichtDataGridViewTextBoxColumn";
            this.gesamtgewichtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startzeitDataGridViewTextBoxColumn
            // 
            this.startzeitDataGridViewTextBoxColumn.DataPropertyName = "Startzeit";
            this.startzeitDataGridViewTextBoxColumn.HeaderText = "Startzeit";
            this.startzeitDataGridViewTextBoxColumn.Name = "startzeitDataGridViewTextBoxColumn";
            this.startzeitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endzeitDataGridViewTextBoxColumn
            // 
            this.endzeitDataGridViewTextBoxColumn.DataPropertyName = "Endzeit";
            this.endzeitDataGridViewTextBoxColumn.HeaderText = "Endzeit";
            this.endzeitDataGridViewTextBoxColumn.Name = "endzeitDataGridViewTextBoxColumn";
            this.endzeitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 628);
            this.Controls.Add(this.tabPanel);
            this.Name = "MainWindow";
            this.Text = "Fahrradkurier";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabPanel.ResumeLayout(false);
            this.tabFahrer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fahrerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFahrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrerAnzeigenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabAuftraege.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuftraege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2uebungfahrradkurierDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de2_uebung_fahrradkurierDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auftragUebersichtBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tabFahrer;
        private System.Windows.Forms.TabPage tabAuftraege;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewFahrer;
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
        private de2_uebung_fahrradkurierDataSet1 de2_uebung_fahrradkurierDataSet1;
        private System.Windows.Forms.BindingSource fahrerBindingSource;
        private DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet1TableAdapters.FahrerTableAdapter fahrerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewAuftraege;
        private System.Windows.Forms.BindingSource de2uebungfahrradkurierDataSetBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonNeuerAuftrag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private de2_uebung_fahrradkurierDataSet2 de2_uebung_fahrradkurierDataSet2;
        private System.Windows.Forms.BindingSource auftragUebersichtBindingSource;
        private DE2_UE_Fahrradkurier.de2_uebung_fahrradkurierDataSet2TableAdapters.AuftragUebersichtTableAdapter auftragUebersichtTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fahrerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gesamtgewichtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startzeitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endzeitDataGridViewTextBoxColumn;
    }
}

