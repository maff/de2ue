using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DE2_UE_Fahrradkurier
{
    public partial class MainWindow : Form
    {
        private SqlConnection connection = Connection.Get();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'de2_uebung_fahrradkurierDataSet3.AuftragUebersicht' table. You can move, or remove it, as needed.
            this.auftragUebersichtTableAdapter1.Fill(this.de2_uebung_fahrradkurierDataSet3.AuftragUebersicht);
            // TODO: This line of code loads data into the 'de2_uebung_fahrradkurierDataSet2.AuftragUebersicht' table. You can move, or remove it, as needed.
            this.auftragUebersichtTableAdapter.Fill(this.de2_uebung_fahrradkurierDataSet2.AuftragUebersicht);
            // TODO: This line of code loads data into the 'de2_uebung_fahrradkurierDataSet1.Fahrer' table. You can move, or remove it, as needed.
            //this.fahrerTableAdapter.Fill(this.de2_uebung_fahrradkurierDataSet1.Fahrer);
            
            // TODO: This line of code loads data into the 'de2_uebung_fahrradkurierDataSet.FahrerAnzeigen' table. You can move, or remove it, as needed.
            this.fahrerAnzeigenTableAdapter.Fill(this.de2_uebung_fahrradkurierDataSet.FahrerAnzeigen);

        }

        private void buttonNewDriver_Click(object sender, EventArgs e)
        {
            Fahrer fahrerForm = new Fahrer();
            fahrerForm.FormClosed += new FormClosedEventHandler(fahrerForm_FormClosed);
            fahrerForm.ShowDialog();
        }

        void fahrerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reloadFahrerGrid();
        }

        private void buttonNeuerAuftrag_Click(object sender, EventArgs e)
        {
            Auftrag auftragForm = new Auftrag();
            auftragForm.FormClosed += new FormClosedEventHandler(auftragForm_FormClosed);
            auftragForm.ShowDialog();
        }

        void auftragForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reloadAuftragGrid();
        }

        private void MainWindow_ResizeEnd(object sender, EventArgs e)
        {

        }

        void reloadAuftragGrid()
        {
            this.auftragUebersichtTableAdapter1.Fill(this.de2_uebung_fahrradkurierDataSet3.AuftragUebersicht);
        }

        DataGridViewRow selectedAuftragRow;
        private bool fetchSelectedAuftragRow()
        {
            if (dataGridViewAuftraege.SelectedRows.Count == 1)
            {
                this.selectedAuftragRow = dataGridViewAuftraege.SelectedRows[0];
                return true;
            }
            else
            {
                MessageBox.Show("Bitte die gewünschte Auftragszeile markieren");
                return false;
            }
        }

        private void buttonPakete_Click(object sender, EventArgs e)
        {
            if (this.fetchSelectedAuftragRow())
            {
                Paket paket = new Paket(int.Parse(this.selectedAuftragRow.Cells["Auftrag_ID"].Value.ToString()));
                paket.FormClosed += new FormClosedEventHandler(paket_FormClosed);
                paket.ShowDialog();
            }
        }

        void paket_FormClosed(object sender, FormClosedEventArgs e)
        {
            reloadAuftragGrid();
        }

        private void buttonAuftragStarten_Click(object sender, EventArgs e)
        {
            if (this.fetchSelectedAuftragRow())
            {
                AuftragStartStop astst = new AuftragStartStop(int.Parse(this.selectedAuftragRow.Cells["Auftrag_ID"].Value.ToString()), AuftragStartStop.Type.Start);
                astst.FormClosed += new FormClosedEventHandler(astst_FormClosed);
                astst.ShowDialog();
            }
        }

        private void buttonAuftragstoppen_Click(object sender, EventArgs e)
        {
            if (this.fetchSelectedAuftragRow())
            {
                AuftragStartStop astst = new AuftragStartStop(int.Parse(this.selectedAuftragRow.Cells["Auftrag_ID"].Value.ToString()), AuftragStartStop.Type.Stop);
                astst.FormClosed += new FormClosedEventHandler(astst_FormClosed);
                astst.ShowDialog();
            }
        }

        void astst_FormClosed(object sender, FormClosedEventArgs e)
        {
            reloadAuftragGrid();
        }



        DataGridViewRow selectedFahrerRow;
        private bool fetchSelectedFahrerRow()
        {
            if (dataGridViewFahrer.SelectedRows.Count == 1)
            {
                this.selectedFahrerRow = dataGridViewFahrer.SelectedRows[0];
                return true;
            }
            else
            {
                MessageBox.Show("Bitte die gewünschte Fahrerzeile markieren");
                return false;
            }
        }


        void reloadFahrerGrid()
        {
            this.fahrerAnzeigenTableAdapter.Fill(this.de2_uebung_fahrradkurierDataSet.FahrerAnzeigen);
        }


        private void buttonFahrerBearbeiten_Click(object sender, EventArgs e)
        {
            if (this.fetchSelectedFahrerRow())
            {
                Fahrer fahrerForm = new Fahrer(int.Parse(this.selectedFahrerRow.Cells["Fahrer_ID"].Value.ToString()));
                fahrerForm.FormClosed += new FormClosedEventHandler(fahrerForm_FormClosed);
                fahrerForm.ShowDialog();
            }
        }

      
    }
}
