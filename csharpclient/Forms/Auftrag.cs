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
    public partial class Auftrag : Form
    {
        private SqlConnection connection = Connection.Get();

        public Auftrag()
        {
            InitializeComponent();
        }

        private void Auftrag_Load(object sender, EventArgs e)
        {
            /*this.fahrerComboBox;
            this.kundeComboBox;
            this.statusComboBox;*/

            this.loadPersonComboBox("SELECT * FROM FahrerAnzeigen", this.fahrerComboBox);
            this.loadPersonComboBox("SELECT * FROM KundenAnzeigen", this.kundeComboBox);
            this.loadStatusComboBox();

        }

        private void loadPersonComboBox(string sqlCommand, ComboBox box)
        {
            this.connection.Open();
            SqlCommand command = new SqlCommand(sqlCommand, this.connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    box.Items.Add(new ComboBoxItem(int.Parse(reader[0].ToString()), reader["Vorname"] + " " + reader["Nachname"]));
                }

                box.SelectedIndex = 0;
            }
            this.connection.Close();
        }


        private void loadStatusComboBox()
        {
            this.connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Status", this.connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   this.statusComboBox.Items.Add(reader["Statustitel"].ToString());
                }

                this.statusComboBox.SelectedIndex = 0;
            }
            this.connection.Close();
        }





        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.connection.Open();
            SqlCommand command = new SqlCommand("NeuerAuftrag", this.connection);
            command.CommandType = CommandType.StoredProcedure;

            ComboBoxItem fahrer = (ComboBoxItem)this.fahrerComboBox.SelectedItem;
            ComboBoxItem kunde = (ComboBoxItem)this.kundeComboBox.SelectedItem;

            command.Parameters.Add(new SqlParameter("@Fahrer_ID", (SqlInt32)fahrer.Key));
            command.Parameters.Add(new SqlParameter("@Kunde_ID", (SqlInt32)kunde.Key));
            command.Parameters.Add(new SqlParameter("@Statustitel", (SqlString)this.statusComboBox.Text));
            command.Parameters.Add(new SqlParameter("@Kilometer", (SqlDecimal)double.Parse(this.kilometerTextBox.Text)));
            command.Parameters.Add(new SqlParameter("@Strasse", (SqlString)this.strasseTextBox.Text));
            command.Parameters.Add(new SqlParameter("@PLZ", (SqlString)this.PLZTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Ort", (SqlString)this.ortTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Land", (SqlString)this.landTextBox.Text));

            command.ExecuteNonQuery();
            this.connection.Close();
            this.Close();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
