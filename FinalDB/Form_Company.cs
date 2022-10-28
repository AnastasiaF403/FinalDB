using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalDB
{
    public partial class Form_Company : Form
    {
        public Form_Company()
        {
            InitializeComponent();
        }

        private void Form_Company_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Company"
            this.companyTableAdapter.Fill(this.DBDataSet.Company);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.companyTableAdapter.Update(DBDataSet.Company);
        }
    }
}
