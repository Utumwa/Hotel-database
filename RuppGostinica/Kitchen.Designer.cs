
namespace RuppGostinica
{
    partial class Kitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitchen));
            System.Windows.Forms.Label iD_SkladLabel;
            System.Windows.Forms.Label hotelIDLabel;
            System.Windows.Forms.Label dataPreparationLabel;
            System.Windows.Forms.Label productLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label buyersNameLabel;
            System.Windows.Forms.Label iD_MenuLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.ruppGostinicaDataSet = new RuppGostinica.RuppGostinicaDataSet();
            this.kitchenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenTableAdapter = new RuppGostinica.RuppGostinicaDataSetTableAdapters.KitchenTableAdapter();
            this.tableAdapterManager = new RuppGostinica.RuppGostinicaDataSetTableAdapters.TableAdapterManager();
            this.kitchenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kitchenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_SkladTextBox = new System.Windows.Forms.TextBox();
            this.hotelIDTextBox = new System.Windows.Forms.TextBox();
            this.dataPreparationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.buyersNameTextBox = new System.Windows.Forms.TextBox();
            this.iD_MenuTextBox = new System.Windows.Forms.TextBox();
            iD_SkladLabel = new System.Windows.Forms.Label();
            hotelIDLabel = new System.Windows.Forms.Label();
            dataPreparationLabel = new System.Windows.Forms.Label();
            productLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            buyersNameLabel = new System.Windows.Forms.Label();
            iD_MenuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenBindingNavigator)).BeginInit();
            this.kitchenBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "ФИО покупателя";
            // 
            // ruppGostinicaDataSet
            // 
            this.ruppGostinicaDataSet.DataSetName = "RuppGostinicaDataSet";
            this.ruppGostinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitchenBindingSource
            // 
            this.kitchenBindingSource.DataMember = "Kitchen";
            this.kitchenBindingSource.DataSource = this.ruppGostinicaDataSet;
            // 
            // kitchenTableAdapter
            // 
            this.kitchenTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KitchenTableAdapter = this.kitchenTableAdapter;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.RoomStatusesTableAdapter = null;
            this.tableAdapterManager.RoomTypesTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.TakenFromWarehouseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RuppGostinica.RuppGostinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kitchenBindingNavigator
            // 
            this.kitchenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kitchenBindingNavigator.BindingSource = this.kitchenBindingSource;
            this.kitchenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kitchenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kitchenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kitchenBindingNavigatorSaveItem});
            this.kitchenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kitchenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kitchenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kitchenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kitchenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kitchenBindingNavigator.Name = "kitchenBindingNavigator";
            this.kitchenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kitchenBindingNavigator.Size = new System.Drawing.Size(342, 25);
            this.kitchenBindingNavigator.TabIndex = 45;
            this.kitchenBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // kitchenBindingNavigatorSaveItem
            // 
            this.kitchenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kitchenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kitchenBindingNavigatorSaveItem.Image")));
            this.kitchenBindingNavigatorSaveItem.Name = "kitchenBindingNavigatorSaveItem";
            this.kitchenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.kitchenBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.kitchenBindingNavigatorSaveItem.Click += new System.EventHandler(this.kitchenBindingNavigatorSaveItem_Click);
            // 
            // iD_SkladLabel
            // 
            iD_SkladLabel.AutoSize = true;
            iD_SkladLabel.Location = new System.Drawing.Point(23, 57);
            iD_SkladLabel.Name = "iD_SkladLabel";
            iD_SkladLabel.Size = new System.Drawing.Size(51, 13);
            iD_SkladLabel.TabIndex = 47;
            iD_SkladLabel.Text = "ID Sklad:";
            // 
            // iD_SkladTextBox
            // 
            this.iD_SkladTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitchenBindingSource, "ID_Sklad", true));
            this.iD_SkladTextBox.Location = new System.Drawing.Point(119, 54);
            this.iD_SkladTextBox.Name = "iD_SkladTextBox";
            this.iD_SkladTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_SkladTextBox.TabIndex = 48;
            // 
            // hotelIDLabel
            // 
            hotelIDLabel.AutoSize = true;
            hotelIDLabel.Location = new System.Drawing.Point(23, 83);
            hotelIDLabel.Name = "hotelIDLabel";
            hotelIDLabel.Size = new System.Drawing.Size(49, 13);
            hotelIDLabel.TabIndex = 49;
            hotelIDLabel.Text = "Hotel ID:";
            // 
            // hotelIDTextBox
            // 
            this.hotelIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitchenBindingSource, "HotelID", true));
            this.hotelIDTextBox.Location = new System.Drawing.Point(119, 80);
            this.hotelIDTextBox.Name = "hotelIDTextBox";
            this.hotelIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.hotelIDTextBox.TabIndex = 50;
            // 
            // dataPreparationLabel
            // 
            dataPreparationLabel.AutoSize = true;
            dataPreparationLabel.Location = new System.Drawing.Point(23, 110);
            dataPreparationLabel.Name = "dataPreparationLabel";
            dataPreparationLabel.Size = new System.Drawing.Size(90, 13);
            dataPreparationLabel.TabIndex = 51;
            dataPreparationLabel.Text = "Data Preparation:";
            // 
            // dataPreparationDateTimePicker
            // 
            this.dataPreparationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kitchenBindingSource, "DataPreparation", true));
            this.dataPreparationDateTimePicker.Location = new System.Drawing.Point(119, 106);
            this.dataPreparationDateTimePicker.Name = "dataPreparationDateTimePicker";
            this.dataPreparationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataPreparationDateTimePicker.TabIndex = 52;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new System.Drawing.Point(23, 135);
            productLabel.Name = "productLabel";
            productLabel.Size = new System.Drawing.Size(47, 13);
            productLabel.TabIndex = 53;
            productLabel.Text = "Product:";
            // 
            // productTextBox
            // 
            this.productTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitchenBindingSource, "Product", true));
            this.productTextBox.Location = new System.Drawing.Point(119, 132);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(200, 20);
            this.productTextBox.TabIndex = 54;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(23, 161);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 55;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitchenBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(119, 158);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantityTextBox.TabIndex = 56;
            // 
            // buyersNameLabel
            // 
            buyersNameLabel.AutoSize = true;
            buyersNameLabel.Location = new System.Drawing.Point(23, 187);
            buyersNameLabel.Name = "buyersNameLabel";
            buyersNameLabel.Size = new System.Drawing.Size(73, 13);
            buyersNameLabel.TabIndex = 57;
            buyersNameLabel.Text = "Buyers Name:";
            // 
            // buyersNameTextBox
            // 
            this.buyersNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitchenBindingSource, "BuyersName", true));
            this.buyersNameTextBox.Location = new System.Drawing.Point(119, 184);
            this.buyersNameTextBox.Name = "buyersNameTextBox";
            this.buyersNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.buyersNameTextBox.TabIndex = 58;
            // 
            // iD_MenuLabel
            // 
            iD_MenuLabel.AutoSize = true;
            iD_MenuLabel.Location = new System.Drawing.Point(23, 213);
            iD_MenuLabel.Name = "iD_MenuLabel";
            iD_MenuLabel.Size = new System.Drawing.Size(51, 13);
            iD_MenuLabel.TabIndex = 59;
            iD_MenuLabel.Text = "ID Menu:";
            // 
            // iD_MenuTextBox
            // 
            this.iD_MenuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitchenBindingSource, "ID_Menu", true));
            this.iD_MenuTextBox.Location = new System.Drawing.Point(119, 210);
            this.iD_MenuTextBox.Name = "iD_MenuTextBox";
            this.iD_MenuTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_MenuTextBox.TabIndex = 60;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 257);
            this.Controls.Add(iD_SkladLabel);
            this.Controls.Add(this.iD_SkladTextBox);
            this.Controls.Add(hotelIDLabel);
            this.Controls.Add(this.hotelIDTextBox);
            this.Controls.Add(dataPreparationLabel);
            this.Controls.Add(this.dataPreparationDateTimePicker);
            this.Controls.Add(productLabel);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(buyersNameLabel);
            this.Controls.Add(this.buyersNameTextBox);
            this.Controls.Add(iD_MenuLabel);
            this.Controls.Add(this.iD_MenuTextBox);
            this.Controls.Add(this.kitchenBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Кухня";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruppGostinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenBindingNavigator)).EndInit();
            this.kitchenBindingNavigator.ResumeLayout(false);
            this.kitchenBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private RuppGostinicaDataSet ruppGostinicaDataSet;
        private System.Windows.Forms.BindingSource kitchenBindingSource;
        private RuppGostinicaDataSetTableAdapters.KitchenTableAdapter kitchenTableAdapter;
        private RuppGostinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kitchenBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kitchenBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_SkladTextBox;
        private System.Windows.Forms.TextBox hotelIDTextBox;
        private System.Windows.Forms.DateTimePicker dataPreparationDateTimePicker;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox buyersNameTextBox;
        private System.Windows.Forms.TextBox iD_MenuTextBox;
    }
}