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
                   this.statusComboBox.Items.Add(new ComboBoxItem(int.Parse(reader[0].ToString()), reader["Statustitel"].ToString()));
                }
            }
            this.connection.Close();
        }





        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (fahrerComboBox.SelectedItem.ToString() == "" ||
                kundeComboBox.SelectedItem.ToString() == "" ||
                statusComboBox.SelectedItem.ToString() == "")
            {
                return;
            }
            else
            {
                MessageBox.Show("ok");
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
