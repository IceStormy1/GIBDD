
namespace yt_DesignUI.Forms.TablesFromDB
{
    partial class Drivers
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
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label passportLabel;
            System.Windows.Forms.Label numberDriverLicenseLabel;
            System.Windows.Forms.Label dateOfIssueLabel;
            System.Windows.Forms.Label dateEndLicenseLabel;
            System.Windows.Forms.Label licenseCategoryLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label idWorkerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drivers));
            this.label1 = new System.Windows.Forms.Label();
            this.trafficPoliceDataSet = new yt_DesignUI.TrafficPoliceDataSet();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driversTableAdapter = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.DriversTableAdapter();
            this.tableAdapterManager = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.TableAdapterManager();
            this.driversBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.driversBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.numberDriverLicenseTextBox = new System.Windows.Forms.TextBox();
            this.dateOfIssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateEndLicenseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.licenseCategoryTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.idWorkerTextBox = new System.Windows.Forms.TextBox();
            this.Exit_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Save_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Remove_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Next_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Last_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Add_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Previevs_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.First_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.yt_Button1 = new yt_DesignUI.yt_Button();
            fIOLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            numberDriverLicenseLabel = new System.Windows.Forms.Label();
            dateOfIssueLabel = new System.Windows.Forms.Label();
            dateEndLicenseLabel = new System.Windows.Forms.Label();
            licenseCategoryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            idWorkerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).BeginInit();
            this.driversBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fIOLabel.Location = new System.Drawing.Point(16, 82);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(44, 18);
            fIOLabel.TabIndex = 27;
            fIOLabel.Text = "ФИО";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateOfBirthLabel.Location = new System.Drawing.Point(16, 119);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(116, 18);
            dateOfBirthLabel.TabIndex = 28;
            dateOfBirthLabel.Text = "Дата рождения";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            adressLabel.Location = new System.Drawing.Point(16, 154);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(50, 18);
            adressLabel.TabIndex = 29;
            adressLabel.Text = "Адрес";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passportLabel.Location = new System.Drawing.Point(16, 197);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(150, 18);
            passportLabel.TabIndex = 30;
            passportLabel.Text = "Паспортные данные";
            // 
            // numberDriverLicenseLabel
            // 
            numberDriverLicenseLabel.AutoSize = true;
            numberDriverLicenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberDriverLicenseLabel.Location = new System.Drawing.Point(16, 233);
            numberDriverLicenseLabel.Name = "numberDriverLicenseLabel";
            numberDriverLicenseLabel.Size = new System.Drawing.Size(274, 18);
            numberDriverLicenseLabel.TabIndex = 31;
            numberDriverLicenseLabel.Text = "Номер водительского удостоверения";
            // 
            // dateOfIssueLabel
            // 
            dateOfIssueLabel.AutoSize = true;
            dateOfIssueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateOfIssueLabel.Location = new System.Drawing.Point(16, 271);
            dateOfIssueLabel.Name = "dateOfIssueLabel";
            dateOfIssueLabel.Size = new System.Drawing.Size(208, 18);
            dateOfIssueLabel.TabIndex = 32;
            dateOfIssueLabel.Text = "Дата выдачи удостоверения";
            // 
            // dateEndLicenseLabel
            // 
            dateEndLicenseLabel.AutoSize = true;
            dateEndLicenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateEndLicenseLabel.Location = new System.Drawing.Point(16, 302);
            dateEndLicenseLabel.Name = "dateEndLicenseLabel";
            dateEndLicenseLabel.Size = new System.Drawing.Size(230, 18);
            dateEndLicenseLabel.TabIndex = 33;
            dateEndLicenseLabel.Text = "Дата окончания удостоверения";
            // 
            // licenseCategoryLabel
            // 
            licenseCategoryLabel.AutoSize = true;
            licenseCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            licenseCategoryLabel.Location = new System.Drawing.Point(16, 331);
            licenseCategoryLabel.Name = "licenseCategoryLabel";
            licenseCategoryLabel.Size = new System.Drawing.Size(80, 18);
            licenseCategoryLabel.TabIndex = 34;
            licenseCategoryLabel.Text = "Категория";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(16, 363);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(76, 18);
            descriptionLabel.TabIndex = 35;
            descriptionLabel.Text = "Описание";
            // 
            // idWorkerLabel
            // 
            idWorkerLabel.AutoSize = true;
            idWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idWorkerLabel.Location = new System.Drawing.Point(20, 396);
            idWorkerLabel.Name = "idWorkerLabel";
            idWorkerLabel.Size = new System.Drawing.Size(120, 18);
            idWorkerLabel.TabIndex = 36;
            idWorkerLabel.Text = "Код сотрудника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(178, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Таблица \"Водители\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trafficPoliceDataSet
            // 
            this.trafficPoliceDataSet.DataSetName = "TrafficPoliceDataSet";
            this.trafficPoliceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.trafficPoliceDataSet;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarBrandTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.DriversTableAdapter = this.driversTableAdapter;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.RanksTableAdapter = null;
            this.tableAdapterManager.StolenCarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = yt_DesignUI.TrafficPoliceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // driversBindingNavigator
            // 
            this.driversBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.driversBindingNavigator.BindingSource = this.driversBindingSource;
            this.driversBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.driversBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.driversBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.driversBindingNavigatorSaveItem});
            this.driversBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.driversBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.driversBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.driversBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.driversBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.driversBindingNavigator.Name = "driversBindingNavigator";
            this.driversBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.driversBindingNavigator.Size = new System.Drawing.Size(527, 25);
            this.driversBindingNavigator.TabIndex = 27;
            this.driversBindingNavigator.Text = "bindingNavigator1";
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
            // driversBindingNavigatorSaveItem
            // 
            this.driversBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driversBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("driversBindingNavigatorSaveItem.Image")));
            this.driversBindingNavigatorSaveItem.Name = "driversBindingNavigatorSaveItem";
            this.driversBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.driversBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.driversBindingNavigatorSaveItem.Click += new System.EventHandler(this.driversBindingNavigatorSaveItem_Click);
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(348, 80);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(167, 20);
            this.fIOTextBox.TabIndex = 28;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.driversBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(348, 117);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(167, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 29;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(348, 155);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(167, 20);
            this.adressTextBox.TabIndex = 30;
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(348, 198);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(167, 20);
            this.passportTextBox.TabIndex = 31;
            // 
            // numberDriverLicenseTextBox
            // 
            this.numberDriverLicenseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "NumberDriverLicense", true));
            this.numberDriverLicenseTextBox.Location = new System.Drawing.Point(348, 234);
            this.numberDriverLicenseTextBox.Name = "numberDriverLicenseTextBox";
            this.numberDriverLicenseTextBox.Size = new System.Drawing.Size(167, 20);
            this.numberDriverLicenseTextBox.TabIndex = 32;
            // 
            // dateOfIssueDateTimePicker
            // 
            this.dateOfIssueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.driversBindingSource, "DateOfIssue", true));
            this.dateOfIssueDateTimePicker.Location = new System.Drawing.Point(348, 269);
            this.dateOfIssueDateTimePicker.Name = "dateOfIssueDateTimePicker";
            this.dateOfIssueDateTimePicker.Size = new System.Drawing.Size(167, 20);
            this.dateOfIssueDateTimePicker.TabIndex = 33;
            // 
            // dateEndLicenseDateTimePicker
            // 
            this.dateEndLicenseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.driversBindingSource, "DateEndLicense", true));
            this.dateEndLicenseDateTimePicker.Location = new System.Drawing.Point(348, 300);
            this.dateEndLicenseDateTimePicker.Name = "dateEndLicenseDateTimePicker";
            this.dateEndLicenseDateTimePicker.Size = new System.Drawing.Size(167, 20);
            this.dateEndLicenseDateTimePicker.TabIndex = 34;
            // 
            // licenseCategoryTextBox
            // 
            this.licenseCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "LicenseCategory", true));
            this.licenseCategoryTextBox.Location = new System.Drawing.Point(348, 332);
            this.licenseCategoryTextBox.Name = "licenseCategoryTextBox";
            this.licenseCategoryTextBox.Size = new System.Drawing.Size(167, 20);
            this.licenseCategoryTextBox.TabIndex = 35;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(348, 364);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(167, 20);
            this.descriptionTextBox.TabIndex = 36;
            // 
            // idWorkerTextBox
            // 
            this.idWorkerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "IdWorker", true));
            this.idWorkerTextBox.Location = new System.Drawing.Point(348, 397);
            this.idWorkerTextBox.Name = "idWorkerTextBox";
            this.idWorkerTextBox.Size = new System.Drawing.Size(167, 20);
            this.idWorkerTextBox.TabIndex = 37;
            // 
            // Exit_CarBrand_Button
            // 
            this.Exit_CarBrand_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Exit_CarBrand_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.Exit_CarBrand_Button.BackColorGradientEnabled = true;
            this.Exit_CarBrand_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Exit_CarBrand_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Exit_CarBrand_Button.BorderColorEnabled = true;
            this.Exit_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.Exit_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Exit_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Exit_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_CarBrand_Button.Location = new System.Drawing.Point(12, 46);
            this.Exit_CarBrand_Button.Name = "Exit_CarBrand_Button";
            this.Exit_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Exit_CarBrand_Button.RoundingEnable = true;
            this.Exit_CarBrand_Button.Size = new System.Drawing.Size(48, 24);
            this.Exit_CarBrand_Button.TabIndex = 45;
            this.Exit_CarBrand_Button.Text = "Назад";
            this.Exit_CarBrand_Button.TextHover = "";
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
            this.Save_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.Save_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Save_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Save_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Save_CarBrand_Button.Location = new System.Drawing.Point(216, 504);
            this.Save_CarBrand_Button.Name = "Save_CarBrand_Button";
            this.Save_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Save_CarBrand_Button.RoundingEnable = true;
            this.Save_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Save_CarBrand_Button.TabIndex = 44;
            this.Save_CarBrand_Button.Text = "Сохранить";
            this.Save_CarBrand_Button.TextHover = "";
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
            this.Remove_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.Remove_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Remove_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Remove_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Remove_CarBrand_Button.Location = new System.Drawing.Point(329, 470);
            this.Remove_CarBrand_Button.Name = "Remove_CarBrand_Button";
            this.Remove_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Remove_CarBrand_Button.RoundingEnable = true;
            this.Remove_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Remove_CarBrand_Button.TabIndex = 43;
            this.Remove_CarBrand_Button.Text = "Удалить";
            this.Remove_CarBrand_Button.TextHover = "";
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
            this.Next_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.Next_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Next_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Next_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Next_CarBrand_Button.Location = new System.Drawing.Point(216, 470);
            this.Next_CarBrand_Button.Name = "Next_CarBrand_Button";
            this.Next_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Next_CarBrand_Button.RoundingEnable = true;
            this.Next_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Next_CarBrand_Button.TabIndex = 42;
            this.Next_CarBrand_Button.Text = "Следующая";
            this.Next_CarBrand_Button.TextHover = "";
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
            this.Last_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.Last_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Last_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Last_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Last_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Last_CarBrand_Button.Location = new System.Drawing.Point(105, 470);
            this.Last_CarBrand_Button.Name = "Last_CarBrand_Button";
            this.Last_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Last_CarBrand_Button.RoundingEnable = true;
            this.Last_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Last_CarBrand_Button.TabIndex = 41;
            this.Last_CarBrand_Button.Text = "Последняя";
            this.Last_CarBrand_Button.TextHover = "";
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
            this.Add_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.Add_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Add_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Add_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Add_CarBrand_Button.Location = new System.Drawing.Point(329, 436);
            this.Add_CarBrand_Button.Name = "Add_CarBrand_Button";
            this.Add_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Add_CarBrand_Button.RoundingEnable = true;
            this.Add_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Add_CarBrand_Button.TabIndex = 40;
            this.Add_CarBrand_Button.Text = "Добавить";
            this.Add_CarBrand_Button.TextHover = "";
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
            this.Previevs_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.Previevs_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Previevs_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previevs_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Previevs_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Previevs_CarBrand_Button.Location = new System.Drawing.Point(216, 436);
            this.Previevs_CarBrand_Button.Name = "Previevs_CarBrand_Button";
            this.Previevs_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Previevs_CarBrand_Button.RoundingEnable = true;
            this.Previevs_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Previevs_CarBrand_Button.TabIndex = 39;
            this.Previevs_CarBrand_Button.Text = "Предыдущая";
            this.Previevs_CarBrand_Button.TextHover = "";
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
            this.First_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.First_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.First_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.First_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.First_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.First_CarBrand_Button.Location = new System.Drawing.Point(105, 436);
            this.First_CarBrand_Button.Name = "First_CarBrand_Button";
            this.First_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.First_CarBrand_Button.RoundingEnable = true;
            this.First_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.First_CarBrand_Button.TabIndex = 38;
            this.First_CarBrand_Button.Text = "Первая";
            this.First_CarBrand_Button.TextHover = "";
            this.First_CarBrand_Button.UseDownPressEffectOnClick = true;
            this.First_CarBrand_Button.UseRippleEffect = true;
            this.First_CarBrand_Button.UseZoomEffectOnHover = true;
            this.First_CarBrand_Button.Click += new System.EventHandler(this.First_CarBrand_Button_Click);
            // 
            // egoldsFormStyle1
            // 
            this.egoldsFormStyle1.AllowUserResize = false;
            this.egoldsFormStyle1.BackColor = System.Drawing.Color.RosyBrown;
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
            this.egoldsFormStyle1.HeaderHeight = 10;
            this.egoldsFormStyle1.HeaderImage = null;
            this.egoldsFormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.yt_Button1.BackColorAdditional = System.Drawing.Color.Tomato;
            this.yt_Button1.BackColorGradientEnabled = true;
            this.yt_Button1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.yt_Button1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.yt_Button1.BorderColorEnabled = true;
            this.yt_Button1.BorderColorOnHover = System.Drawing.Color.White;
            this.yt_Button1.BorderColorOnHoverEnabled = true;
            this.yt_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(409, 28);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.White;
            this.yt_Button1.RoundingEnable = false;
            this.yt_Button1.Size = new System.Drawing.Size(106, 28);
            this.yt_Button1.TabIndex = 46;
            this.yt_Button1.Text = "Табличный вид";
            this.yt_Button1.TextHover = "";
            this.yt_Button1.UseDownPressEffectOnClick = true;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseZoomEffectOnHover = true;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 553);
            this.Controls.Add(this.yt_Button1);
            this.Controls.Add(this.Exit_CarBrand_Button);
            this.Controls.Add(this.Save_CarBrand_Button);
            this.Controls.Add(this.Remove_CarBrand_Button);
            this.Controls.Add(this.Next_CarBrand_Button);
            this.Controls.Add(this.Last_CarBrand_Button);
            this.Controls.Add(this.Add_CarBrand_Button);
            this.Controls.Add(this.Previevs_CarBrand_Button);
            this.Controls.Add(this.First_CarBrand_Button);
            this.Controls.Add(idWorkerLabel);
            this.Controls.Add(this.idWorkerTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(licenseCategoryLabel);
            this.Controls.Add(this.licenseCategoryTextBox);
            this.Controls.Add(dateEndLicenseLabel);
            this.Controls.Add(this.dateEndLicenseDateTimePicker);
            this.Controls.Add(dateOfIssueLabel);
            this.Controls.Add(this.dateOfIssueDateTimePicker);
            this.Controls.Add(numberDriverLicenseLabel);
            this.Controls.Add(this.numberDriverLicenseTextBox);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(this.driversBindingNavigator);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Drivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица \"Водители\"";
            this.Load += new System.EventHandler(this.Drivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).EndInit();
            this.driversBindingNavigator.ResumeLayout(false);
            this.driversBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.Label label1;
        private TrafficPoliceDataSet trafficPoliceDataSet;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private TrafficPoliceDataSetTableAdapters.DriversTableAdapter driversTableAdapter;
        private TrafficPoliceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator driversBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton driversBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox numberDriverLicenseTextBox;
        private System.Windows.Forms.DateTimePicker dateOfIssueDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateEndLicenseDateTimePicker;
        private System.Windows.Forms.TextBox licenseCategoryTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox idWorkerTextBox;
        private yt_Button Exit_CarBrand_Button;
        private yt_Button Save_CarBrand_Button;
        private yt_Button Remove_CarBrand_Button;
        private yt_Button Next_CarBrand_Button;
        private yt_Button Last_CarBrand_Button;
        private yt_Button Add_CarBrand_Button;
        private yt_Button Previevs_CarBrand_Button;
        private yt_Button First_CarBrand_Button;
        private yt_Button yt_Button1;
    }
}