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
    public partial class Form_Type : Form
    {
        public Form_Type()
        {
            InitializeComponent();
        }

        private void Form_Type_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Type". 
            this.typeTableAdapter.Fill(this.DBDataSet.Type);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.typeTableAdapter.Update(DBDataSet.Type);
        }
    }
}
