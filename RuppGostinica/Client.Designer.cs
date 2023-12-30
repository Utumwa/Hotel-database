
using System;

namespace RuppGostinica
{
    partial class Client
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label secondNameLabel;
            System.Windows.Forms.Label thirdNameLabel;
            System.Windows.Forms.Label passportLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            this.ruppGostinicaDataSet = new RuppGostinica.RuppGostinicaDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new RuppGostinica.RuppGostinicaDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new RuppGostinica.RuppGostinicaDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.thirdNameTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            secondNameLabel = new System.Windows.Forms.Label();
            thirdNameLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(31, 27);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 24;
            nameLabel.Text = "Name:";
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Location = new System.Drawing.Point(31, 53);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new System.Drawing.Size(78, 13);
            secondNameLabel.TabIndex = 26;
            secondNameLabel.Text = "Second Name:";
            // 
            // thirdNameLabel
            // 
            thirdNameLabel.AutoSize = true;
            thirdNameLabel.Location = new System.Drawing.Point(31, 79);
            thirdNameLabel.Name = "thirdNameLabel";
            thirdNameLabel.Size = new System.Drawing.Size(65, 13);
            thirdNameLabel.TabIndex = 28;
            thirdNameLabel.Text = "Third Name:";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(31, 105);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(51, 13);
            passportLabel.TabIndex = 30;
            passportLabel.Text = "Passport:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(31, 132);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(71, 13);
            dateOfBirthLabel.TabIndex = 32;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(31, 157);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 34;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // ruppGostinicaDataSet
            // 
            this.ruppGostinicaDataSet.DataSetName = "RuppGostinicaDataSet";
            this.ruppGostinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.ruppGostinicaDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedTypesTableAdapter = null;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
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
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(118, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 25;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "SecondName", true));
            this.secondNameTextBox.Location = new System.Drawing.Point(118, 50);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.secondNameTextBox.TabIndex = 27;
            // 
            // thirdNameTextBox
            // 
            this.thirdNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ThirdName", true));
            this.thirdNameTextBox.Location = new System.Drawing.Point(118, 76);
            this.thirdNameTextBox.Name = "thirdNameTextBox";
            this.thirdNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.thirdNameTextBox.TabIndex = 29;
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(118, 102);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(200, 20);
            this.passportTextBox.TabIndex = 31;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(118, 128);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 33;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(118, 154);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberTextBox.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(secondNameLabel);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(thirdNameLabel);
            this.Controls.Add(this.thirdNameTextBox);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Name = "Client";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Client_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RuppGostinicaDataSet ruppGostinicaDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private RuppGostinicaDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private RuppGostinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox thirdNameTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private readonly EventHandler Client_Load;
        private System.Windows.Forms.Button button1;
    }
}

