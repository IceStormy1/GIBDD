
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
            System.Windows.Forms.Label brandNameLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label productionDateStartLabel;
            System.Windows.Forms.Label productionDateEndLabel;
            System.Windows.Forms.Label characteristicLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarBrand));
            this.trafficPoliceDataSet = new yt_DesignUI.TrafficPoliceDataSet();
            this.carBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBrandTableAdapter = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.CarBrandTableAdapter();
            this.tableAdapterManager = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.TableAdapterManager();
            this.carBrandBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.carBrandBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.brandNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.productionDateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productionDateEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.characteristicTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Save_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Remove_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Next_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Last_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Add_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Previevs_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.First_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
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
            // brandNameLabel
            // 
            brandNameLabel.AutoSize = true;
            brandNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            brandNameLabel.Location = new System.Drawing.Point(44, 80);
            brandNameLabel.Name = "brandNameLabel";
            brandNameLabel.Size = new System.Drawing.Size(107, 16);
            brandNameLabel.TabIndex = 3;
            brandNameLabel.Text = "Наименование";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            companyNameLabel.Location = new System.Drawing.Point(44, 110);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(157, 16);
            companyNameLabel.TabIndex = 5;
            companyNameLabel.Text = "Фирма производитель";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            countryLabel.Location = new System.Drawing.Point(44, 136);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(161, 16);
            countryLabel.TabIndex = 7;
            countryLabel.Text = "Страна производитель";
            // 
            // productionDateStartLabel
            // 
            productionDateStartLabel.AutoSize = true;
            productionDateStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productionDateStartLabel.Location = new System.Drawing.Point(44, 166);
            productionDateStartLabel.Name = "productionDateStartLabel";
            productionDateStartLabel.Size = new System.Drawing.Size(188, 16);
            productionDateStartLabel.TabIndex = 9;
            productionDateStartLabel.Text = "Дата начала производства";
            // 
            // productionDateEndLabel
            // 
            productionDateEndLabel.AutoSize = true;
            productionDateEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productionDateEndLabel.Location = new System.Drawing.Point(44, 196);
            productionDateEndLabel.Name = "productionDateEndLabel";
            productionDateEndLabel.Size = new System.Drawing.Size(210, 16);
            productionDateEndLabel.TabIndex = 11;
            productionDateEndLabel.Text = "Дата окончания производства";
            // 
            // characteristicLabel
            // 
            characteristicLabel.AutoSize = true;
            characteristicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            characteristicLabel.Location = new System.Drawing.Point(44, 229);
            characteristicLabel.Name = "characteristicLabel";
            characteristicLabel.Size = new System.Drawing.Size(115, 16);
            characteristicLabel.TabIndex = 13;
            characteristicLabel.Text = "Характеристики";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            categoryLabel.Location = new System.Drawing.Point(44, 265);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(76, 16);
            categoryLabel.TabIndex = 15;
            categoryLabel.Text = "Категория";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(44, 303);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(73, 16);
            descriptionLabel.TabIndex = 17;
            descriptionLabel.Text = "Описание";
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
            this.carBrandBindingNavigator.Size = new System.Drawing.Size(404, 25);
            this.carBrandBindingNavigator.TabIndex = 0;
            this.carBrandBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carBrandBindingNavigatorSaveItem
            // 
            this.carBrandBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carBrandBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carBrandBindingNavigatorSaveItem.Image")));
            this.carBrandBindingNavigatorSaveItem.Name = "carBrandBindingNavigatorSaveItem";
            this.carBrandBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carBrandBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.carBrandBindingNavigatorSaveItem.Click += new System.EventHandler(this.carBrandBindingNavigatorSaveItem_Click);
            // 
            // brandNameTextBox
            // 
            this.brandNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "BrandName", true));
            this.brandNameTextBox.Location = new System.Drawing.Point(270, 76);
            this.brandNameTextBox.Name = "brandNameTextBox";
            this.brandNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.brandNameTextBox.TabIndex = 4;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(270, 106);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.companyNameTextBox.TabIndex = 6;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(270, 132);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(122, 20);
            this.countryTextBox.TabIndex = 8;
            // 
            // productionDateStartDateTimePicker
            // 
            this.productionDateStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carBrandBindingSource, "ProductionDateStart", true));
            this.productionDateStartDateTimePicker.Location = new System.Drawing.Point(270, 166);
            this.productionDateStartDateTimePicker.Name = "productionDateStartDateTimePicker";
            this.productionDateStartDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.productionDateStartDateTimePicker.TabIndex = 10;
            // 
            // productionDateEndDateTimePicker
            // 
            this.productionDateEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carBrandBindingSource, "ProductionDateEnd", true));
            this.productionDateEndDateTimePicker.Location = new System.Drawing.Point(270, 192);
            this.productionDateEndDateTimePicker.Name = "productionDateEndDateTimePicker";
            this.productionDateEndDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.productionDateEndDateTimePicker.TabIndex = 12;
            // 
            // characteristicTextBox
            // 
            this.characteristicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "Characteristic", true));
            this.characteristicTextBox.Location = new System.Drawing.Point(270, 228);
            this.characteristicTextBox.Name = "characteristicTextBox";
            this.characteristicTextBox.Size = new System.Drawing.Size(122, 20);
            this.characteristicTextBox.TabIndex = 14;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(270, 264);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(122, 20);
            this.categoryTextBox.TabIndex = 16;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBrandBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(270, 303);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(122, 20);
            this.descriptionTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Таблица \"Марки автомобилей\"";
            // 
            // Exit_CarBrand_Button
            // 
            this.Exit_CarBrand_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Exit_CarBrand_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.Exit_CarBrand_Button.BackColorGradientEnabled = true;
            this.Exit_CarBrand_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Exit_CarBrand_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Exit_CarBrand_Button.BorderColorEnabled = true;
            this.Exit_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Exit_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Exit_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Exit_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_CarBrand_Button.Location = new System.Drawing.Point(346, 436);
            this.Exit_CarBrand_Button.Name = "Exit_CarBrand_Button";
            this.Exit_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Exit_CarBrand_Button.RoundingEnable = true;
            this.Exit_CarBrand_Button.Size = new System.Drawing.Size(46, 17);
            this.Exit_CarBrand_Button.TabIndex = 27;
            this.Exit_CarBrand_Button.Text = "Выход";
            this.Exit_CarBrand_Button.TextHover = "Открыть все формы";
            this.Exit_CarBrand_Button.UseDownPressEffectOnClick = true;
            this.Exit_CarBrand_Button.UseRippleEffect = true;
            this.Exit_CarBrand_Button.UseZoomEffectOnHover = true;
            this.Exit_CarBrand_Button.Click += new System.EventHandler(this.Exit_CarBrand_Button_Click);
            // 
            // Save_CarBrand_Button
            // 
            this.Save_CarBrand_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Save_CarBrand_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.Save_CarBrand_Button.BackColorGradientEnabled = true;
            this.Save_CarBrand_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Save_CarBrand_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Save_CarBrand_Button.BorderColorEnabled = true;
            this.Save_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Save_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Save_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Save_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Save_CarBrand_Button.Location = new System.Drawing.Point(157, 425);
            this.Save_CarBrand_Button.Name = "Save_CarBrand_Button";
            this.Save_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Save_CarBrand_Button.RoundingEnable = true;
            this.Save_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Save_CarBrand_Button.TabIndex = 26;
            this.Save_CarBrand_Button.Text = "Сохранить";
            this.Save_CarBrand_Button.TextHover = "Открыть все формы";
            this.Save_CarBrand_Button.UseDownPressEffectOnClick = true;
            this.Save_CarBrand_Button.UseRippleEffect = true;
            this.Save_CarBrand_Button.UseZoomEffectOnHover = true;
            this.Save_CarBrand_Button.Click += new System.EventHandler(this.Save_CarBrand_Button_Click);
            // 
            // Remove_CarBrand_Button
            // 
            this.Remove_CarBrand_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Remove_CarBrand_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.Remove_CarBrand_Button.BackColorGradientEnabled = true;
            this.Remove_CarBrand_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Remove_CarBrand_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Remove_CarBrand_Button.BorderColorEnabled = true;
            this.Remove_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Remove_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Remove_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Remove_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Remove_CarBrand_Button.Location = new System.Drawing.Point(270, 391);
            this.Remove_CarBrand_Button.Name = "Remove_CarBrand_Button";
            this.Remove_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Remove_CarBrand_Button.RoundingEnable = true;
            this.Remove_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Remove_CarBrand_Button.TabIndex = 25;
            this.Remove_CarBrand_Button.Text = "Удалить";
            this.Remove_CarBrand_Button.TextHover = "Открыть все формы";
            this.Remove_CarBrand_Button.UseDownPressEffectOnClick = true;
            this.Remove_CarBrand_Button.UseRippleEffect = true;
            this.Remove_CarBrand_Button.UseZoomEffectOnHover = true;
            this.Remove_CarBrand_Button.Click += new System.EventHandler(this.Remove_CarBrand_Button_Click);
            // 
            // Next_CarBrand_Button
            // 
            this.Next_CarBrand_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Next_CarBrand_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.Next_CarBrand_Button.BackColorGradientEnabled = true;
            this.Next_CarBrand_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Next_CarBrand_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Next_CarBrand_Button.BorderColorEnabled = true;
            this.Next_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Next_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Next_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Next_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Next_CarBrand_Button.Location = new System.Drawing.Point(157, 391);
            this.Next_CarBrand_Button.Name = "Next_CarBrand_Button";
            this.Next_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Next_CarBrand_Button.RoundingEnable = true;
            this.Next_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Next_CarBrand_Button.TabIndex = 24;
            this.Next_CarBrand_Button.Text = "Следующая";
            this.Next_CarBrand_Button.TextHover = "Открыть все формы";
            this.Next_CarBrand_Button.UseDownPressEffectOnClick = true;
            this.Next_CarBrand_Button.UseRippleEffect = true;
            this.Next_CarBrand_Button.UseZoomEffectOnHover = true;
            this.Next_CarBrand_Button.Click += new System.EventHandler(this.Next_CarBrand_Button_Click);
            // 
            // Last_CarBrand_Button
            // 
            this.Last_CarBrand_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Last_CarBrand_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.Last_CarBrand_Button.BackColorGradientEnabled = true;
            this.Last_CarBrand_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Last_CarBrand_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Last_CarBrand_Button.BorderColorEnabled = true;
            this.Last_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Last_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Last_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Last_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Last_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Last_CarBrand_Button.Location = new System.Drawing.Point(46, 391);
            this.Last_CarBrand_Button.Name = "Last_CarBrand_Button";
            this.Last_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Last_CarBrand_Button.RoundingEnable = true;
            this.Last_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Last_CarBrand_Button.TabIndex = 23;
            this.Last_CarBrand_Button.Text = "Последняя";
            this.Last_CarBrand_Button.TextHover = "Открыть все формы";
            this.Last_CarBrand_Button.UseDownPressEffectOnClick = true;
            this.Last_CarBrand_Button.UseRippleEffect = true;
            this.Last_CarBrand_Button.UseZoomEffectOnHover = true;
            this.Last_CarBrand_Button.Click += new System.EventHandler(this.Last_CarBrand_Button_Click);
            // 
            // Add_CarBrand_Button
            // 
            this.Add_CarBrand_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Add_CarBrand_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.Add_CarBrand_Button.BackColorGradientEnabled = true;
            this.Add_CarBrand_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Add_CarBrand_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Add_CarBrand_Button.BorderColorEnabled = true;
            this.Add_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Add_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Add_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Add_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Add_CarBrand_Button.Location = new System.Drawing.Point(270, 357);
            this.Add_CarBrand_Button.Name = "Add_CarBrand_Button";
            this.Add_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Add_CarBrand_Button.RoundingEnable = true;
            this.Add_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Add_CarBrand_Button.TabIndex = 21;
            this.Add_CarBrand_Button.Text = "Добавить";
            this.Add_CarBrand_Button.TextHover = "Открыть все формы";
            this.Add_CarBrand_Button.UseDownPressEffectOnClick = true;
            this.Add_CarBrand_Button.UseRippleEffect = true;
            this.Add_CarBrand_Button.UseZoomEffectOnHover = true;
            this.Add_CarBrand_Button.Click += new System.EventHandler(this.Add_CarBrand_Button_Click);
            // 
            // Previevs_CarBrand_Button
            // 
            this.Previevs_CarBrand_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Previevs_CarBrand_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.Previevs_CarBrand_Button.BackColorGradientEnabled = true;
            this.Previevs_CarBrand_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Previevs_CarBrand_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Previevs_CarBrand_Button.BorderColorEnabled = true;
            this.Previevs_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Previevs_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Previevs_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previevs_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Previevs_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Previevs_CarBrand_Button.Location = new System.Drawing.Point(157, 357);
            this.Previevs_CarBrand_Button.Name = "Previevs_CarBrand_Button";
            this.Previevs_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Previevs_CarBrand_Button.RoundingEnable = true;
            this.Previevs_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Previevs_CarBrand_Button.TabIndex = 20;
            this.Previevs_CarBrand_Button.Text = "Предыдущая";
            this.Previevs_CarBrand_Button.TextHover = "Открыть все формы";
            this.Previevs_CarBrand_Button.UseDownPressEffectOnClick = true;
            this.Previevs_CarBrand_Button.UseRippleEffect = true;
            this.Previevs_CarBrand_Button.UseZoomEffectOnHover = true;
            this.Previevs_CarBrand_Button.Click += new System.EventHandler(this.Previevs_CarBrand_Button_Click);
            // 
            // First_CarBrand_Button
            // 
            this.First_CarBrand_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.First_CarBrand_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.First_CarBrand_Button.BackColorGradientEnabled = true;
            this.First_CarBrand_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.First_CarBrand_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.First_CarBrand_Button.BorderColorEnabled = true;
            this.First_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.First_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.First_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.First_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.First_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.First_CarBrand_Button.Location = new System.Drawing.Point(46, 357);
            this.First_CarBrand_Button.Name = "First_CarBrand_Button";
            this.First_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.First_CarBrand_Button.RoundingEnable = true;
            this.First_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.First_CarBrand_Button.TabIndex = 19;
            this.First_CarBrand_Button.Text = "Первая";
            this.First_CarBrand_Button.TextHover = "Открыть все формы";
            this.First_CarBrand_Button.UseDownPressEffectOnClick = true;
            this.First_CarBrand_Button.UseRippleEffect = true;
            this.First_CarBrand_Button.UseZoomEffectOnHover = true;
            this.First_CarBrand_Button.Click += new System.EventHandler(this.First_CarBrand_Button_Click);
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
            // CarBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 464);
            this.Controls.Add(this.Exit_CarBrand_Button);
            this.Controls.Add(this.Save_CarBrand_Button);
            this.Controls.Add(this.Remove_CarBrand_Button);
            this.Controls.Add(this.Next_CarBrand_Button);
            this.Controls.Add(this.Last_CarBrand_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_CarBrand_Button);
            this.Controls.Add(this.Previevs_CarBrand_Button);
            this.Controls.Add(this.First_CarBrand_Button);
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
            this.Controls.Add(this.carBrandBindingNavigator);
            this.Name = "CarBrand";
            this.Text = "Марки автомобилей";
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
        private yt_Button First_CarBrand_Button;
        private yt_Button Save_CarBrand_Button;
        private yt_Button Remove_CarBrand_Button;
        private yt_Button Next_CarBrand_Button;
        private yt_Button Last_CarBrand_Button;
        private System.Windows.Forms.Label label1;
        private yt_Button Add_CarBrand_Button;
        private yt_Button Previevs_CarBrand_Button;
        private yt_Button Exit_CarBrand_Button;
    }
}