
namespace yt_DesignUI.Forms.TablesFromDB
{
    partial class CarBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarBrand));
            System.Windows.Forms.Label idCarBrandLabel;
            System.Windows.Forms.Label brandNameLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label productionDateStartLabel;
            System.Windows.Forms.Label productionDateEndLabel;
            System.Windows.Forms.Label characteristicLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.trafficPoliceDataSet = new yt_DesignUI.TrafficPoliceDataSet();
            this.carBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBrandTableAdapter = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.CarBrandTableAdapter();
            this.tableAdapterManager = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.TableAdapterManager();
            this.carBrandBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.carBrandBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCarBrandTextBox = new System.Windows.Forms.TextBox();
            this.brandNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.productionDateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productionDateEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.characteristicTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            idCarBrandLabel = new System.Windows.Forms.Label();
            brandNameLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            productionDateStartLabel = new System.Windows.Forms.Label();
            productionDateEndLabel = new System.Windows.Forms.Label();
            characteristicLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandBindingNavigator)).BeginInit();
            this.carBrandBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // egoldsFormStyle1
            // 
            this.egoldsFormStyle1.AllowUserResize = false;
            this.egoldsFormStyle1.BackColor = System.Drawing.Color.MediumPurple;
            this.egoldsFormStyle1.ContextMenuForm = null;
            this.egoldsFormStyle1.ControlBoxButtonsWidth = 30;
            this.egoldsFormStyle1.EnableControlBoxIconsLight = false;
            this.egoldsFormStyle1.EnableControlBoxMouseLight = false;
            this.egoldsFormStyle1.Form = this;
            this.egoldsFormStyle1.FormStyle = yt_DesignUI.Components.EgoldsFormStyle.fStyle.UserStyle;
            this.egoldsFormStyle1.HeaderColor = System.Drawing.Color.RoyalBlue;
            this.egoldsFormStyle1.HeaderColorAdditional = System.Drawing.Color.Tomato;
            this.egoldsFormStyle1.HeaderColorGradientEnable = true;
            this.egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.egoldsFormStyle1.HeaderHeight = 38;
            this.egoldsFormStyle1.HeaderImage = null;
            this.egoldsFormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // trafficPoliceDataSet
            // 
            this.trafficPoliceDataSet.DataSetName = "TrafficPoliceDataSet";
            this.trafficPoliceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBrandBindingSource
            // 
            this.carBrandBindingSource.DataMember = "CarBrand";
            this.carBrandBindingSource.DataSource = this.trafficPoliceDataSet;
            // 
            // carBrandTableAdapter
            // 
            this.carBrandTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarBrandTableAdapter = this.carBrandTableAdapter;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.DriversTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.RanksTableAdapter = null;
            this.tableAdapterManager.StolenCarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = yt_DesignUI.TrafficPoliceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // carBrandBindingNavigator
            // 
            this.carBrandBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carBrandBindingNavigator.BindingSource = this.carBrandBindingSource;
            this.carBrandBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carBrandBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carBrandBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.carBrandBindingNavigatorSaveItem});
            this.carBrandBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carBrandBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carBrandBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carBrandBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carBrandBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carBrandBindingNavigator.Name = "carBrandBindingNavigator";
            this.carBrandBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carBrandBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.carBrandBindingNavigator.TabIndex = 0;
            this.carBrandBindingNavigator.Text = "bindingNavigator1";
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
            // carBrandBindingNavigatorSaveItem
            // 
            this.carBrandBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carBrandBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carBrandBindingNavigatorSaveItem.Image")));
            this.carBrandBindingNavigatorSaveItem.Name = "carBrandBindingNavigatorSaveItem";
            this.carBrandBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.carBrandBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.carBrandBindingNavigatorSaveItem.Click += new System.EventHandler(this.carBrandBindingNavigatorSaveItem_Click);
            // 
            // idCarBrandLabel
            // 
            idCarBrandLabel.AutoSize = true;
            idCarBrandLabel.Location = new System.Drawing.Point(261, 41);
            idCarBrandLabel.Name = "idCarBrandLabel";
            idCarBrandLabel.Size = new System.Drawing.Size(69, 13);
            idCarBrandLabel.TabIndex = 1;
            idCarBrandLabel.Text = "Id Car Brand:";
            // 
            // idCarBrandTextBox
            // 
            this.idCarBrandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "IdCarBrand", true));
            this.idCarBrandTextBox.Location = new System.Drawing.Point(336, 38);
            this.idCarBrandTextBox.Name = "idCarBrandTextBox";
            this.idCarBrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCarBrandTextBox.TabIndex = 2;
            // 
            // brandNameLabel
            // 
            brandNameLabel.AutoSize = true;
            brandNameLabel.Location = new System.Drawing.Point(266, 73);
            brandNameLabel.Name = "brandNameLabel";
            brandNameLabel.Size = new System.Drawing.Size(69, 13);
            brandNameLabel.TabIndex = 3;
            brandNameLabel.Text = "Brand Name:";
            // 
            // brandNameTextBox
            // 
            this.brandNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "BrandName", true));
            this.brandNameTextBox.Location = new System.Drawing.Point(341, 70);
            this.brandNameTextBox.Name = "brandNameTextBox";
            this.brandNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandNameTextBox.TabIndex = 4;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(270, 103);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(85, 13);
            companyNameLabel.TabIndex = 5;
            companyNameLabel.Text = "Company Name:";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(361, 100);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyNameTextBox.TabIndex = 6;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(277, 129);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 7;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(329, 126);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 8;
            // 
            // productionDateStartLabel
            // 
            productionDateStartLabel.AutoSize = true;
            productionDateStartLabel.Location = new System.Drawing.Point(273, 160);
            productionDateStartLabel.Name = "productionDateStartLabel";
            productionDateStartLabel.Size = new System.Drawing.Size(112, 13);
            productionDateStartLabel.TabIndex = 9;
            productionDateStartLabel.Text = "Production Date Start:";
            // 
            // productionDateStartDateTimePicker
            // 
            this.productionDateStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carBrandBindingSource, "ProductionDateStart", true));
            this.productionDateStartDateTimePicker.Location = new System.Drawing.Point(391, 156);
            this.productionDateStartDateTimePicker.Name = "productionDateStartDateTimePicker";
            this.productionDateStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.productionDateStartDateTimePicker.TabIndex = 10;
            // 
            // productionDateEndLabel
            // 
            productionDateEndLabel.AutoSize = true;
            productionDateEndLabel.Location = new System.Drawing.Point(278, 192);
            productionDateEndLabel.Name = "productionDateEndLabel";
            productionDateEndLabel.Size = new System.Drawing.Size(109, 13);
            productionDateEndLabel.TabIndex = 11;
            productionDateEndLabel.Text = "Production Date End:";
            // 
            // productionDateEndDateTimePicker
            // 
            this.productionDateEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carBrandBindingSource, "ProductionDateEnd", true));
            this.productionDateEndDateTimePicker.Location = new System.Drawing.Point(393, 188);
            this.productionDateEndDateTimePicker.Name = "productionDateEndDateTimePicker";
            this.productionDateEndDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.productionDateEndDateTimePicker.TabIndex = 12;
            // 
            // characteristicLabel
            // 
            characteristicLabel.AutoSize = true;
            characteristicLabel.Location = new System.Drawing.Point(299, 229);
            characteristicLabel.Name = "characteristicLabel";
            characteristicLabel.Size = new System.Drawing.Size(74, 13);
            characteristicLabel.TabIndex = 13;
            characteristicLabel.Text = "Characteristic:";
            // 
            // characteristicTextBox
            // 
            this.characteristicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "Characteristic", true));
            this.characteristicTextBox.Location = new System.Drawing.Point(379, 226);
            this.characteristicTextBox.Name = "characteristicTextBox";
            this.characteristicTextBox.Size = new System.Drawing.Size(100, 20);
            this.characteristicTextBox.TabIndex = 14;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(305, 265);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 15;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(363, 262);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 16;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(304, 300);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 17;
            descriptionLabel.Text = "description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(371, 297);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 18;
            // 
            // CarBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(characteristicLabel);
            this.Controls.Add(this.characteristicTextBox);
            this.Controls.Add(productionDateEndLabel);
            this.Controls.Add(this.productionDateEndDateTimePicker);
            this.Controls.Add(productionDateStartLabel);
            this.Controls.Add(this.productionDateStartDateTimePicker);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(brandNameLabel);
            this.Controls.Add(this.brandNameTextBox);
            this.Controls.Add(idCarBrandLabel);
            this.Controls.Add(this.idCarBrandTextBox);
            this.Controls.Add(this.carBrandBindingNavigator);
            this.Name = "CarBrand";
            this.Text = "CarBrand";
            this.Load += new System.EventHandler(this.CarBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandBindingNavigator)).EndInit();
            this.carBrandBindingNavigator.ResumeLayout(false);
            this.carBrandBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.BindingNavigator carBrandBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource carBrandBindingSource;
        private TrafficPoliceDataSet trafficPoliceDataSet;
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
        private System.Windows.Forms.ToolStripButton carBrandBindingNavigatorSaveItem;
        private TrafficPoliceDataSetTableAdapters.CarBrandTableAdapter carBrandTableAdapter;
        private TrafficPoliceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox characteristicTextBox;
        private System.Windows.Forms.DateTimePicker productionDateEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker productionDateStartDateTimePicker;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox brandNameTextBox;
        private System.Windows.Forms.TextBox idCarBrandTextBox;
    }
}