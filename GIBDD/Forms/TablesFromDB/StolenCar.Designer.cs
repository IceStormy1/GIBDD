
namespace yt_DesignUI.Forms.TablesFromDB
{
    partial class StolenCar
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
            System.Windows.Forms.Label dateOfHijackingLabel;
            System.Windows.Forms.Label dateOfRequestLabel;
            System.Windows.Forms.Label idCarLabel;
            System.Windows.Forms.Label idDriverLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label locationMarkLabel;
            System.Windows.Forms.Label dateFindLabel;
            System.Windows.Forms.Label idWorkerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StolenCar));
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.trafficPoliceDataSet = new yt_DesignUI.TrafficPoliceDataSet();
            this.stolenCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stolenCarTableAdapter = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.StolenCarTableAdapter();
            this.tableAdapterManager = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.TableAdapterManager();
            this.stolenCarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stolenCarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateOfHijackingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfRequestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idCarTextBox = new System.Windows.Forms.TextBox();
            this.idDriverTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.locationMarkTextBox = new System.Windows.Forms.TextBox();
            this.dateFindDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idWorkerTextBox = new System.Windows.Forms.TextBox();
            this.Exit_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Save_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Remove_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Next_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Last_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Add_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Previevs_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.First_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.yt_Button1 = new yt_DesignUI.yt_Button();
            dateOfHijackingLabel = new System.Windows.Forms.Label();
            dateOfRequestLabel = new System.Windows.Forms.Label();
            idCarLabel = new System.Windows.Forms.Label();
            idDriverLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            locationMarkLabel = new System.Windows.Forms.Label();
            dateFindLabel = new System.Windows.Forms.Label();
            idWorkerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolenCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolenCarBindingNavigator)).BeginInit();
            this.stolenCarBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateOfHijackingLabel
            // 
            dateOfHijackingLabel.AutoSize = true;
            dateOfHijackingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateOfHijackingLabel.Location = new System.Drawing.Point(19, 106);
            dateOfHijackingLabel.Name = "dateOfHijackingLabel";
            dateOfHijackingLabel.Size = new System.Drawing.Size(85, 18);
            dateOfHijackingLabel.TabIndex = 30;
            dateOfHijackingLabel.Text = "Дата угона";
            // 
            // dateOfRequestLabel
            // 
            dateOfRequestLabel.AutoSize = true;
            dateOfRequestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateOfRequestLabel.Location = new System.Drawing.Point(19, 142);
            dateOfRequestLabel.Name = "dateOfRequestLabel";
            dateOfRequestLabel.Size = new System.Drawing.Size(124, 18);
            dateOfRequestLabel.TabIndex = 31;
            dateOfRequestLabel.Text = "Дата обращения";
            // 
            // idCarLabel
            // 
            idCarLabel.AutoSize = true;
            idCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idCarLabel.Location = new System.Drawing.Point(19, 172);
            idCarLabel.Name = "idCarLabel";
            idCarLabel.Size = new System.Drawing.Size(126, 18);
            idCarLabel.TabIndex = 32;
            idCarLabel.Text = "Код автомобиля";
            // 
            // idDriverLabel
            // 
            idDriverLabel.AutoSize = true;
            idDriverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idDriverLabel.Location = new System.Drawing.Point(19, 206);
            idDriverLabel.Name = "idDriverLabel";
            idDriverLabel.Size = new System.Drawing.Size(106, 18);
            idDriverLabel.TabIndex = 33;
            idDriverLabel.Text = "Код водителя";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(19, 235);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(166, 18);
            descriptionLabel.TabIndex = 34;
            descriptionLabel.Text = "Обстоятельства угона";
            // 
            // locationMarkLabel
            // 
            locationMarkLabel.AutoSize = true;
            locationMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            locationMarkLabel.Location = new System.Drawing.Point(19, 265);
            locationMarkLabel.Name = "locationMarkLabel";
            locationMarkLabel.Size = new System.Drawing.Size(179, 18);
            locationMarkLabel.TabIndex = 35;
            locationMarkLabel.Text = "Отметка об нахождении";
            // 
            // dateFindLabel
            // 
            dateFindLabel.AutoSize = true;
            dateFindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateFindLabel.Location = new System.Drawing.Point(19, 304);
            dateFindLabel.Name = "dateFindLabel";
            dateFindLabel.Size = new System.Drawing.Size(131, 18);
            dateFindLabel.TabIndex = 36;
            dateFindLabel.Text = "Дата нахождения";
            // 
            // idWorkerLabel
            // 
            idWorkerLabel.AutoSize = true;
            idWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idWorkerLabel.Location = new System.Drawing.Point(19, 338);
            idWorkerLabel.Name = "idWorkerLabel";
            idWorkerLabel.Size = new System.Drawing.Size(120, 18);
            idWorkerLabel.TabIndex = 37;
            idWorkerLabel.Text = "Код сотрудника";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Таблица \"Угнанные автомобили\"";
            // 
            // trafficPoliceDataSet
            // 
            this.trafficPoliceDataSet.DataSetName = "TrafficPoliceDataSet";
            this.trafficPoliceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stolenCarBindingSource
            // 
            this.stolenCarBindingSource.DataMember = "StolenCar";
            this.stolenCarBindingSource.DataSource = this.trafficPoliceDataSet;
            // 
            // stolenCarTableAdapter
            // 
            this.stolenCarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarBrandTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.DriversTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.RanksTableAdapter = null;
            this.tableAdapterManager.StolenCarTableAdapter = this.stolenCarTableAdapter;
            this.tableAdapterManager.UpdateOrder = yt_DesignUI.TrafficPoliceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // stolenCarBindingNavigator
            // 
            this.stolenCarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stolenCarBindingNavigator.BindingSource = this.stolenCarBindingSource;
            this.stolenCarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stolenCarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stolenCarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stolenCarBindingNavigatorSaveItem});
            this.stolenCarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stolenCarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stolenCarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stolenCarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stolenCarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stolenCarBindingNavigator.Name = "stolenCarBindingNavigator";
            this.stolenCarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stolenCarBindingNavigator.Size = new System.Drawing.Size(429, 25);
            this.stolenCarBindingNavigator.TabIndex = 30;
            this.stolenCarBindingNavigator.Text = "bindingNavigator1";
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
            // stolenCarBindingNavigatorSaveItem
            // 
            this.stolenCarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stolenCarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stolenCarBindingNavigatorSaveItem.Image")));
            this.stolenCarBindingNavigatorSaveItem.Name = "stolenCarBindingNavigatorSaveItem";
            this.stolenCarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stolenCarBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.stolenCarBindingNavigatorSaveItem.Click += new System.EventHandler(this.stolenCarBindingNavigatorSaveItem_Click);
            // 
            // dateOfHijackingDateTimePicker
            // 
            this.dateOfHijackingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stolenCarBindingSource, "DateOfHijacking", true));
            this.dateOfHijackingDateTimePicker.Location = new System.Drawing.Point(208, 104);
            this.dateOfHijackingDateTimePicker.Name = "dateOfHijackingDateTimePicker";
            this.dateOfHijackingDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfHijackingDateTimePicker.TabIndex = 31;
            // 
            // dateOfRequestDateTimePicker
            // 
            this.dateOfRequestDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stolenCarBindingSource, "DateOfRequest", true));
            this.dateOfRequestDateTimePicker.Location = new System.Drawing.Point(208, 140);
            this.dateOfRequestDateTimePicker.Name = "dateOfRequestDateTimePicker";
            this.dateOfRequestDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfRequestDateTimePicker.TabIndex = 32;
            // 
            // idCarTextBox
            // 
            this.idCarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stolenCarBindingSource, "IdCar", true));
            this.idCarTextBox.Location = new System.Drawing.Point(208, 173);
            this.idCarTextBox.Name = "idCarTextBox";
            this.idCarTextBox.Size = new System.Drawing.Size(200, 20);
            this.idCarTextBox.TabIndex = 33;
            // 
            // idDriverTextBox
            // 
            this.idDriverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stolenCarBindingSource, "IdDriver", true));
            this.idDriverTextBox.Location = new System.Drawing.Point(208, 207);
            this.idDriverTextBox.Name = "idDriverTextBox";
            this.idDriverTextBox.Size = new System.Drawing.Size(200, 20);
            this.idDriverTextBox.TabIndex = 34;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stolenCarBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(208, 236);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 35;
            // 
            // locationMarkTextBox
            // 
            this.locationMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stolenCarBindingSource, "LocationMark", true));
            this.locationMarkTextBox.Location = new System.Drawing.Point(208, 266);
            this.locationMarkTextBox.Name = "locationMarkTextBox";
            this.locationMarkTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationMarkTextBox.TabIndex = 36;
            // 
            // dateFindDateTimePicker
            // 
            this.dateFindDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stolenCarBindingSource, "DateFind", true));
            this.dateFindDateTimePicker.Location = new System.Drawing.Point(208, 302);
            this.dateFindDateTimePicker.Name = "dateFindDateTimePicker";
            this.dateFindDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateFindDateTimePicker.TabIndex = 37;
            // 
            // idWorkerTextBox
            // 
            this.idWorkerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stolenCarBindingSource, "IdWorker", true));
            this.idWorkerTextBox.Location = new System.Drawing.Point(208, 339);
            this.idWorkerTextBox.Name = "idWorkerTextBox";
            this.idWorkerTextBox.Size = new System.Drawing.Size(200, 20);
            this.idWorkerTextBox.TabIndex = 38;
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
            this.Exit_CarBrand_Button.Location = new System.Drawing.Point(12, 49);
            this.Exit_CarBrand_Button.Name = "Exit_CarBrand_Button";
            this.Exit_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Exit_CarBrand_Button.RoundingEnable = true;
            this.Exit_CarBrand_Button.Size = new System.Drawing.Size(48, 24);
            this.Exit_CarBrand_Button.TabIndex = 69;
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
            this.Save_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Save_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Save_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Save_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Save_CarBrand_Button.Location = new System.Drawing.Point(155, 445);
            this.Save_CarBrand_Button.Name = "Save_CarBrand_Button";
            this.Save_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Save_CarBrand_Button.RoundingEnable = true;
            this.Save_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Save_CarBrand_Button.TabIndex = 68;
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
            this.Remove_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Remove_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Remove_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Remove_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Remove_CarBrand_Button.Location = new System.Drawing.Point(268, 411);
            this.Remove_CarBrand_Button.Name = "Remove_CarBrand_Button";
            this.Remove_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Remove_CarBrand_Button.RoundingEnable = true;
            this.Remove_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Remove_CarBrand_Button.TabIndex = 67;
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
            this.Next_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Next_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Next_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Next_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Next_CarBrand_Button.Location = new System.Drawing.Point(155, 411);
            this.Next_CarBrand_Button.Name = "Next_CarBrand_Button";
            this.Next_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Next_CarBrand_Button.RoundingEnable = true;
            this.Next_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Next_CarBrand_Button.TabIndex = 66;
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
            this.Last_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Last_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Last_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Last_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Last_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Last_CarBrand_Button.Location = new System.Drawing.Point(44, 411);
            this.Last_CarBrand_Button.Name = "Last_CarBrand_Button";
            this.Last_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Last_CarBrand_Button.RoundingEnable = true;
            this.Last_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Last_CarBrand_Button.TabIndex = 65;
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
            this.Add_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Add_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Add_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Add_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Add_CarBrand_Button.Location = new System.Drawing.Point(268, 377);
            this.Add_CarBrand_Button.Name = "Add_CarBrand_Button";
            this.Add_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Add_CarBrand_Button.RoundingEnable = true;
            this.Add_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Add_CarBrand_Button.TabIndex = 64;
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
            this.Previevs_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Previevs_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.Previevs_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previevs_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Previevs_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.Previevs_CarBrand_Button.Location = new System.Drawing.Point(155, 377);
            this.Previevs_CarBrand_Button.Name = "Previevs_CarBrand_Button";
            this.Previevs_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Previevs_CarBrand_Button.RoundingEnable = true;
            this.Previevs_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Previevs_CarBrand_Button.TabIndex = 63;
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
            this.First_CarBrand_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.First_CarBrand_Button.BorderColorOnHoverEnabled = true;
            this.First_CarBrand_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.First_CarBrand_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.First_CarBrand_Button.ForeColor = System.Drawing.Color.White;
            this.First_CarBrand_Button.Location = new System.Drawing.Point(44, 377);
            this.First_CarBrand_Button.Name = "First_CarBrand_Button";
            this.First_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.First_CarBrand_Button.RoundingEnable = true;
            this.First_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.First_CarBrand_Button.TabIndex = 62;
            this.First_CarBrand_Button.Text = "Первая";
            this.First_CarBrand_Button.TextHover = "";
            this.First_CarBrand_Button.UseDownPressEffectOnClick = true;
            this.First_CarBrand_Button.UseRippleEffect = true;
            this.First_CarBrand_Button.UseZoomEffectOnHover = true;
            this.First_CarBrand_Button.Click += new System.EventHandler(this.First_CarBrand_Button_Click);
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.yt_Button1.BackColorAdditional = System.Drawing.Color.Tomato;
            this.yt_Button1.BackColorGradientEnabled = true;
            this.yt_Button1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.yt_Button1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.yt_Button1.BorderColorEnabled = true;
            this.yt_Button1.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.yt_Button1.BorderColorOnHoverEnabled = true;
            this.yt_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(311, 60);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.White;
            this.yt_Button1.RoundingEnable = false;
            this.yt_Button1.Size = new System.Drawing.Size(106, 28);
            this.yt_Button1.TabIndex = 70;
            this.yt_Button1.Text = "Табличный вид";
            this.yt_Button1.TextHover = "";
            this.yt_Button1.UseDownPressEffectOnClick = true;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseZoomEffectOnHover = true;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // StolenCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 493);
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
            this.Controls.Add(dateFindLabel);
            this.Controls.Add(this.dateFindDateTimePicker);
            this.Controls.Add(locationMarkLabel);
            this.Controls.Add(this.locationMarkTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(idDriverLabel);
            this.Controls.Add(this.idDriverTextBox);
            this.Controls.Add(idCarLabel);
            this.Controls.Add(this.idCarTextBox);
            this.Controls.Add(dateOfRequestLabel);
            this.Controls.Add(this.dateOfRequestDateTimePicker);
            this.Controls.Add(dateOfHijackingLabel);
            this.Controls.Add(this.dateOfHijackingDateTimePicker);
            this.Controls.Add(this.stolenCarBindingNavigator);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StolenCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица \"Угнанные автомобили\"";
            this.Load += new System.EventHandler(this.StolenCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolenCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolenCarBindingNavigator)).EndInit();
            this.stolenCarBindingNavigator.ResumeLayout(false);
            this.stolenCarBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.Label label1;
        private TrafficPoliceDataSet trafficPoliceDataSet;
        private System.Windows.Forms.BindingSource stolenCarBindingSource;
        private TrafficPoliceDataSetTableAdapters.StolenCarTableAdapter stolenCarTableAdapter;
        private TrafficPoliceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stolenCarBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stolenCarBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idWorkerTextBox;
        private System.Windows.Forms.DateTimePicker dateFindDateTimePicker;
        private System.Windows.Forms.TextBox locationMarkTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox idDriverTextBox;
        private System.Windows.Forms.TextBox idCarTextBox;
        private System.Windows.Forms.DateTimePicker dateOfRequestDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfHijackingDateTimePicker;
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