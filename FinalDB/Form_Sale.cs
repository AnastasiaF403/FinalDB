using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FinalDB
{
    public partial class Form_Sale : Form
    {
        public Form_Sale()
        {
            InitializeComponent();
        }

        private void Form_Sale_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.DBDataSet.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Phone". При необходимости она может быть перемещена или удалена.
            this.phoneTableAdapter.Fill(this.DBDataSet.Phone);

        }

        private void comboBox_Model_SelectedValueChanged(object sender, EventArgs e)
        {
            FormMain.database.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT count(*) FROM Sale "
                                    + " WHERE InvN = "
                                    + this.comboBox_Model.SelectedValue
                                    + " AND Num_of_bon = "
                                    + this.comboBox_Customer.SelectedValue
                                    , FormMain.database);


            try
            {
                int Amount_of_strings = System.Convert.ToInt32(cmd.ExecuteScalar());
                if (Amount_of_strings > 0) this.deleteButton.Enabled = true;
                else this.deleteButton.Enabled = false;
            }
            catch (OleDbException ex) { }
            FormMain.database.Close();
        }

        private void comboBox_Customer_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox_Model_SelectedValueChanged(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            FormMain.database.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Sale WHERE InvN = "
                                    + this.comboBox_Model.SelectedValue +
                                    " AND Num_of_bon = " +
                                    this.comboBox_Customer.SelectedValue
                                    , FormMain.database);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запрос был выполнен успешно", "Запись успешно удалена", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message + "\n" + cmd.CommandText, "Произошла ошибка при удалении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormMain.database.Close();
            addButton.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FormMain.database.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Sale (InvN, Num_of_bon, Date_sale) VALUES (" +
                                                this.comboBox_Model.SelectedValue + ", " +
                                                this.comboBox_Customer.SelectedValue + ", \"" +
                                                this.dateTimePicker_DateSale.Text +
                                                "\")", FormMain.database);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запрос был выполнен успешно", "Запись успешно добaвлена", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message + "\n" + cmd.CommandText, "Произошла ошибка при добавлении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormMain.database.Close();
            deleteButton.Enabled = true;
        }

        private void dateTimePicker_DateSale_ValueChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            if (dateTimePicker_DateSale.Value.Date > thisDay)
            {
                MessageBox.Show("Дата покупки должна быть не позже текущей даты. Выберите корректную дату");
                addButton.Enabled = false;
            }
            else
            {
                addButton.Enabled = true;
            }
        }
    }
}
