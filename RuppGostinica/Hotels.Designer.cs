
namespace RuppGostinica
{
    partial class Hotels
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label hotelIDLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.ruppGostinicaDataSet = new RuppGostinica.RuppGostinicaDataSet();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelsTableAdapter = new RuppGostinica.RuppGostinicaDataSetTableAdapters.HotelsTableAdapter();
            this.tableAdapterManager = new RuppGostinica.RuppGostinicaDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.hotelsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelIDTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            hotelIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(18, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 71;
            nameLabel.Text = "Name:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(18, 41);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(42, 13);
            adressLabel.TabIndex = 73;
            adressLabel.Text = "Adress:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(18, 67);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 75;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // hotelIDLabel
            // 
            hotelIDLabel.AutoSize = true;
            hotelIDLabel.Location = new System.Drawing.Point(649, 45);
            hotelIDLabel.Name = "hotelIDLabel";
            hotelIDLabel.Size = new System.Drawing.Size(49, 13);
            hotelIDLabel.TabIndex = 76;
            hotelIDLabel.Text = "Hotel ID:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(211, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 25);
            this.button1.TabIndex = 68;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ruppGostinicaDataSet
            // 
            this.ruppGostinicaDataSet.DataSetName = "RuppGostinicaDataSet";
            this.ruppGostinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataMember = "Hotels";
            this.hotelsBindingSource.DataSource = this.ruppGostinicaDataSet;
            // 
            // hotelsTableAdapter
            // 
            this.hotelsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedTypesTableAdapter = null;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.HotelsTableAdapter = this.hotelsTableAdapter;
            this.tableAdapterManager.KitchenTableAdapter = null;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.NameSkladTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.RoomStatusesTableAdapter = null;
            this.tableAdapterManager.RoomTypesTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.TakenFromWarehouseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RuppGostinica.RuppGostinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(105, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 72;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(105, 38);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(100, 20);
            this.adressTextBox.TabIndex = 74;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(105, 64);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 76;
            // 
            // hotelsDataGridView
            // 
            this.hotelsDataGridView.AutoGenerateColumns = false;
            this.hotelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.hotelsDataGridView.DataSource = this.hotelsBindingSource;
            this.hotelsDataGridView.Location = new System.Drawing.Point(12, 98);
            this.hotelsDataGridView.Name = "hotelsDataGridView";
            this.hotelsDataGridView.Size = new System.Drawing.Size(445, 220);
            this.hotelsDataGridView.TabIndex = 76;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HotelID";
            this.dataGridViewTextBoxColumn1.HeaderText = "HotelID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adress";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // hotelIDTextBox
            // 
            this.hotelIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "HotelID", true));
            this.hotelIDTextBox.Location = new System.Drawing.Point(704, 42);
            this.hotelIDTextBox.Name = "hotelIDTextBox";
            this.hotelIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.hotelIDTextBox.TabIndex = 77;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(211, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 25);
            this.button2.TabIndex = 78;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 330);
            this.Controls.Add(this.button2);
            this.Controls.Add(hotelIDLabel);
            this.Controls.Add(this.hotelIDTextBox);
            this.Controls.Add(this.hotelsDataGridView);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Hotels";
            this.Text = "Отели";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private RuppGostinicaDataSet ruppGostinicaDataSet;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private RuppGostinicaDataSetTableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private RuppGostinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.DataGridView hotelsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox hotelIDTextBox;
        private System.Windows.Forms.Button button2;
    }
}