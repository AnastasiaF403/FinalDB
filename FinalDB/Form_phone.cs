using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FinalDB
{
    public partial class Form_phone : Form
    {
        public Form_phone()
        {
            InitializeComponent();
        }

        private void Form_phone_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Type". При необходимости она может быть перемещена или удалена.
            this.typeTableAdapter.Fill(this.DBDataSet.Type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.OS". При необходимости она может быть перемещена или удалена.
            this.oSTableAdapter.Fill(this.DBDataSet.OS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.DBDataSet.Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneAll_DataSet.All_ph". При необходимости она может быть перемещена или удалена.
            this.all_phTableAdapter.Fill(this.phoneAll_DataSet.All_ph);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Sale". При необходимости она может быть перемещена или удалена.
            this.saleTableAdapter.Fill(this.DBDataSet.Sale);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Phone". При необходимости она может быть перемещена или удалена.
            this.phoneTableAdapter.Fill(this.DBDataSet.Phone);
            comboBoxCompany_SelectedValueChanged(sender, e);
        }
                     
        private void deleteButton_Click(object sender, EventArgs e)
        {
            FormMain.database.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Phone WHERE 'Phone_Name' = '"
                                    + this.textBoxPhoneName + "'"
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
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FormMain.database.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Phone (Phone_Name, PhoneCost, HDD, RAM, CPU, ScreenSize, RearCam, FrontCam, VersionOS, ID_Company, ID_Type, ID_OS) VALUES ('" +
                                               this.textBoxPhoneName.Text + "', '" +
                                               this.maskedTextBoxPhoneCost.Text + "', '" +
                                               this.maskedTextBoxPhoneHDD.Text + "', '"+
                                               this.maskedTextBoxPhoneRAM.Text + "', '"+
                                               this.maskedTextBoxPhoneCPU.Text + "', '"+
                                               this.maskedTextBoxPhoneSize.Text + "', '"+
                                               this.maskedTextBoxPhoneRearCam.Text + "', '"+
                                               this.maskedTextBoxPhoneFrontCam.Text + "', '"+
                                               this.maskedTextBoxVerOS.Text + "', '"+
                                               this.comboBoxCompany.SelectedValue + "', '"+ 
                                               this.comboBoxOS.SelectedValue + "', '"+
                                               this.comboBoxType.SelectedValue +
                                               "')", FormMain.database);
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
           
        }

        private void comboBoxCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            FormMain.database.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT count(*) FROM Phone "
                                    + " WHERE Phone_Name = \""
                                    + this.textBoxPhoneName.Text
                                    + "\" AND ID_Type = "
                                    + this.comboBoxType.SelectedValue
                                    +" AND ID_Company = "
                                    + this.comboBoxCompany.SelectedValue
                                    + " AND ID_OS = "
                                    + this.comboBoxOS.SelectedValue
                                    , FormMain.database);


            try
            {
                int Amount_of_strings = System.Convert.ToInt32(cmd.ExecuteScalar());
                if (Amount_of_strings > 0) this.addButton.Enabled = false;
                else this.addButton.Enabled = true;
                //MessageBox.Show("SQL-запрос: \n\n" + cmd.CommandText + "\n\nбыл выполнен успешно, строк = " + x, "Запись найдена", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);            
            }
            catch (OleDbException ex) { }
            FormMain.database.Close();
        }

        private void comboBoxOS_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxCompany_SelectedValueChanged(sender, e);
        }

        private void comboBoxType_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxCompany_SelectedValueChanged(sender, e);
        }
        
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.phoneTableAdapter.Update(DBDataSet.Phone);
        }
    }
}
