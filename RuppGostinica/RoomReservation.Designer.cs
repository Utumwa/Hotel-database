
namespace RuppGostinica
{
    partial class Form2
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
            System.Windows.Forms.Label roomIDLabel;
            System.Windows.Forms.Label hotelIDLabel;
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label numberOfPeopleLabel;
            System.Windows.Forms.Label sumLabel;
            System.Windows.Forms.Label dateAndTimeLabel;
            System.Windows.Forms.Label passportDateLabel;
            this.ruppGostinicaDataSet = new RuppGostinica.RuppGostinicaDataSet();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new RuppGostinica.RuppGostinicaDataSetTableAdapters.BookingTableAdapter();
            this.tableAdapterManager = new RuppGostinica.RuppGostinicaDataSetTableAdapters.TableAdapterManager();
            this.iD_EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.iD_ClientTextBox = new System.Windows.Forms.TextBox();
            this.roomIDTextBox = new System.Windows.Forms.TextBox();
            this.hotelIDTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPeopleTextBox = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.dateAndTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.passportDateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            iD_EmployeeLabel = new System.Windows.Forms.Label();
            iD_ClientLabel = new System.Windows.Forms.Label();
            roomIDLabel = new System.Windows.Forms.Label();
            hotelIDLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            numberOfPeopleLabel = new System.Windows.Forms.Label();
            sumLabel = new System.Windows.Forms.Label();
            dateAndTimeLabel = new System.Windows.Forms.Label();
            passportDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_EmployeeLabel
            // 
            iD_EmployeeLabel.AutoSize = true;
            iD_EmployeeLabel.Location = new System.Drawing.Point(15, 33);
            iD_EmployeeLabel.Name = "iD_EmployeeLabel";
            iD_EmployeeLabel.Size = new System.Drawing.Size(70, 13);
            iD_EmployeeLabel.TabIndex = 28;
            iD_EmployeeLabel.Text = "ID Employee:";
            // 
            // iD_ClientLabel
            // 
            iD_ClientLabel.AutoSize = true;
            iD_ClientLabel.Location = new System.Drawing.Point(15, 59);
            iD_ClientLabel.Name = "iD_ClientLabel";
            iD_ClientLabel.Size = new System.Drawing.Size(50, 13);
            iD_ClientLabel.TabIndex = 30;
            iD_ClientLabel.Text = "ID Client:";
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Location = new System.Drawing.Point(15, 85);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new System.Drawing.Size(52, 13);
            roomIDLabel.TabIndex = 32;
            roomIDLabel.Text = "Room ID:";
            // 
            // hotelIDLabel
            // 
            hotelIDLabel.AutoSize = true;
            hotelIDLabel.Location = new System.Drawing.Point(15, 111);
            hotelIDLabel.Name = "hotelIDLabel";
            hotelIDLabel.Size = new System.Drawing.Size(49, 13);
            hotelIDLabel.TabIndex = 34;
            hotelIDLabel.Text = "Hotel ID:";
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(15, 137);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(27, 13);
            fIOLabel.TabIndex = 36;
            fIOLabel.Text = "FIO:";
            // 
            // numberOfPeopleLabel
            // 
            numberOfPeopleLabel.AutoSize = true;
            numberOfPeopleLabel.Location = new System.Drawing.Point(15, 163);
            numberOfPeopleLabel.Name = "numberOfPeopleLabel";
            numberOfPeopleLabel.Size = new System.Drawing.Size(97, 13);
            numberOfPeopleLabel.TabIndex = 38;
            numberOfPeopleLabel.Text = "Number Of People:";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new System.Drawing.Point(15, 189);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(31, 13);
            sumLabel.TabIndex = 40;
            sumLabel.Text = "Sum:";
            // 
            // dateAndTimeLabel
            // 
            dateAndTimeLabel.AutoSize = true;
            dateAndTimeLabel.Location = new System.Drawing.Point(15, 216);
            dateAndTimeLabel.Name = "dateAndTimeLabel";
            dateAndTimeLabel.Size = new System.Drawing.Size(81, 13);
            dateAndTimeLabel.TabIndex = 42;
            dateAndTimeLabel.Text = "Date And Time:";
            // 
            // passportDateLabel
            // 
            passportDateLabel.AutoSize = true;
            passportDateLabel.Location = new System.Drawing.Point(15, 241);
            passportDateLabel.Name = "passportDateLabel";
            passportDateLabel.Size = new System.Drawing.Size(77, 13);
            passportDateLabel.TabIndex = 44;
            passportDateLabel.Text = "Passport Date:";
            // 
            // ruppGostinicaDataSet
            // 
            this.ruppGostinicaDataSet.DataSetName = "RuppGostinicaDataSet";
            this.ruppGostinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.ruppGostinicaDataSet;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedTypesTableAdapter = null;
            this.tableAdapterManager.BookingTableAdapter = this.bookingTableAdapter;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.HotelsTableAdapter = null;
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
            // iD_EmployeeTextBox
            // 
            this.iD_EmployeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "ID_Employee", true));
            this.iD_EmployeeTextBox.Location = new System.Drawing.Point(118, 30);
            this.iD_EmployeeTextBox.Name = "iD_EmployeeTextBox";
            this.iD_EmployeeTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_EmployeeTextBox.TabIndex = 29;
            // 
            // iD_ClientTextBox
            // 
            this.iD_ClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "ID_Client", true));
            this.iD_ClientTextBox.Location = new System.Drawing.Point(118, 56);
            this.iD_ClientTextBox.Name = "iD_ClientTextBox";
            this.iD_ClientTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_ClientTextBox.TabIndex = 31;
            // 
            // roomIDTextBox
            // 
            this.roomIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "RoomID", true));
            this.roomIDTextBox.Location = new System.Drawing.Point(118, 82);
            this.roomIDTextBox.Name = "roomIDTextBox";
            this.roomIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.roomIDTextBox.TabIndex = 33;
            // 
            // hotelIDTextBox
            // 
            this.hotelIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "HotelID", true));
            this.hotelIDTextBox.Location = new System.Drawing.Point(118, 108);
            this.hotelIDTextBox.Name = "hotelIDTextBox";
            this.hotelIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.hotelIDTextBox.TabIndex = 35;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(118, 134);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(200, 20);
            this.fIOTextBox.TabIndex = 37;
            // 
            // numberOfPeopleTextBox
            // 
            this.numberOfPeopleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "NumberOfPeople", true));
            this.numberOfPeopleTextBox.Location = new System.Drawing.Point(118, 160);
            this.numberOfPeopleTextBox.Name = "numberOfPeopleTextBox";
            this.numberOfPeopleTextBox.Size = new System.Drawing.Size(200, 20);
            this.numberOfPeopleTextBox.TabIndex = 39;
            // 
            // sumTextBox
            // 
            this.sumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "Sum", true));
            this.sumTextBox.Location = new System.Drawing.Point(118, 186);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(200, 20);
            this.sumTextBox.TabIndex = 41;
            // 
            // dateAndTimeDateTimePicker
            // 
            this.dateAndTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookingBindingSource, "DateAndTime", true));
            this.dateAndTimeDateTimePicker.Location = new System.Drawing.Point(118, 212);
            this.dateAndTimeDateTimePicker.Name = "dateAndTimeDateTimePicker";
            this.dateAndTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateAndTimeDateTimePicker.TabIndex = 43;
            // 
            // passportDateTextBox
            // 
            this.passportDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "PassportDate", true));
            this.passportDateTextBox.Location = new System.Drawing.Point(118, 238);
            this.passportDateTextBox.Name = "passportDateTextBox";
            this.passportDateTextBox.Size = new System.Drawing.Size(200, 20);
            this.passportDateTextBox.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_EmployeeLabel);
            this.Controls.Add(this.iD_EmployeeTextBox);
            this.Controls.Add(iD_ClientLabel);
            this.Controls.Add(this.iD_ClientTextBox);
            this.Controls.Add(roomIDLabel);
            this.Controls.Add(this.roomIDTextBox);
            this.Controls.Add(hotelIDLabel);
            this.Controls.Add(this.hotelIDTextBox);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(numberOfPeopleLabel);
            this.Controls.Add(this.numberOfPeopleTextBox);
            this.Controls.Add(sumLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(dateAndTimeLabel);
            this.Controls.Add(this.dateAndTimeDateTimePicker);
            this.Controls.Add(passportDateLabel);
            this.Controls.Add(this.passportDateTextBox);
            this.Name = "Form2";
            this.Text = "Бронирование комнаты в отеле";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RuppGostinicaDataSet ruppGostinicaDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private RuppGostinicaDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private RuppGostinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_EmployeeTextBox;
        private System.Windows.Forms.TextBox iD_ClientTextBox;
        private System.Windows.Forms.TextBox roomIDTextBox;
        private System.Windows.Forms.TextBox hotelIDTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox numberOfPeopleTextBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.DateTimePicker dateAndTimeDateTimePicker;
        private System.Windows.Forms.TextBox passportDateTextBox;
        private System.Windows.Forms.Button button1;
    }
}