
namespace yt_DesignUI.Forms.TablesFromDB
{
    partial class Ranks
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
            System.Windows.Forms.Label rankNameLabel;
            System.Windows.Forms.Label allowanceLabel;
            System.Windows.Forms.Label dutiesLabel;
            System.Windows.Forms.Label requirementsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranks));
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.trafficPoliceDataSet = new yt_DesignUI.TrafficPoliceDataSet();
            this.ranksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranksTableAdapter = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.RanksTableAdapter();
            this.tableAdapterManager = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.TableAdapterManager();
            this.ranksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ranksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rankNameTextBox = new System.Windows.Forms.TextBox();
            this.allowanceTextBox = new System.Windows.Forms.TextBox();
            this.dutiesTextBox = new System.Windows.Forms.TextBox();
            this.requirementsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Save_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Remove_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Next_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Last_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Add_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.Previevs_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.First_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.yt_Button1 = new yt_DesignUI.yt_Button();
            rankNameLabel = new System.Windows.Forms.Label();
            allowanceLabel = new System.Windows.Forms.Label();
            dutiesLabel = new System.Windows.Forms.Label();
            requirementsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingNavigator)).BeginInit();
            this.ranksBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // rankNameLabel
            // 
            rankNameLabel.AutoSize = true;
            rankNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            rankNameLabel.Location = new System.Drawing.Point(47, 119);
            rankNameLabel.Name = "rankNameLabel";
            rankNameLabel.Size = new System.Drawing.Size(111, 18);
            rankNameLabel.TabIndex = 1;
            rankNameLabel.Text = "Наименование";
            // 
            // allowanceLabel
            // 
            allowanceLabel.AutoSize = true;
            allowanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            allowanceLabel.Location = new System.Drawing.Point(47, 157);
            allowanceLabel.Name = "allowanceLabel";
            allowanceLabel.Size = new System.Drawing.Size(77, 18);
            allowanceLabel.TabIndex = 3;
            allowanceLabel.Text = "Надбавка";
            // 
            // dutiesLabel
            // 
            dutiesLabel.AutoSize = true;
            dutiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dutiesLabel.Location = new System.Drawing.Point(47, 193);
            dutiesLabel.Name = "dutiesLabel";
            dutiesLabel.Size = new System.Drawing.Size(101, 18);
            dutiesLabel.TabIndex = 5;
            dutiesLabel.Text = "Обязанности";
            // 
            // requirementsLabel
            // 
            requirementsLabel.AutoSize = true;
            requirementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            requirementsLabel.Location = new System.Drawing.Point(47, 228);
            requirementsLabel.Name = "requirementsLabel";
            requirementsLabel.Size = new System.Drawing.Size(91, 18);
            requirementsLabel.TabIndex = 7;
            requirementsLabel.Text = "Требования";
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
            // trafficPoliceDataSet
            // 
            this.trafficPoliceDataSet.DataSetName = "TrafficPoliceDataSet";
            this.trafficPoliceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ranksBindingSource
            // 
            this.ranksBindingSource.DataMember = "Ranks";
            this.ranksBindingSource.DataSource = this.trafficPoliceDataSet;
            // 
            // ranksTableAdapter
            // 
            this.ranksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarBrandTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.DriversTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.RanksTableAdapter = this.ranksTableAdapter;
            this.tableAdapterManager.StolenCarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = yt_DesignUI.TrafficPoliceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // ranksBindingNavigator
            // 
            this.ranksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ranksBindingNavigator.BindingSource = this.ranksBindingSource;
            this.ranksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ranksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ranksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ranksBindingNavigatorSaveItem});
            this.ranksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ranksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ranksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ranksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ranksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ranksBindingNavigator.Name = "ranksBindingNavigator";
            this.ranksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ranksBindingNavigator.Size = new System.Drawing.Size(339, 25);
            this.ranksBindingNavigator.TabIndex = 0;
            this.ranksBindingNavigator.Text = "bindingNavigator1";
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
            // ranksBindingNavigatorSaveItem
            // 
            this.ranksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ranksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ranksBindingNavigatorSaveItem.Image")));
            this.ranksBindingNavigatorSaveItem.Name = "ranksBindingNavigatorSaveItem";
            this.ranksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ranksBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ranksBindingNavigatorSaveItem.Click += new System.EventHandler(this.ranksBindingNavigatorSaveItem_Click_1);
            // 
            // rankNameTextBox
            // 
            this.rankNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ranksBindingSource, "RankName", true));
            this.rankNameTextBox.Location = new System.Drawing.Point(184, 120);
            this.rankNameTextBox.Name = "rankNameTextBox";
            this.rankNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.rankNameTextBox.TabIndex = 2;
            // 
            // allowanceTextBox
            // 
            this.allowanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ranksBindingSource, "Allowance", true));
            this.allowanceTextBox.Location = new System.Drawing.Point(184, 158);
            this.allowanceTextBox.Name = "allowanceTextBox";
            this.allowanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.allowanceTextBox.TabIndex = 4;
            // 
            // dutiesTextBox
            // 
            this.dutiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ranksBindingSource, "Duties", true));
            this.dutiesTextBox.Location = new System.Drawing.Point(184, 194);
            this.dutiesTextBox.Name = "dutiesTextBox";
            this.dutiesTextBox.Size = new System.Drawing.Size(100, 20);
            this.dutiesTextBox.TabIndex = 6;
            // 
            // requirementsTextBox
            // 
            this.requirementsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ranksBindingSource, "Requirements", true));
            this.requirementsTextBox.Location = new System.Drawing.Point(184, 229);
            this.requirementsTextBox.Name = "requirementsTextBox";
            this.requirementsTextBox.Size = new System.Drawing.Size(100, 20);
            this.requirementsTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Таблица \"Звания\"";
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
            this.Exit_CarBrand_Button.Location = new System.Drawing.Point(9, 64);
            this.Exit_CarBrand_Button.Name = "Exit_CarBrand_Button";
            this.Exit_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Exit_CarBrand_Button.RoundingEnable = true;
            this.Exit_CarBrand_Button.Size = new System.Drawing.Size(48, 24);
            this.Exit_CarBrand_Button.TabIndex = 61;
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
            this.Save_CarBrand_Button.Location = new System.Drawing.Point(120, 358);
            this.Save_CarBrand_Button.Name = "Save_CarBrand_Button";
            this.Save_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Save_CarBrand_Button.RoundingEnable = true;
            this.Save_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Save_CarBrand_Button.TabIndex = 60;
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
            this.Remove_CarBrand_Button.Location = new System.Drawing.Point(233, 324);
            this.Remove_CarBrand_Button.Name = "Remove_CarBrand_Button";
            this.Remove_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Remove_CarBrand_Button.RoundingEnable = true;
            this.Remove_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Remove_CarBrand_Button.TabIndex = 59;
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
            this.Next_CarBrand_Button.Location = new System.Drawing.Point(120, 324);
            this.Next_CarBrand_Button.Name = "Next_CarBrand_Button";
            this.Next_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Next_CarBrand_Button.RoundingEnable = true;
            this.Next_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Next_CarBrand_Button.TabIndex = 58;
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
            this.Last_CarBrand_Button.Location = new System.Drawing.Point(9, 324);
            this.Last_CarBrand_Button.Name = "Last_CarBrand_Button";
            this.Last_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Last_CarBrand_Button.RoundingEnable = true;
            this.Last_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Last_CarBrand_Button.TabIndex = 57;
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
            this.Add_CarBrand_Button.Location = new System.Drawing.Point(233, 290);
            this.Add_CarBrand_Button.Name = "Add_CarBrand_Button";
            this.Add_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Add_CarBrand_Button.RoundingEnable = true;
            this.Add_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Add_CarBrand_Button.TabIndex = 56;
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
            this.Previevs_CarBrand_Button.Location = new System.Drawing.Point(120, 290);
            this.Previevs_CarBrand_Button.Name = "Previevs_CarBrand_Button";
            this.Previevs_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Previevs_CarBrand_Button.RoundingEnable = true;
            this.Previevs_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.Previevs_CarBrand_Button.TabIndex = 55;
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
            this.First_CarBrand_Button.Location = new System.Drawing.Point(9, 290);
            this.First_CarBrand_Button.Name = "First_CarBrand_Button";
            this.First_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.First_CarBrand_Button.RoundingEnable = true;
            this.First_CarBrand_Button.Size = new System.Drawing.Size(94, 28);
            this.First_CarBrand_Button.TabIndex = 54;
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
            this.yt_Button1.BorderColorOnHover = System.Drawing.Color.White;
            this.yt_Button1.BorderColorOnHoverEnabled = true;
            this.yt_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(221, 60);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.White;
            this.yt_Button1.RoundingEnable = false;
            this.yt_Button1.Size = new System.Drawing.Size(106, 28);
            this.yt_Button1.TabIndex = 62;
            this.yt_Button1.Text = "Табличный вид";
            this.yt_Button1.TextHover = "";
            this.yt_Button1.UseDownPressEffectOnClick = true;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseZoomEffectOnHover = true;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // Ranks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 402);
            this.Controls.Add(this.yt_Button1);
            this.Controls.Add(this.Exit_CarBrand_Button);
            this.Controls.Add(this.Save_CarBrand_Button);
            this.Controls.Add(this.Remove_CarBrand_Button);
            this.Controls.Add(this.Next_CarBrand_Button);
            this.Controls.Add(this.Last_CarBrand_Button);
            this.Controls.Add(this.Add_CarBrand_Button);
            this.Controls.Add(this.Previevs_CarBrand_Button);
            this.Controls.Add(this.First_CarBrand_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(requirementsLabel);
            this.Controls.Add(this.requirementsTextBox);
            this.Controls.Add(dutiesLabel);
            this.Controls.Add(this.dutiesTextBox);
            this.Controls.Add(allowanceLabel);
            this.Controls.Add(this.allowanceTextBox);
            this.Controls.Add(rankNameLabel);
            this.Controls.Add(this.rankNameTextBox);
            this.Controls.Add(this.ranksBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ranks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица \"Звания\"";
            this.Load += new System.EventHandler(this.Ranks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingNavigator)).EndInit();
            this.ranksBindingNavigator.ResumeLayout(false);
            this.ranksBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.EgoldsFormStyle egoldsFormStyle1;
        private TrafficPoliceDataSet trafficPoliceDataSet;
        private System.Windows.Forms.BindingSource ranksBindingSource;
        private TrafficPoliceDataSetTableAdapters.RanksTableAdapter ranksTableAdapter;
        private TrafficPoliceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ranksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ranksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox rankNameTextBox;
        private System.Windows.Forms.TextBox allowanceTextBox;
        private System.Windows.Forms.TextBox dutiesTextBox;
        private System.Windows.Forms.TextBox requirementsTextBox;
        private System.Windows.Forms.Label label1;
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