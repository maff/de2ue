using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DE2_UE_Fahrradkurier
{
    public partial class Fahrer : Form
    {
        public Fahrer()
        {
            InitializeComponent();
        }

        private void Fahrer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'de2_uebung_fahrradkurierDataSet.FahrerAnzeigen' table. You can move, or remove it, as needed.
            // this.fahrerAnzeigenTableAdapter.Fill(this.de2_uebung_fahrradkurierDataSet.FahrerAnzeigen);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Provider=SQLNCLI.1;Password=sa;Persist Security Info=True;User ID=sa;Initial Catalog=AFStudenten;Data Source=s1-sql");
            SqlCommand;


            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
