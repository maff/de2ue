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
        private int FahrerID;
        private bool isEdit = false;

        public Fahrer()
        {
            InitializeComponent();
        }

        public Fahrer(int Fahrer_ID)
        {
            this.isEdit = true;
            this.FahrerID = Fahrer_ID;
            InitializeComponent();
            this.loadValues();
        }

        private void Fahrer_Load(object sender, EventArgs e)
        {
            this.anredeComboBox.SelectedIndex = 0;
        }

        private void loadValues()
        {
            this.connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM FahrerAnzeigen", this.connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.anredeComboBox.SelectedText = reader["Anrede"].ToString();
                    this.vornameTextBox.Text = reader["Vorname"].ToString();
                    this.nachnameTextBox.Text = reader["Nachname"].ToString();
                    this.telefonnummerTextBox.Text = reader["Telefonnummer"].ToString();
                    this.emailTextBox.Text = reader["Email"].ToString();
                    this.strasseTextBox.Text = reader["Strasse"].ToString();
                    this.PLZTextBox.Text = reader["PLZ"].ToString();
                    this.ortTextBox.Text = reader["Ort"].ToString();
                    this.landTextBox.Text = reader["Land"].ToString();
                    this.geburtsdatumDateTimePicker.Value = DateTime.Parse(reader["Geburtsdatum"].ToString());
                    this.SVNummerTextBox.Text = reader["SVNummer"].ToString();
                    this.passnummerTextBox.Text = reader["Passnummer"].ToString();
                }
            }
            this.connection.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                this.connection.Open();
                SqlCommand command = new SqlCommand("FahrerBearbeiten", this.connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Fahrer_ID", (SqlInt32)this.FahrerID));
                command.Parameters.Add(new SqlParameter("@Anrede", (SqlString)this.anredeComboBox.Text));
                command.Parameters.Add(new SqlParameter("@Vorname", (SqlString)this.vornameTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Nachname", (SqlString)this.nachnameTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Telefonnummer", (SqlString)this.telefonnummerTextBox.Text));
                command.Parameters.Add(new SqlParameter("@EMail", (SqlString)this.emailTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Strasse", (SqlString)this.strasseTextBox.Text));
                command.Parameters.Add(new SqlParameter("@PLZ", (SqlString)this.PLZTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Ort", (SqlString)this.ortTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Land", (SqlString)this.landTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Geburtsdatum", (SqlDateTime)this.geburtsdatumDateTimePicker.Value));
                command.Parameters.Add(new SqlParameter("@SVNummer", (SqlString)this.SVNummerTextBox.Text));
                command.Parameters.Add(new SqlParameter("@PassNummer", (SqlString)this.passnummerTextBox.Text));

                command.ExecuteNonQuery();
                this.connection.Close();
                this.Close();
            }
            else
            {
                this.connection.Open();
                SqlCommand command = new SqlCommand("NeuerFahrer", this.connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Anrede", (SqlString)this.anredeComboBox.Text));
                command.Parameters.Add(new SqlParameter("@Vorname", (SqlString)this.vornameTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Nachname", (SqlString)this.nachnameTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Telefonnummer", (SqlString)this.telefonnummerTextBox.Text));
                command.Parameters.Add(new SqlParameter("@EMail", (SqlString)this.emailTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Strasse", (SqlString)this.strasseTextBox.Text));
                command.Parameters.Add(new SqlParameter("@PLZ", (SqlString)this.PLZTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Ort", (SqlString)this.ortTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Land", (SqlString)this.landTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Geburtsdatum", (SqlDateTime)this.geburtsdatumDateTimePicker.Value));
                command.Parameters.Add(new SqlParameter("@SVNummer", (SqlString)this.SVNummerTextBox.Text));
                command.Parameters.Add(new SqlParameter("@PassNummer", (SqlString)this.passnummerTextBox.Text));

                command.ExecuteNonQuery();
                this.connection.Close();
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
