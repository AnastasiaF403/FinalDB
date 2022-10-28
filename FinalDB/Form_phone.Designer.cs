namespace FinalDB
{
    partial class Form_phone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_phone));
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBDataSet = new FinalDB.DBDataSet();
            this.allphBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneAll_DataSet = new FinalDB.PhoneAll_DataSet();
            this.phoneTableAdapter = new FinalDB.DBDataSetTableAdapters.PhoneTableAdapter();
            this.phoneSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleTableAdapter = new FinalDB.DBDataSetTableAdapters.SaleTableAdapter();
            this.all_phTableAdapter = new FinalDB.PhoneAll_DataSetTableAdapters.All_phTableAdapter();
            this.textBoxPhoneName = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPhoneCost = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhoneHDD = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhoneRAM = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhoneCPU = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhoneSize = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhoneRearCam = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhoneFrontCam = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxVerOS = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxOS = new System.Windows.Forms.ComboBox();
            this.oSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new FinalDB.DBDataSetTableAdapters.CompanyTableAdapter();
            this.oSTableAdapter = new FinalDB.DBDataSetTableAdapters.OSTableAdapter();
            this.typeTableAdapter = new FinalDB.DBDataSetTableAdapters.TypeTableAdapter();
            this.addButton = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allphBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneAll_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
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
            // allphBindingSource
            // 
            this.allphBindingSource.DataMember = "All_ph";
            this.allphBindingSource.DataSource = this.phoneAll_DataSet;
            // 
            // phoneAll_DataSet
            // 
            this.phoneAll_DataSet.DataSetName = "PhoneAll_DataSet";
            this.phoneAll_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneTableAdapter
            // 
            this.phoneTableAdapter.ClearBeforeFill = true;
            // 
            // phoneSaleBindingSource
            // 
            this.phoneSaleBindingSource.DataMember = "PhoneSale";
            this.phoneSaleBindingSource.DataSource = this.phoneBindingSource;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // all_phTableAdapter
            // 
            this.all_phTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxPhoneName
            // 
            this.textBoxPhoneName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhoneName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "Phone_Name", true));
            this.textBoxPhoneName.Location = new System.Drawing.Point(180, 30);
            this.textBoxPhoneName.Name = "textBoxPhoneName";
            this.textBoxPhoneName.Size = new System.Drawing.Size(146, 22);
            this.textBoxPhoneName.TabIndex = 3;
            this.textBoxPhoneName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxPhoneCost
            // 
            this.maskedTextBoxPhoneCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhoneCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "PhoneCost", true));
            this.maskedTextBoxPhoneCost.Location = new System.Drawing.Point(180, 56);
            this.maskedTextBoxPhoneCost.Mask = "00000";
            this.maskedTextBoxPhoneCost.Name = "maskedTextBoxPhoneCost";
            this.maskedTextBoxPhoneCost.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxPhoneCost.TabIndex = 15;
            this.maskedTextBoxPhoneCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxPhoneCost.ValidatingType = typeof(int);
            // 
            // maskedTextBoxPhoneHDD
            // 
            this.maskedTextBoxPhoneHDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhoneHDD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "HDD", true));
            this.maskedTextBoxPhoneHDD.Location = new System.Drawing.Point(180, 83);
            this.maskedTextBoxPhoneHDD.Mask = "000";
            this.maskedTextBoxPhoneHDD.Name = "maskedTextBoxPhoneHDD";
            this.maskedTextBoxPhoneHDD.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxPhoneHDD.TabIndex = 16;
            this.maskedTextBoxPhoneHDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxPhoneRAM
            // 
            this.maskedTextBoxPhoneRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhoneRAM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "RAM", true));
            this.maskedTextBoxPhoneRAM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.maskedTextBoxPhoneRAM.Location = new System.Drawing.Point(180, 109);
            this.maskedTextBoxPhoneRAM.Mask = "00";
            this.maskedTextBoxPhoneRAM.Name = "maskedTextBoxPhoneRAM";
            this.maskedTextBoxPhoneRAM.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxPhoneRAM.TabIndex = 17;
            this.maskedTextBoxPhoneRAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxPhoneCPU
            // 
            this.maskedTextBoxPhoneCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhoneCPU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "CPU", true));
            this.maskedTextBoxPhoneCPU.Location = new System.Drawing.Point(180, 135);
            this.maskedTextBoxPhoneCPU.Mask = "00.000";
            this.maskedTextBoxPhoneCPU.Name = "maskedTextBoxPhoneCPU";
            this.maskedTextBoxPhoneCPU.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxPhoneCPU.TabIndex = 18;
            this.maskedTextBoxPhoneCPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxPhoneSize
            // 
            this.maskedTextBoxPhoneSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhoneSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "ScreenSize", true));
            this.maskedTextBoxPhoneSize.Location = new System.Drawing.Point(180, 161);
            this.maskedTextBoxPhoneSize.Mask = "00.00";
            this.maskedTextBoxPhoneSize.Name = "maskedTextBoxPhoneSize";
            this.maskedTextBoxPhoneSize.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxPhoneSize.TabIndex = 19;
            this.maskedTextBoxPhoneSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxPhoneRearCam
            // 
            this.maskedTextBoxPhoneRearCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhoneRearCam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "RearCam", true));
            this.maskedTextBoxPhoneRearCam.Location = new System.Drawing.Point(180, 186);
            this.maskedTextBoxPhoneRearCam.Mask = "000";
            this.maskedTextBoxPhoneRearCam.Name = "maskedTextBoxPhoneRearCam";
            this.maskedTextBoxPhoneRearCam.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxPhoneRearCam.TabIndex = 20;
            this.maskedTextBoxPhoneRearCam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxPhoneFrontCam
            // 
            this.maskedTextBoxPhoneFrontCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhoneFrontCam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "FrontCam", true));
            this.maskedTextBoxPhoneFrontCam.Location = new System.Drawing.Point(180, 212);
            this.maskedTextBoxPhoneFrontCam.Mask = "000";
            this.maskedTextBoxPhoneFrontCam.Name = "maskedTextBoxPhoneFrontCam";
            this.maskedTextBoxPhoneFrontCam.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxPhoneFrontCam.TabIndex = 21;
            this.maskedTextBoxPhoneFrontCam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxVerOS
            // 
            this.maskedTextBoxVerOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxVerOS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "VersionOS", true));
            this.maskedTextBoxVerOS.Location = new System.Drawing.Point(180, 238);
            this.maskedTextBoxVerOS.Mask = "00.00";
            this.maskedTextBoxVerOS.Name = "maskedTextBoxVerOS";
            this.maskedTextBoxVerOS.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxVerOS.TabIndex = 22;
            this.maskedTextBoxVerOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Модель телефона";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "HDD";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "RAM";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "CPU";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Экран";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Основная камера";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Фронтальная камера";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Версия ОС";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "Производитель";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "ОС";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "Тип телефона";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCompany.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phoneBindingSource, "ID_Company", true));
            this.comboBoxCompany.DataSource = this.companyBindingSource;
            this.comboBoxCompany.DisplayMember = "Name_company";
            this.comboBoxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(179, 265);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(147, 23);
            this.comboBoxCompany.TabIndex = 38;
            this.comboBoxCompany.ValueMember = "ID_Company";
            this.comboBoxCompany.SelectedValueChanged += new System.EventHandler(this.comboBoxCompany_SelectedValueChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.DBDataSet;
            // 
            // comboBoxOS
            // 
            this.comboBoxOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOS.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phoneBindingSource, "ID_OS", true));
            this.comboBoxOS.DataSource = this.oSBindingSource;
            this.comboBoxOS.DisplayMember = "Name_OS";
            this.comboBoxOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOS.FormattingEnabled = true;
            this.comboBoxOS.Location = new System.Drawing.Point(180, 294);
            this.comboBoxOS.Name = "comboBoxOS";
            this.comboBoxOS.Size = new System.Drawing.Size(147, 23);
            this.comboBoxOS.TabIndex = 39;
            this.comboBoxOS.ValueMember = "ID_OS";
            this.comboBoxOS.SelectedValueChanged += new System.EventHandler(this.comboBoxOS_SelectedValueChanged);
            // 
            // oSBindingSource
            // 
            this.oSBindingSource.DataMember = "OS";
            this.oSBindingSource.DataSource = this.DBDataSet;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phoneBindingSource, "ID_Type", true));
            this.comboBoxType.DataSource = this.typeBindingSource;
            this.comboBoxType.DisplayMember = "TypeName";
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(180, 323);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(147, 23);
            this.comboBoxType.TabIndex = 40;
            this.comboBoxType.ValueMember = "ID_Type";
            this.comboBoxType.SelectedValueChanged += new System.EventHandler(this.comboBoxType_SelectedValueChanged);
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.DBDataSet;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // oSTableAdapter
            // 
            this.oSTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(268, 353);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 43;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.phoneBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(352, 31);
            this.bindingNavigator1.TabIndex = 44;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::FinalDB.Properties.Resources.icons8_сложение_16__1_;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::FinalDB.Properties.Resources.icons8_удалить_16;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.saveToolStripButton.Text = "&Сохранить";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // Form_phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(352, 378);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxOS);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxVerOS);
            this.Controls.Add(this.maskedTextBoxPhoneFrontCam);
            this.Controls.Add(this.maskedTextBoxPhoneRearCam);
            this.Controls.Add(this.maskedTextBoxPhoneSize);
            this.Controls.Add(this.maskedTextBoxPhoneCPU);
            this.Controls.Add(this.maskedTextBoxPhoneRAM);
            this.Controls.Add(this.maskedTextBoxPhoneHDD);
            this.Controls.Add(this.maskedTextBoxPhoneCost);
            this.Controls.Add(this.textBoxPhoneName);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(545, 425);
            this.MinimumSize = new System.Drawing.Size(370, 425);
            this.Name = "Form_phone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Телефоны";
            this.Load += new System.EventHandler(this.Form_phone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allphBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneAll_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DBDataSet DBDataSet;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private DBDataSetTableAdapters.PhoneTableAdapter phoneTableAdapter;
        private System.Windows.Forms.BindingSource phoneSaleBindingSource;
        private DBDataSetTableAdapters.SaleTableAdapter saleTableAdapter;
        private PhoneAll_DataSet phoneAll_DataSet;
        private System.Windows.Forms.BindingSource allphBindingSource;
        private PhoneAll_DataSetTableAdapters.All_phTableAdapter all_phTableAdapter;
        private System.Windows.Forms.TextBox textBoxPhoneName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneCost;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneHDD;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneRAM;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneCPU;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneSize;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneRearCam;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneFrontCam;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVerOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxOS;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource oSBindingSource;
        private DBDataSetTableAdapters.OSTableAdapter oSTableAdapter;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private DBDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
    }
}