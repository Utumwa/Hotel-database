
namespace RuppGostinica
{
    partial class Rooms
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
            System.Windows.Forms.Label hotelIDLabel;
            System.Windows.Forms.Label roomTypeLabel;
            System.Windows.Forms.Label bedTypeLabel;
            System.Windows.Forms.Label roomStatusLabel;
            System.Windows.Forms.Label priceLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.ruppGostinicaDataSet = new RuppGostinica.RuppGostinicaDataSet();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new RuppGostinica.RuppGostinicaDataSetTableAdapters.RoomsTableAdapter();
            this.tableAdapterManager = new RuppGostinica.RuppGostinicaDataSetTableAdapters.TableAdapterManager();
            this.hotelIDTextBox = new System.Windows.Forms.TextBox();
            this.roomTypeTextBox = new System.Windows.Forms.TextBox();
            this.bedTypeTextBox = new System.Windows.Forms.TextBox();
            this.roomStatusTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            hotelIDLabel = new System.Windows.Forms.Label();
            roomTypeLabel = new System.Windows.Forms.Label();
            bedTypeLabel = new System.Windows.Forms.Label();
            roomStatusLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelIDLabel
            // 
            hotelIDLabel.AutoSize = true;
            hotelIDLabel.Location = new System.Drawing.Point(85, 35);
            hotelIDLabel.Name = "hotelIDLabel";
            hotelIDLabel.Size = new System.Drawing.Size(49, 13);
            hotelIDLabel.TabIndex = 84;
            hotelIDLabel.Text = "Hotel ID:";
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.Location = new System.Drawing.Point(85, 61);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new System.Drawing.Size(65, 13);
            roomTypeLabel.TabIndex = 86;
            roomTypeLabel.Text = "Room Type:";
            // 
            // bedTypeLabel
            // 
            bedTypeLabel.AutoSize = true;
            bedTypeLabel.Location = new System.Drawing.Point(305, 9);
            bedTypeLabel.Name = "bedTypeLabel";
            bedTypeLabel.Size = new System.Drawing.Size(56, 13);
            bedTypeLabel.TabIndex = 88;
            bedTypeLabel.Text = "Bed Type:";
            // 
            // roomStatusLabel
            // 
            roomStatusLabel.AutoSize = true;
            roomStatusLabel.Location = new System.Drawing.Point(305, 35);
            roomStatusLabel.Name = "roomStatusLabel";
            roomStatusLabel.Size = new System.Drawing.Size(71, 13);
            roomStatusLabel.TabIndex = 90;
            roomStatusLabel.Text = "Room Status:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(305, 61);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 92;
            priceLabel.Text = "Price:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 31);
            this.button1.TabIndex = 80;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ruppGostinicaDataSet
            // 
            this.ruppGostinicaDataSet.DataSetName = "RuppGostinicaDataSet";
            this.ruppGostinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.ruppGostinicaDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.RoomStatusesTableAdapter = null;
            this.tableAdapterManager.RoomTypesTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.TakenFromWarehouseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RuppGostinica.RuppGostinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // hotelIDTextBox
            // 
            this.hotelIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "HotelID", true));
            this.hotelIDTextBox.Location = new System.Drawing.Point(162, 32);
            this.hotelIDTextBox.Name = "hotelIDTextBox";
            this.hotelIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.hotelIDTextBox.TabIndex = 85;
            // 
            // roomTypeTextBox
            // 
            this.roomTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "RoomType", true));
            this.roomTypeTextBox.Location = new System.Drawing.Point(162, 58);
            this.roomTypeTextBox.Name = "roomTypeTextBox";
            this.roomTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomTypeTextBox.TabIndex = 87;
            // 
            // bedTypeTextBox
            // 
            this.bedTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "BedType", true));
            this.bedTypeTextBox.Location = new System.Drawing.Point(382, 6);
            this.bedTypeTextBox.Name = "bedTypeTextBox";
            this.bedTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.bedTypeTextBox.TabIndex = 89;
            // 
            // roomStatusTextBox
            // 
            this.roomStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "RoomStatus", true));
            this.roomStatusTextBox.Location = new System.Drawing.Point(382, 32);
            this.roomStatusTextBox.Name = "roomStatusTextBox";
            this.roomStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomStatusTextBox.TabIndex = 91;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(382, 58);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 93;
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.AutoGenerateColumns = false;
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.roomsDataGridView.DataSource = this.roomsBindingSource;
            this.roomsDataGridView.Location = new System.Drawing.Point(12, 162);
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.Size = new System.Drawing.Size(644, 220);
            this.roomsDataGridView.TabIndex = 93;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RoomID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RoomID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HotelID";
            this.dataGridViewTextBoxColumn2.HeaderText = "HotelID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RoomType";
            this.dataGridViewTextBoxColumn3.HeaderText = "RoomType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BedType";
            this.dataGridViewTextBoxColumn4.HeaderText = "BedType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RoomStatus";
            this.dataGridViewTextBoxColumn5.HeaderText = "RoomStatus";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 31);
            this.button2.TabIndex = 94;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 31);
            this.button3.TabIndex = 95;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 405);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.roomsDataGridView);
            this.Controls.Add(hotelIDLabel);
            this.Controls.Add(this.hotelIDTextBox);
            this.Controls.Add(roomTypeLabel);
            this.Controls.Add(this.roomTypeTextBox);
            this.Controls.Add(bedTypeLabel);
            this.Controls.Add(this.bedTypeTextBox);
            this.Controls.Add(roomStatusLabel);
            this.Controls.Add(this.roomStatusTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Rooms";
            this.Text = "Комнаты";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private RuppGostinicaDataSet ruppGostinicaDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private RuppGostinicaDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private RuppGostinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox hotelIDTextBox;
        private System.Windows.Forms.TextBox roomTypeTextBox;
        private System.Windows.Forms.TextBox bedTypeTextBox;
        private System.Windows.Forms.TextBox roomStatusTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}