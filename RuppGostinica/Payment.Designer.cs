
namespace RuppGostinica
{
    partial class Payment
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
            System.Windows.Forms.Label iD_EmployeeLabel;
            System.Windows.Forms.Label iD_ClientLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label setAsideLabel;
            System.Windows.Forms.Label sumLabel;
            System.Windows.Forms.Label bonusLabel;
            System.Windows.Forms.Label totalLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.ruppGostinicaDataSet = new RuppGostinica.RuppGostinicaDataSet();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new RuppGostinica.RuppGostinicaDataSetTableAdapters.PaymentsTableAdapter();
            this.tableAdapterManager = new RuppGostinica.RuppGostinicaDataSetTableAdapters.TableAdapterManager();
            this.iD_EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.iD_ClientTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.setAsideTextBox = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            iD_EmployeeLabel = new System.Windows.Forms.Label();
            iD_ClientLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            setAsideLabel = new System.Windows.Forms.Label();
            sumLabel = new System.Windows.Forms.Label();
            bonusLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_EmployeeLabel
            // 
            iD_EmployeeLabel.AutoSize = true;
            iD_EmployeeLabel.Location = new System.Drawing.Point(32, 28);
            iD_EmployeeLabel.Name = "iD_EmployeeLabel";
            iD_EmployeeLabel.Size = new System.Drawing.Size(70, 13);
            iD_EmployeeLabel.TabIndex = 33;
            iD_EmployeeLabel.Text = "ID Employee:";
            // 
            // iD_ClientLabel
            // 
            iD_ClientLabel.AutoSize = true;
            iD_ClientLabel.Location = new System.Drawing.Point(32, 54);
            iD_ClientLabel.Name = "iD_ClientLabel";
            iD_ClientLabel.Size = new System.Drawing.Size(50, 13);
            iD_ClientLabel.TabIndex = 35;
            iD_ClientLabel.Text = "ID Client:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(32, 81);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 37;
            dateLabel.Text = "Date:";
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(32, 106);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(27, 13);
            fIOLabel.TabIndex = 39;
            fIOLabel.Text = "FIO:";
            // 
            // setAsideLabel
            // 
            setAsideLabel.AutoSize = true;
            setAsideLabel.Location = new System.Drawing.Point(32, 132);
            setAsideLabel.Name = "setAsideLabel";
            setAsideLabel.Size = new System.Drawing.Size(55, 13);
            setAsideLabel.TabIndex = 41;
            setAsideLabel.Text = "Set Aside:";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new System.Drawing.Point(32, 158);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(31, 13);
            sumLabel.TabIndex = 43;
            sumLabel.Text = "Sum:";
            // 
            // bonusLabel
            // 
            bonusLabel.AutoSize = true;
            bonusLabel.Location = new System.Drawing.Point(32, 184);
            bonusLabel.Name = "bonusLabel";
            bonusLabel.Size = new System.Drawing.Size(40, 13);
            bonusLabel.TabIndex = 45;
            bonusLabel.Text = "Bonus:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(32, 210);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 47;
            totalLabel.Text = "Total:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Записать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ruppGostinicaDataSet
            // 
            this.ruppGostinicaDataSet.DataSetName = "RuppGostinicaDataSet";
            this.ruppGostinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.ruppGostinicaDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedTypesTableAdapter = null;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.HotelsTableAdapter = null;
            this.tableAdapterManager.KitchenTableAdapter = null;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.NameSkladTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = this.paymentsTableAdapter;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.RoomStatusesTableAdapter = null;
            this.tableAdapterManager.RoomTypesTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.TakenFromWarehouseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RuppGostinica.RuppGostinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // iD_EmployeeTextBox
            // 
            this.iD_EmployeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "ID_Employee", true));
            this.iD_EmployeeTextBox.Location = new System.Drawing.Point(108, 25);
            this.iD_EmployeeTextBox.Name = "iD_EmployeeTextBox";
            this.iD_EmployeeTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_EmployeeTextBox.TabIndex = 34;
            this.iD_EmployeeTextBox.TextChanged += new System.EventHandler(this.iD_EmployeeTextBox_TextChanged);
            // 
            // iD_ClientTextBox
            // 
            this.iD_ClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "ID_Client", true));
            this.iD_ClientTextBox.Location = new System.Drawing.Point(108, 51);
            this.iD_ClientTextBox.Name = "iD_ClientTextBox";
            this.iD_ClientTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_ClientTextBox.TabIndex = 36;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paymentsBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(108, 77);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 38;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(108, 103);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(200, 20);
            this.fIOTextBox.TabIndex = 40;
            // 
            // setAsideTextBox
            // 
            this.setAsideTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "SetAside", true));
            this.setAsideTextBox.Location = new System.Drawing.Point(108, 129);
            this.setAsideTextBox.Name = "setAsideTextBox";
            this.setAsideTextBox.Size = new System.Drawing.Size(200, 20);
            this.setAsideTextBox.TabIndex = 42;
            // 
            // sumTextBox
            // 
            this.sumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "Sum", true));
            this.sumTextBox.Location = new System.Drawing.Point(108, 155);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(200, 20);
            this.sumTextBox.TabIndex = 44;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "Bonus", true));
            this.bonusTextBox.Location = new System.Drawing.Point(108, 181);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(200, 20);
            this.bonusTextBox.TabIndex = 46;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(108, 207);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 48;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 282);
            this.Controls.Add(iD_EmployeeLabel);
            this.Controls.Add(this.iD_EmployeeTextBox);
            this.Controls.Add(iD_ClientLabel);
            this.Controls.Add(this.iD_ClientTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(setAsideLabel);
            this.Controls.Add(this.setAsideTextBox);
            this.Controls.Add(sumLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(bonusLabel);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Payment";
            this.Text = "Оплата";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private RuppGostinicaDataSet ruppGostinicaDataSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private RuppGostinicaDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private RuppGostinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_EmployeeTextBox;
        private System.Windows.Forms.TextBox iD_ClientTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox setAsideTextBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}