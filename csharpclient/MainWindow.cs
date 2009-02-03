﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DE2_UE_Fahrradkurier
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
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
            this.fahrerAnzeigenTableAdapter.Fill(this.de2_uebung_fahrradkurierDataSet.FahrerAnzeigen);
        }

        private void buttonNeuerAuftrag_Click(object sender, EventArgs e)
        {


            Auftrag auftragForm = new Auftrag();
            auftragForm.ShowDialog();
        }
    }
}