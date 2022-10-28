using FinalDB.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FinalDB
{

    public partial class RunSQL : Form
    {
        public static string connectionString = Properties.Settings.Default.DBConnectionString;
        public static OleDbConnection database = new OleDbConnection(connectionString);
        public RunSQL()
        {
            InitializeComponent();
            this.comboBoxTables.SelectedIndex = 0;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(this.textBoxSQL.Text, database);
                DataSet dataSet = new DataSet();

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet);

                this.dataGridViewSQL.DataSource = dataSet.Tables[0];
                this.dataGridViewSQL.Columns[0].Visible = false;
                this.dataGridViewSQL.RowHeadersVisible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при чтении базы данных");
            }
        }

        private void buttonComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM " + "[" + this.comboBoxTables.Text + "]", database);
                DataSet dataSet = new DataSet();

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet);

                this.dataGridViewSQL.DataSource = dataSet.Tables[0];
                this.dataGridViewSQL.Columns[0].Visible = false;
                this.dataGridViewSQL.RowHeadersVisible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при чтении базы данных");
            }
        }
    }
}
