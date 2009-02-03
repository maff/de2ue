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
    public partial class Paket : Form
    {
        private SqlConnection connection = Connection.Get();
        private int auftrag_id;

        public Paket(int auftrag_id)
        {
            InitializeComponent();
            this.auftrag_id = auftrag_id;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.connection.Open();
            SqlCommand command = new SqlCommand("NeuesPaket", this.connection);
            command.CommandType = CommandType.StoredProcedure;

            bool fragile = (this.fragileComboBox.Text == "Ja") ? true : false;

            command.Parameters.Add(new SqlParameter("@Auftrag_ID", (SqlInt32)this.auftrag_id));
            command.Parameters.Add(new SqlParameter("@Titel", (SqlString)this.titelTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Hoehe", (SqlDecimal)double.Parse(this.hoeheTextBox.Text)));
            command.Parameters.Add(new SqlParameter("@Breite", (SqlDecimal)double.Parse(this.breiteTextBox.Text)));
            command.Parameters.Add(new SqlParameter("@Tiefe", (SqlDecimal)double.Parse(this.tiefeTextBox.Text)));
            command.Parameters.Add(new SqlParameter("@Gewicht", (SqlDecimal)double.Parse(this.gewichtTextBox.Text)));
            command.Parameters.Add(new SqlParameter("@Fragile", (SqlBoolean)fragile));

            command.ExecuteNonQuery();
            this.connection.Close();
            this.Close();
        }
    }
}
