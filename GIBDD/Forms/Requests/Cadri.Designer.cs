
namespace yt_DesignUI.Forms.Requests
{
    partial class Cadri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadri));
            this.trafficPoliceDataSet = new yt_DesignUI.TrafficPoliceDataSet();
            this.отдел_кадровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отдел_кадровTableAdapter = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.Отдел_кадровTableAdapter();
            this.tableAdapterManager = new yt_DesignUI.TrafficPoliceDataSetTableAdapters.TableAdapterManager();
            this.отдел_кадровBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.отдел_кадровBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.отдел_кадровDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_CarBrand_Button = new yt_DesignUI.yt_Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBox_CarBrandTable = new yt_DesignUI.EgoldsGoogleTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowAll_CarBrandTable_Button = new yt_DesignUI.yt_Button();
            this.Find_CarBrandTable_Button = new yt_DesignUI.yt_Button();
            this.Filter_CarBrandTable_Button = new yt_DesignUI.yt_Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sort_CarBrandTable_Button = new yt_DesignUI.yt_Button();
            this.RadioButton_DESC = new yt_DesignUI.EgoldsRadioButton();
            this.RadioButton_ASC = new yt_DesignUI.EgoldsRadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingNavigator)).BeginInit();
            this.отдел_кадровBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trafficPoliceDataSet
            // 
            this.trafficPoliceDataSet.DataSetName = "TrafficPoliceDataSet";
            this.trafficPoliceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отдел_кадровBindingSource
            // 
            this.отдел_кадровBindingSource.DataMember = "Отдел кадров";
            this.отдел_кадровBindingSource.DataSource = this.trafficPoliceDataSet;
            // 
            // отдел_кадровTableAdapter
            // 
            this.отдел_кадровTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarBrandTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DriversTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.RanksTableAdapter = null;
            this.tableAdapterManager.StolenCarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = yt_DesignUI.TrafficPoliceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // отдел_кадровBindingNavigator
            // 
            this.отдел_кадровBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.отдел_кадровBindingNavigator.BindingSource = this.отдел_кадровBindingSource;
            this.отдел_кадровBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.отдел_кадровBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.отдел_кадровBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.отдел_кадровBindingNavigatorSaveItem});
            this.отдел_кадровBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.отдел_кадровBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.отдел_кадровBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.отдел_кадровBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.отдел_кадровBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.отдел_кадровBindingNavigator.Name = "отдел_кадровBindingNavigator";
            this.отдел_кадровBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.отдел_кадровBindingNavigator.Size = new System.Drawing.Size(1387, 25);
            this.отдел_кадровBindingNavigator.TabIndex = 0;
            this.отдел_кадровBindingNavigator.Text = "bindingNavigator1";
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
            // отдел_кадровBindingNavigatorSaveItem
            // 
            this.отдел_кадровBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.отдел_кадровBindingNavigatorSaveItem.Enabled = false;
            this.отдел_кадровBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("отдел_кадровBindingNavigatorSaveItem.Image")));
            this.отдел_кадровBindingNavigatorSaveItem.Name = "отдел_кадровBindingNavigatorSaveItem";
            this.отдел_кадровBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.отдел_кадровBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // отдел_кадровDataGridView
            // 
            this.отдел_кадровDataGridView.AutoGenerateColumns = false;
            this.отдел_кадровDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.отдел_кадровDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.отдел_кадровDataGridView.DataSource = this.отдел_кадровBindingSource;
            this.отдел_кадровDataGridView.Location = new System.Drawing.Point(12, 118);
            this.отдел_кадровDataGridView.Name = "отдел_кадровDataGridView";
            this.отдел_кадровDataGridView.Size = new System.Drawing.Size(1141, 220);
            this.отдел_кадровDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "FIO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn3.HeaderText = "Age";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Adress";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PassportData";
            this.dataGridViewTextBoxColumn7.HeaderText = "PassportData";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdPosition";
            this.dataGridViewTextBoxColumn8.HeaderText = "IdPosition";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdRank";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdRank";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NamePosition";
            this.dataGridViewTextBoxColumn11.HeaderText = "NamePosition";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn12.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Duties";
            this.dataGridViewTextBoxColumn13.HeaderText = "Duties";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Requirements";
            this.dataGridViewTextBoxColumn14.HeaderText = "Requirements";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "RankName";
            this.dataGridViewTextBoxColumn16.HeaderText = "RankName";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Allowance";
            this.dataGridViewTextBoxColumn17.HeaderText = "Allowance";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Expr3";
            this.dataGridViewTextBoxColumn18.HeaderText = "Duties";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Expr4";
            this.dataGridViewTextBoxColumn19.HeaderText = "Requirements";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
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
            this.label1.Location = new System.Drawing.Point(556, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Запрос \"Отдел кадров\"";
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
            this.Exit_CarBrand_Button.Location = new System.Drawing.Point(12, 43);
            this.Exit_CarBrand_Button.Name = "Exit_CarBrand_Button";
            this.Exit_CarBrand_Button.RippleColor = System.Drawing.Color.White;
            this.Exit_CarBrand_Button.RoundingEnable = true;
            this.Exit_CarBrand_Button.Size = new System.Drawing.Size(48, 24);
            this.Exit_CarBrand_Button.TabIndex = 36;
            this.Exit_CarBrand_Button.Text = "Назад";
            this.Exit_CarBrand_Button.TextHover = "";
            this.Exit_CarBrand_Button.UseDownPressEffectOnClick = true;
            this.Exit_CarBrand_Button.UseRippleEffect = true;
            this.Exit_CarBrand_Button.UseZoomEffectOnHover = true;
            this.Exit_CarBrand_Button.Click += new System.EventHandler(this.Exit_CarBrand_Button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.отдел_кадровBindingSource;
            this.comboBox1.DisplayMember = "FIO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 354);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 44;
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
            this.TextBox_CarBrandTable.Location = new System.Drawing.Point(185, 389);
            this.TextBox_CarBrandTable.Name = "TextBox_CarBrandTable";
            this.TextBox_CarBrandTable.Size = new System.Drawing.Size(150, 40);
            this.TextBox_CarBrandTable.TabIndex = 43;
            this.TextBox_CarBrandTable.TextInput = "";
            this.TextBox_CarBrandTable.TextPreview = "Input text";
            this.TextBox_CarBrandTable.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Критерий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Имя компании";
            // 
            // ShowAll_CarBrandTable_Button
            // 
            this.ShowAll_CarBrandTable_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.ShowAll_CarBrandTable_Button.BackColorAdditional = System.Drawing.Color.Tomato;
            this.ShowAll_CarBrandTable_Button.BackColorGradientEnabled = true;
            this.ShowAll_CarBrandTable_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.ShowAll_CarBrandTable_Button.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ShowAll_CarBrandTable_Button.BorderColorEnabled = true;
            this.ShowAll_CarBrandTable_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.ShowAll_CarBrandTable_Button.BorderColorOnHoverEnabled = true;
            this.ShowAll_CarBrandTable_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowAll_CarBrandTable_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ShowAll_CarBrandTable_Button.ForeColor = System.Drawing.Color.White;
            this.ShowAll_CarBrandTable_Button.Location = new System.Drawing.Point(1283, 375);
            this.ShowAll_CarBrandTable_Button.Name = "ShowAll_CarBrandTable_Button";
            this.ShowAll_CarBrandTable_Button.RippleColor = System.Drawing.Color.White;
            this.ShowAll_CarBrandTable_Button.RoundingEnable = true;
            this.ShowAll_CarBrandTable_Button.Size = new System.Drawing.Size(94, 28);
            this.ShowAll_CarBrandTable_Button.TabIndex = 48;
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
            this.Find_CarBrandTable_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Find_CarBrandTable_Button.BorderColorOnHoverEnabled = true;
            this.Find_CarBrandTable_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Find_CarBrandTable_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Find_CarBrandTable_Button.ForeColor = System.Drawing.Color.White;
            this.Find_CarBrandTable_Button.Location = new System.Drawing.Point(1231, 423);
            this.Find_CarBrandTable_Button.Name = "Find_CarBrandTable_Button";
            this.Find_CarBrandTable_Button.RippleColor = System.Drawing.Color.White;
            this.Find_CarBrandTable_Button.RoundingEnable = true;
            this.Find_CarBrandTable_Button.Size = new System.Drawing.Size(94, 28);
            this.Find_CarBrandTable_Button.TabIndex = 47;
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
            this.Filter_CarBrandTable_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Filter_CarBrandTable_Button.BorderColorOnHoverEnabled = true;
            this.Filter_CarBrandTable_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filter_CarBrandTable_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Filter_CarBrandTable_Button.ForeColor = System.Drawing.Color.White;
            this.Filter_CarBrandTable_Button.Location = new System.Drawing.Point(1159, 375);
            this.Filter_CarBrandTable_Button.Name = "Filter_CarBrandTable_Button";
            this.Filter_CarBrandTable_Button.RippleColor = System.Drawing.Color.White;
            this.Filter_CarBrandTable_Button.RoundingEnable = true;
            this.Filter_CarBrandTable_Button.Size = new System.Drawing.Size(94, 28);
            this.Filter_CarBrandTable_Button.TabIndex = 45;
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
            this.groupBox1.Location = new System.Drawing.Point(1159, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 245);
            this.groupBox1.TabIndex = 46;
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
            this.Sort_CarBrandTable_Button.BorderColorOnHover = System.Drawing.Color.Maroon;
            this.Sort_CarBrandTable_Button.BorderColorOnHoverEnabled = true;
            this.Sort_CarBrandTable_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sort_CarBrandTable_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Sort_CarBrandTable_Button.ForeColor = System.Drawing.Color.White;
            this.Sort_CarBrandTable_Button.Location = new System.Drawing.Point(53, 211);
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
            this.RadioButton_DESC.Location = new System.Drawing.Point(7, 176);
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
            this.RadioButton_ASC.Location = new System.Drawing.Point(6, 152);
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
            "Age",
            "Gender",
            "Salary",
            "Allowance"});
            this.listBox1.Location = new System.Drawing.Point(7, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 124);
            this.listBox1.TabIndex = 0;
            // 
            // Cadri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 464);
            this.Controls.Add(this.ShowAll_CarBrandTable_Button);
            this.Controls.Add(this.Find_CarBrandTable_Button);
            this.Controls.Add(this.Filter_CarBrandTable_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TextBox_CarBrandTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit_CarBrand_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.отдел_кадровDataGridView);
            this.Controls.Add(this.отдел_кадровBindingNavigator);
            this.Name = "Cadri";
            this.Text = "Cadri";
            this.Load += new System.EventHandler(this.Cadri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trafficPoliceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingNavigator)).EndInit();
            this.отдел_кадровBindingNavigator.ResumeLayout(false);
            this.отдел_кадровBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.BindingNavigator отдел_кадровBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource отдел_кадровBindingSource;
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
        private System.Windows.Forms.ToolStripButton отдел_кадровBindingNavigatorSaveItem;
        private TrafficPoliceDataSetTableAdapters.Отдел_кадровTableAdapter отдел_кадровTableAdapter;
        private TrafficPoliceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView отдел_кадровDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.Label label1;
        private yt_Button Exit_CarBrand_Button;
        private System.Windows.Forms.ComboBox comboBox1;
        private EgoldsGoogleTextBox TextBox_CarBrandTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private yt_Button ShowAll_CarBrandTable_Button;
        private yt_Button Find_CarBrandTable_Button;
        private yt_Button Filter_CarBrandTable_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private yt_Button Sort_CarBrandTable_Button;
        private EgoldsRadioButton RadioButton_DESC;
        private EgoldsRadioButton RadioButton_ASC;
        private System.Windows.Forms.ListBox listBox1;
    }
}