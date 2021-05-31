
namespace yt_DesignUI.Forms.TablesFromDB
{
    partial class RanksTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RanksTableForm));
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
            this.ranksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.yt_Button1 = new yt_DesignUI.yt_Button();
            this.ShowAll_CarBrandTable_Button = new yt_DesignUI.yt_Button();
            this.Find_CarBrandTable_Button = new yt_DesignUI.yt_Button();
            this.Filter_CarBrandTable_Button = new yt_DesignUI.yt_Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sort_CarBrandTable_Button = new yt_DesignUI.yt_Button();
            this.RadioButton_DESC = new yt_DesignUI.EgoldsRadioButton();
            this.RadioButton_ASC = new yt_DesignUI.EgoldsRadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBox_CarBrandTable = new yt_DesignUI.EgoldsGoogleTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingNavigator)).BeginInit();
            this.ranksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ranksDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.ranksBindingNavigator.Size = new System.Drawing.Size(693, 25);
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
            this.ranksBindingNavigatorSaveItem.Click += new System.EventHandler(this.ranksBindingNavigatorSaveItem_Click);
            // 
            // ranksDataGridView
            // 
            this.ranksDataGridView.AutoGenerateColumns = false;
            this.ranksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ranksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.ranksDataGridView.DataSource = this.ranksBindingSource;
            this.ranksDataGridView.Location = new System.Drawing.Point(12, 98);
            this.ranksDataGridView.Name = "ranksDataGridView";
            this.ranksDataGridView.Size = new System.Drawing.Size(447, 163);
            this.ranksDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RankName";
            this.dataGridViewTextBoxColumn2.HeaderText = "RankName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Allowance";
            this.dataGridViewTextBoxColumn3.HeaderText = "Allowance";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Duties";
            this.dataGridViewTextBoxColumn4.HeaderText = "Duties";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Requirements";
            this.dataGridViewTextBoxColumn5.HeaderText = "Requirements";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(264, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Таблица \"Звания\" (Табличный вид)";
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
            this.yt_Button1.Location = new System.Drawing.Point(12, 52);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.White;
            this.yt_Button1.RoundingEnable = false;
            this.yt_Button1.Size = new System.Drawing.Size(106, 28);
            this.yt_Button1.TabIndex = 59;
            this.yt_Button1.Text = "Ленточный вид";
            this.yt_Button1.TextHover = "";
            this.yt_Button1.UseDownPressEffectOnClick = true;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseZoomEffectOnHover = true;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // ShowAll_CarBrandTable_Button
            // 
            this.ShowAll_CarBrandTable_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.ShowAll_CarBrandTable_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.ShowAll_CarBrandTable_Button.BackColorGradientEnabled = true;
            this.ShowAll_CarBrandTable_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.ShowAll_CarBrandTable_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ShowAll_CarBrandTable_Button.BorderColorEnabled = true;
            this.ShowAll_CarBrandTable_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.ShowAll_CarBrandTable_Button.BorderColorOnHoverEnabled = true;
            this.ShowAll_CarBrandTable_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowAll_CarBrandTable_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ShowAll_CarBrandTable_Button.ForeColor = System.Drawing.Color.White;
            this.ShowAll_CarBrandTable_Button.Location = new System.Drawing.Point(490, 299);
            this.ShowAll_CarBrandTable_Button.Name = "ShowAll_CarBrandTable_Button";
            this.ShowAll_CarBrandTable_Button.RippleColor = System.Drawing.Color.White;
            this.ShowAll_CarBrandTable_Button.RoundingEnable = true;
            this.ShowAll_CarBrandTable_Button.Size = new System.Drawing.Size(94, 28);
            this.ShowAll_CarBrandTable_Button.TabIndex = 64;
            this.ShowAll_CarBrandTable_Button.Text = "Показать все";
            this.ShowAll_CarBrandTable_Button.TextHover = "";
            this.ShowAll_CarBrandTable_Button.UseDownPressEffectOnClick = true;
            this.ShowAll_CarBrandTable_Button.UseRippleEffect = true;
            this.ShowAll_CarBrandTable_Button.UseZoomEffectOnHover = true;
            this.ShowAll_CarBrandTable_Button.Click += new System.EventHandler(this.ShowAll_CarBrandTable_Button_Click);
            // 
            // Find_CarBrandTable_Button
            // 
            this.Find_CarBrandTable_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Find_CarBrandTable_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.Find_CarBrandTable_Button.BackColorGradientEnabled = true;
            this.Find_CarBrandTable_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Find_CarBrandTable_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Find_CarBrandTable_Button.BorderColorEnabled = true;
            this.Find_CarBrandTable_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.Find_CarBrandTable_Button.BorderColorOnHoverEnabled = true;
            this.Find_CarBrandTable_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Find_CarBrandTable_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Find_CarBrandTable_Button.ForeColor = System.Drawing.Color.White;
            this.Find_CarBrandTable_Button.Location = new System.Drawing.Point(366, 338);
            this.Find_CarBrandTable_Button.Name = "Find_CarBrandTable_Button";
            this.Find_CarBrandTable_Button.RippleColor = System.Drawing.Color.White;
            this.Find_CarBrandTable_Button.RoundingEnable = true;
            this.Find_CarBrandTable_Button.Size = new System.Drawing.Size(94, 28);
            this.Find_CarBrandTable_Button.TabIndex = 63;
            this.Find_CarBrandTable_Button.Text = "Найти";
            this.Find_CarBrandTable_Button.TextHover = "";
            this.Find_CarBrandTable_Button.UseDownPressEffectOnClick = true;
            this.Find_CarBrandTable_Button.UseRippleEffect = true;
            this.Find_CarBrandTable_Button.UseZoomEffectOnHover = true;
            this.Find_CarBrandTable_Button.Click += new System.EventHandler(this.Find_CarBrandTable_Button_Click);
            // 
            // Filter_CarBrandTable_Button
            // 
            this.Filter_CarBrandTable_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Filter_CarBrandTable_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.Filter_CarBrandTable_Button.BackColorGradientEnabled = true;
            this.Filter_CarBrandTable_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Filter_CarBrandTable_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Filter_CarBrandTable_Button.BorderColorEnabled = true;
            this.Filter_CarBrandTable_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.Filter_CarBrandTable_Button.BorderColorOnHoverEnabled = true;
            this.Filter_CarBrandTable_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filter_CarBrandTable_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Filter_CarBrandTable_Button.ForeColor = System.Drawing.Color.White;
            this.Filter_CarBrandTable_Button.Location = new System.Drawing.Point(366, 299);
            this.Filter_CarBrandTable_Button.Name = "Filter_CarBrandTable_Button";
            this.Filter_CarBrandTable_Button.RippleColor = System.Drawing.Color.White;
            this.Filter_CarBrandTable_Button.RoundingEnable = true;
            this.Filter_CarBrandTable_Button.Size = new System.Drawing.Size(94, 28);
            this.Filter_CarBrandTable_Button.TabIndex = 61;
            this.Filter_CarBrandTable_Button.Text = "Фильтровать";
            this.Filter_CarBrandTable_Button.TextHover = "";
            this.Filter_CarBrandTable_Button.UseDownPressEffectOnClick = true;
            this.Filter_CarBrandTable_Button.UseRippleEffect = true;
            this.Filter_CarBrandTable_Button.UseZoomEffectOnHover = true;
            this.Filter_CarBrandTable_Button.Click += new System.EventHandler(this.Filter_CarBrandTable_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sort_CarBrandTable_Button);
            this.groupBox1.Controls.Add(this.RadioButton_DESC);
            this.groupBox1.Controls.Add(this.RadioButton_ASC);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(465, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 191);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // Sort_CarBrandTable_Button
            // 
            this.Sort_CarBrandTable_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Sort_CarBrandTable_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.Sort_CarBrandTable_Button.BackColorGradientEnabled = true;
            this.Sort_CarBrandTable_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Sort_CarBrandTable_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Sort_CarBrandTable_Button.BorderColorEnabled = true;
            this.Sort_CarBrandTable_Button.BorderColorOnHover = System.Drawing.Color.White;
            this.Sort_CarBrandTable_Button.BorderColorOnHoverEnabled = true;
            this.Sort_CarBrandTable_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sort_CarBrandTable_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Sort_CarBrandTable_Button.ForeColor = System.Drawing.Color.White;
            this.Sort_CarBrandTable_Button.Location = new System.Drawing.Point(53, 149);
            this.Sort_CarBrandTable_Button.Name = "Sort_CarBrandTable_Button";
            this.Sort_CarBrandTable_Button.RippleColor = System.Drawing.Color.White;
            this.Sort_CarBrandTable_Button.RoundingEnable = true;
            this.Sort_CarBrandTable_Button.Size = new System.Drawing.Size(126, 28);
            this.Sort_CarBrandTable_Button.TabIndex = 21;
            this.Sort_CarBrandTable_Button.Text = "Сортировать";
            this.Sort_CarBrandTable_Button.TextHover = "";
            this.Sort_CarBrandTable_Button.UseDownPressEffectOnClick = true;
            this.Sort_CarBrandTable_Button.UseRippleEffect = true;
            this.Sort_CarBrandTable_Button.UseZoomEffectOnHover = true;
            this.Sort_CarBrandTable_Button.Click += new System.EventHandler(this.Sort_CarBrandTable_Button_Click);
            // 
            // RadioButton_DESC
            // 
            this.RadioButton_DESC.AutoSize = true;
            this.RadioButton_DESC.BackColor = System.Drawing.Color.White;
            this.RadioButton_DESC.Font = new System.Drawing.Font("Verdana", 9F);
            this.RadioButton_DESC.Location = new System.Drawing.Point(5, 109);
            this.RadioButton_DESC.Name = "RadioButton_DESC";
            this.RadioButton_DESC.Size = new System.Drawing.Size(200, 18);
            this.RadioButton_DESC.TabIndex = 2;
            this.RadioButton_DESC.TabStop = true;
            this.RadioButton_DESC.Text = "Сортировать по убыванию";
            this.RadioButton_DESC.UseVisualStyleBackColor = false;
            // 
            // RadioButton_ASC
            // 
            this.RadioButton_ASC.AutoSize = true;
            this.RadioButton_ASC.BackColor = System.Drawing.Color.White;
            this.RadioButton_ASC.Font = new System.Drawing.Font("Verdana", 9F);
            this.RadioButton_ASC.Location = new System.Drawing.Point(4, 85);
            this.RadioButton_ASC.Name = "RadioButton_ASC";
            this.RadioButton_ASC.Size = new System.Drawing.Size(219, 18);
            this.RadioButton_ASC.TabIndex = 1;
            this.RadioButton_ASC.TabStop = true;
            this.RadioButton_ASC.Text = "Сортировать по возрастанию";
            this.RadioButton_ASC.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "RankName",
            "Allowance"});
            this.listBox1.Location = new System.Drawing.Point(7, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 49);
            this.listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ranksBindingSource;
            this.comboBox1.DisplayMember = "RankName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 299);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 68;
            // 
            // TextBox_CarBrandTable
            // 
            this.TextBox_CarBrandTable.BackColor = System.Drawing.Color.White;
            this.TextBox_CarBrandTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TextBox_CarBrandTable.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.TextBox_CarBrandTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_CarBrandTable.Font = new System.Drawing.Font("Arial", 11.25F);
            this.TextBox_CarBrandTable.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.TextBox_CarBrandTable.ForeColor = System.Drawing.Color.Black;
            this.TextBox_CarBrandTable.Location = new System.Drawing.Point(203, 326);
            this.TextBox_CarBrandTable.Name = "TextBox_CarBrandTable";
            this.TextBox_CarBrandTable.Size = new System.Drawing.Size(150, 40);
            this.TextBox_CarBrandTable.TabIndex = 67;
            this.TextBox_CarBrandTable.TextInput = "";
            this.TextBox_CarBrandTable.TextPreview = "Input text";
            this.TextBox_CarBrandTable.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 66;
            this.label3.Text = "Критерий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 65;
            this.label2.Text = "Название звания";
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
            // RanksTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 402);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TextBox_CarBrandTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowAll_CarBrandTable_Button);
            this.Controls.Add(this.Find_CarBrandTable_Button);
            this.Controls.Add(this.Filter_CarBrandTable_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yt_Button1);
            this.Controls.Add(this.ranksDataGridView);
            this.Controls.Add(this.ranksBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RanksTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица \"Звания\" (Табличный вид)";
            this.Load += new System.EventHandler(this.RanksTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingNavigator)).EndInit();
            this.ranksBindingNavigator.ResumeLayout(false);
            this.ranksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ranksDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView ranksDataGridView;
        private System.Windows.Forms.Label label1;
        private yt_Button yt_Button1;
        private yt_Button ShowAll_CarBrandTable_Button;
        private yt_Button Find_CarBrandTable_Button;
        private yt_Button Filter_CarBrandTable_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private yt_Button Sort_CarBrandTable_Button;
        private EgoldsRadioButton RadioButton_DESC;
        private EgoldsRadioButton RadioButton_ASC;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private EgoldsGoogleTextBox TextBox_CarBrandTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}