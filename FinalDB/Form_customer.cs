using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FinalDB
{
    public partial class Form_customer : Form
    {

        public Form_customer()
        {
            InitializeComponent();
        }


        public static string connectionString = Properties.Settings.Default.DBConnectionString;
        public static OleDbConnection database = new OleDbConnection(connectionString);

        private void Form_customer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Customer"
            this.customerTableAdapter.Fill(this.DBDataSet.Customer);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Update(DBDataSet.Customer);
        }

        private void searchToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = this.searchToolStripTextBox.Text;
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Customer WHERE (Date_of_Birth LIKE '" + temp + "%') OR (NameCust LIKE '"+ temp+ "%')  OR (PhoneNumber LIKE '" + temp + "%')", database);
            DataSet dataSet = new DataSet();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataSet);
            this.dataGridView1.DataSource = dataSet.Tables[0];
            this.dataGridView1.RowHeadersVisible = false;
        }
    }
}
