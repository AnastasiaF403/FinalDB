namespace FinalDB
{
    partial class Form_Sale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sale));
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBDataSet = new FinalDB.DBDataSet();
            this.comboBox_Customer = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.phoneTableAdapter = new FinalDB.DBDataSetTableAdapters.PhoneTableAdapter();
            this.customerTableAdapter = new FinalDB.DBDataSetTableAdapters.CustomerTableAdapter();
            this.dateTimePicker_DateSale = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Model.DataSource = this.phoneBindingSource;
            this.comboBox_Model.DisplayMember = "Phone_Name";
            this.comboBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(174, 9);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(139, 24);
            this.comboBox_Model.TabIndex = 0;
            this.comboBox_Model.ValueMember = "InvN";
            this.comboBox_Model.SelectedValueChanged += new System.EventHandler(this.comboBox_Model_SelectedValueChanged);
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataMember = "Phone";
            this.phoneBindingSource.DataSource = this.DBDataSet;
            // 
            // DBDataSet
            // 
            this.DBDataSet.DataSetName = "DBDataSet";
            this.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_Customer
            // 
            this.comboBox_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Customer.DataSource = this.customerBindingSource;
            this.comboBox_Customer.DisplayMember = "NameCust";
            this.comboBox_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Customer.FormattingEnabled = true;
            this.comboBox_Customer.Location = new System.Drawing.Point(174, 39);
            this.comboBox_Customer.Name = "comboBox_Customer";
            this.comboBox_Customer.Size = new System.Drawing.Size(139, 24);
            this.comboBox_Customer.TabIndex = 1;
            this.comboBox_Customer.ValueMember = "Num_of_bon";
            this.comboBox_Customer.SelectedValueChanged += new System.EventHandler(this.comboBox_Customer_SelectedValueChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.DBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Модель телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Покупатель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата продажи";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Location = new System.Drawing.Point(13, 110);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 26);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(219, 110);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 26);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // phoneTableAdapter
            // 
            this.phoneTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker_DateSale
            // 
            this.dateTimePicker_DateSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DateSale.Location = new System.Drawing.Point(174, 75);
            this.dateTimePicker_DateSale.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_DateSale.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_DateSale.Name = "dateTimePicker_DateSale";
            this.dateTimePicker_DateSale.Size = new System.Drawing.Size(139, 22);
            this.dateTimePicker_DateSale.TabIndex = 10;
            this.dateTimePicker_DateSale.Value = new System.DateTime(2022, 10, 25, 0, 0, 0, 0);
            this.dateTimePicker_DateSale.ValueChanged += new System.EventHandler(this.dateTimePicker_DateSale_ValueChanged);
            // 
            // Form_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 143);
            this.Controls.Add(this.dateTimePicker_DateSale);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Customer);
            this.Controls.Add(this.comboBox_Model);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 190);
            this.MinimumSize = new System.Drawing.Size(340, 190);
            this.Name = "Form_Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.Form_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.ComboBox comboBox_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private DBDataSet DBDataSet;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private DBDataSetTableAdapters.PhoneTableAdapter phoneTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateSale;
    }
}