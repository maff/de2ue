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
    public partial class Fahrer : Form
    {
        private SqlConnection connection = Connection.Get();

        public Fahrer()
        {
            InitializeComponent();
        }

        private void Fahrer_Load(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.connection.Open();
            SqlCommand command = new SqlCommand("NeuerFahrer", this.connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Anrede", (SqlString)this.anredeComboBox.Text));
            command.Parameters.Add(new SqlParameter("@Vorname", (SqlString) this.vornameTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Nachname", (SqlString) this.nachnameTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Telefonnummer", (SqlString) this.telefonnummerTextBox.Text));
            command.Parameters.Add(new SqlParameter("@EMail", (SqlString) this.emailTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Strasse", (SqlString) this.strasseTextBox.Text));
            command.Parameters.Add(new SqlParameter("@PLZ", (SqlString) this.PLZTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Ort", (SqlString) this.ortTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Land", (SqlString)this.landTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Geburtsdatum", (SqlDateTime) this.geburtsdatumDateTimePicker.Value));
            command.Parameters.Add(new SqlParameter("@SVNummer", (SqlString)this.SVNummerTextBox.Text));
            command.Parameters.Add(new SqlParameter("@PassNummer", (SqlString) this.passnummerTextBox.Text));

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
