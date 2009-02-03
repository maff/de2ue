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
    public partial class AuftragStartStop : Form
    {
        private SqlConnection connection = Connection.Get();
        public enum Type { Start, Stop };
        private Type type;
        private int auftrag_id;

        public AuftragStartStop(int auftrag_id, Type type)
        {
            InitializeComponent();

            this.auftrag_id = auftrag_id;
            this.type = type;
            
            loadStatusComboBox();
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private SqlCommand getCommand()
        {
            if (this.type == Type.Start)
            {
                return new SqlCommand("AuftragStarten", this.connection);
            }
            else
            {
                return new SqlCommand("AuftragStoppen", this.connection);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.connection.Open();

            SqlCommand command = this.getCommand();            
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Auftrag_ID", (SqlInt32)this.auftrag_id));
            command.Parameters.Add(new SqlParameter("@Statustitel", (SqlString)this.statusComboBox.Text));

            command.ExecuteNonQuery();
            this.connection.Close();
            this.Close();
        }
    }
}
