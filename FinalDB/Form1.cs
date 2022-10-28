using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FinalDB
{
    public partial class FormMain : Form
    {
        public static string connectionString = Properties.Settings.Default.DBConnectionString;
        // Класс выполняющий соединение с БД и запрос к ней: 
        public static OleDbConnection database = new OleDbConnection(connectionString);
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet1.Phone". 
            this.phoneTableAdapter.Fill(this.DBDataSet1.Phone);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Phone". 
            this.phoneTableAdapter.Fill(this.DBDataSet.Phone);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Type". 
            this.typeTableAdapter.Fill(this.DBDataSet.Type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Sale". 
            this.saleTableAdapter.Fill(this.DBDataSet.Sale);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Phone". 
            this.phoneTableAdapter.Fill(this.DBDataSet.Phone);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.OS". 
            this.oSTableAdapter.Fill(this.DBDataSet.OS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Customer". 
            this.customerTableAdapter.Fill(this.DBDataSet.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.Company". 
            this.companyTableAdapter.Fill(this.DBDataSet.Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBDataSet.MainView". 
            this.mainViewTableAdapter.Fill(this.DBDataSet.MainView);
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
         "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.mainDataGridView.DataSource = this.DBDataSet.MainView;
            (mainDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Phone_Name LIKE '{0}%' OR NameCust LIKE '{0}%'", toolStripTextBoxSearch.Text);
           

        }


        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Type form_type = new Form_Type();
            form_type.ShowDialog();
            this.saleTableAdapter.Fill(DBDataSet.Sale);
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Company form_company = new Form_Company();
            form_company.ShowDialog();
            this.saleTableAdapter.Fill(DBDataSet.Sale);
        }

        private void oSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OS form_OS = new Form_OS();
            form_OS.ShowDialog();
            this.saleTableAdapter.Fill(DBDataSet.Sale);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_customer form_customer = new Form_customer();
            form_customer.ShowDialog();
            this.saleTableAdapter.Fill(DBDataSet.Sale);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для учета мобильных телефонов", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_phone form_phone = new Form_phone();
            form_phone.ShowDialog();
            this.saleTableAdapter.Fill(DBDataSet.Sale);
        }

        private void saleStripButton_Click(object sender, EventArgs e)
        {
            Form_Sale form_sale = new Form_Sale();
            form_sale.ShowDialog();
            this.saleTableAdapter.Fill(DBDataSet.Sale);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form_Sale form_sale = new Form_Sale();
            form_sale.ShowDialog();
            this.saleTableAdapter.Fill(DBDataSet.Sale);
        }
    }
    public class CalendarColumn : DataGridViewColumn
    {
        public CalendarColumn()
            : base(new CalendarCell())
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                // Ensure that the cell used for the template is a CalendarCell.
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                {
                    throw new InvalidCastException("Must be a CalendarCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    public class CalendarCell : DataGridViewTextBoxCell
    {

        public CalendarCell()
            : base()
        {
            // Use the short date format.
            this.Style.Format = "d";
        }

        public override void InitializeEditingControl(int rowIndex, object
            initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);
            CalendarEditingControl ctl =
                DataGridView.EditingControl as CalendarEditingControl;
            // Use the default row value when Value property is null.
           /* if (this.Value == null)
            {
                ctl.Value = (DateTime)this.DefaultNewRowValue;
            }
            else
            {
                ctl.Value = (DateTime)this.Value;
            }*/
        }

        public override Type EditType
        {
            get
            {
                // Return the type of the editing control that CalendarCell uses.
                return typeof(CalendarEditingControl);
            }
        }

        public override Type ValueType
        {
            get
            {
                // Return the type of the value that CalendarCell contains.

                return typeof(DateTime);
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                // Use the current date and time as the default value.
                return DateTime.Now;
            }
        }
    }

    class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;

        public CalendarEditingControl()
        {
            this.Format = DateTimePickerFormat.Short;
        }

        // Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
        // property.
        public object EditingControlFormattedValue
        {
            get
            {
                return this.Value.ToShortDateString();
            }
            set
            {
                if (value is String)
                {
                    try
                    {
                        // This will throw an exception of the string is 
                        // null, empty, or not in the format of a date.
                        this.Value = DateTime.Parse((String)value);
                    }
                    catch
                    {
                        // In the case of an exception, just use the 
                        // default value so we're not left with a null
                        // value.
                        this.Value = DateTime.Now;
                    }
                }
            }
        }

        // Implements the 
        // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
        public object GetEditingControlFormattedValue(
            DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        // Implements the 
        // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
        public void ApplyCellStyleToEditingControl(
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
        // property.
        public int EditingControlRowIndex
        {
            get
            {
                return rowIndex;
            }
            set
            {
                rowIndex = value;
            }
        }

        // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
        // method.
        public bool EditingControlWantsInputKey(
            Keys key, bool dataGridViewWantsInputKey)
        {
            // Let the DateTimePicker handle the keys listed.
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
        // method.
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // No preparation needs to be done.
        }

        // Implements the IDataGridViewEditingControl
        // .RepositionEditingControlOnValueChange property.
        public bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }

        // Implements the IDataGridViewEditingControl
        // .EditingControlDataGridView property.
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return dataGridView;
            }
            set
            {
                dataGridView = value;
            }
        }

        // Implements the IDataGridViewEditingControl
        // .EditingControlValueChanged property.
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }
            set
            {
                valueChanged = value;
            }
        }

        // Implements the IDataGridViewEditingControl
        // .EditingPanelCursor property.
        public Cursor EditingPanelCursor
        {
            get
            {
                return base.Cursor;
            }
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            // Notify the DataGridView that the contents of the cell
            // have changed.
            valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}
