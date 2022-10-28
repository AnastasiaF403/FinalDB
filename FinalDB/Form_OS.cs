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
    public partial class Form_OS : Form
    {
        public Form_OS()
        {
            InitializeComponent();
        }

        private void Form_OS_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.OS". При необходимости она может быть перемещена или удалена.
            this.oSTableAdapter.Fill(this.DBDataSet.OS);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.oSTableAdapter.Update(DBDataSet.OS);
        }
    }
}
