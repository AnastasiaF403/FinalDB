namespace FinalDB
{
    partial class RunSQL
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
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.dataGridViewSQL = new System.Windows.Forms.DataGridView();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.buttonComboBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSQL
            // 
            this.textBoxSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSQL.Location = new System.Drawing.Point(13, 13);
            this.textBoxSQL.Name = "textBoxSQL";
            this.textBoxSQL.Size = new System.Drawing.Size(319, 22);
            this.textBoxSQL.TabIndex = 0;
            this.textBoxSQL.Text = "SELECT * FROM Phone";
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(338, 12);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(64, 23);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // dataGridViewSQL
            // 
            this.dataGridViewSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSQL.Location = new System.Drawing.Point(13, 71);
            this.dataGridViewSQL.Name = "dataGridViewSQL";
            this.dataGridViewSQL.RowTemplate.Height = 24;
            this.dataGridViewSQL.Size = new System.Drawing.Size(388, 200);
            this.dataGridViewSQL.TabIndex = 2;
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Items.AddRange(new object[] {
            "Phone",
            "Customer",
            "Sale",
            "Type",
            "Company",
            "OS"});
            this.comboBoxTables.Location = new System.Drawing.Point(12, 41);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(320, 24);
            this.comboBoxTables.TabIndex = 3;
            // 
            // buttonComboBox
            // 
            this.buttonComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonComboBox.Location = new System.Drawing.Point(338, 42);
            this.buttonComboBox.Name = "buttonComboBox";
            this.buttonComboBox.Size = new System.Drawing.Size(64, 23);
            this.buttonComboBox.TabIndex = 4;
            this.buttonComboBox.Text = "RUN";
            this.buttonComboBox.UseVisualStyleBackColor = true;
            this.buttonComboBox.Click += new System.EventHandler(this.buttonComboBox_Click);
            // 
            // RunSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 283);
            this.Controls.Add(this.buttonComboBox);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.dataGridViewSQL);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxSQL);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "RunSQL";
            this.Text = "Новый запрос";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSQL;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.DataGridView dataGridViewSQL;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Button buttonComboBox;
    }
}