namespace WindowsFormsApp1
{
    partial class NovPerevozka
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
            System.Windows.Forms.Label dataPostavkiLabel;
            System.Windows.Forms.Label iD_PerevozkiLabel;
            System.Windows.Forms.Label iD_KlientLabel;
            System.Windows.Forms.Label iD_GruzLabel;
            System.Windows.Forms.Label iD_GorodLabel;
            System.Windows.Forms.Label iD_GruzovikLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovPerevozka));
            this.button1 = new System.Windows.Forms.Button();
            this.uPDataSet = new WindowsFormsApp1.UPDataSet();
            this.perevozkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perevozkiTableAdapter = new WindowsFormsApp1.UPDataSetTableAdapters.PerevozkiTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.UPDataSetTableAdapters.TableAdapterManager();
            this.gorodaTableAdapter = new WindowsFormsApp1.UPDataSetTableAdapters.GorodaTableAdapter();
            this.gruzovikTableAdapter = new WindowsFormsApp1.UPDataSetTableAdapters.GruzovikTableAdapter();
            this.gruzTableAdapter = new WindowsFormsApp1.UPDataSetTableAdapters.GruzTableAdapter();
            this.klientTableAdapter = new WindowsFormsApp1.UPDataSetTableAdapters.KlientTableAdapter();
            this.perevozkiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.perevozkiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataPostavkiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_PerevozkiTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gruzovikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.gruzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.gorodaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            dataPostavkiLabel = new System.Windows.Forms.Label();
            iD_PerevozkiLabel = new System.Windows.Forms.Label();
            iD_KlientLabel = new System.Windows.Forms.Label();
            iD_GruzLabel = new System.Windows.Forms.Label();
            iD_GorodLabel = new System.Windows.Forms.Label();
            iD_GruzovikLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perevozkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perevozkiBindingNavigator)).BeginInit();
            this.perevozkiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruzovikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorodaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPostavkiLabel
            // 
            dataPostavkiLabel.AutoSize = true;
            dataPostavkiLabel.Location = new System.Drawing.Point(130, 99);
            dataPostavkiLabel.Name = "dataPostavkiLabel";
            dataPostavkiLabel.Size = new System.Drawing.Size(86, 13);
            dataPostavkiLabel.TabIndex = 2;
            dataPostavkiLabel.Text = "Дата поставки:";
            // 
            // iD_PerevozkiLabel
            // 
            iD_PerevozkiLabel.AutoSize = true;
            iD_PerevozkiLabel.Location = new System.Drawing.Point(130, 61);
            iD_PerevozkiLabel.Name = "iD_PerevozkiLabel";
            iD_PerevozkiLabel.Size = new System.Drawing.Size(78, 13);
            iD_PerevozkiLabel.TabIndex = 4;
            iD_PerevozkiLabel.Text = "ID перевозки:";
            // 
            // iD_KlientLabel
            // 
            iD_KlientLabel.AutoSize = true;
            iD_KlientLabel.Location = new System.Drawing.Point(130, 135);
            iD_KlientLabel.Name = "iD_KlientLabel";
            iD_KlientLabel.Size = new System.Drawing.Size(51, 13);
            iD_KlientLabel.TabIndex = 6;
            iD_KlientLabel.Text = "Клиенту:";
            // 
            // iD_GruzLabel
            // 
            iD_GruzLabel.AutoSize = true;
            iD_GruzLabel.Location = new System.Drawing.Point(130, 247);
            iD_GruzLabel.Name = "iD_GruzLabel";
            iD_GruzLabel.Size = new System.Drawing.Size(33, 13);
            iD_GruzLabel.TabIndex = 8;
            iD_GruzLabel.Text = "Груз:";
            // 
            // iD_GorodLabel
            // 
            iD_GorodLabel.AutoSize = true;
            iD_GorodLabel.Location = new System.Drawing.Point(130, 288);
            iD_GorodLabel.Name = "iD_GorodLabel";
            iD_GorodLabel.Size = new System.Drawing.Size(49, 13);
            iD_GorodLabel.TabIndex = 10;
            iD_GorodLabel.Text = "В город:";
            // 
            // iD_GruzovikLabel
            // 
            iD_GruzovikLabel.AutoSize = true;
            iD_GruzovikLabel.Location = new System.Drawing.Point(130, 171);
            iD_GruzovikLabel.Name = "iD_GruzovikLabel";
            iD_GruzovikLabel.Size = new System.Drawing.Size(34, 13);
            iD_GruzovikLabel.TabIndex = 12;
            iD_GruzovikLabel.Text = "Авто:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uPDataSet
            // 
            this.uPDataSet.DataSetName = "UPDataSet";
            this.uPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perevozkiBindingSource
            // 
            this.perevozkiBindingSource.DataMember = "Perevozki";
            this.perevozkiBindingSource.DataSource = this.uPDataSet;
            // 
            // perevozkiTableAdapter
            // 
            this.perevozkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GorodaTableAdapter = this.gorodaTableAdapter;
            this.tableAdapterManager.GruzovikTableAdapter = this.gruzovikTableAdapter;
            this.tableAdapterManager.GruzTableAdapter = this.gruzTableAdapter;
            this.tableAdapterManager.KlientTableAdapter = this.klientTableAdapter;
            this.tableAdapterManager.PerevozkiTableAdapter = this.perevozkiTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.UPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gorodaTableAdapter
            // 
            this.gorodaTableAdapter.ClearBeforeFill = true;
            // 
            // gruzovikTableAdapter
            // 
            this.gruzovikTableAdapter.ClearBeforeFill = true;
            // 
            // gruzTableAdapter
            // 
            this.gruzTableAdapter.ClearBeforeFill = true;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // perevozkiBindingNavigator
            // 
            this.perevozkiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.perevozkiBindingNavigator.BindingSource = this.perevozkiBindingSource;
            this.perevozkiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.perevozkiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.perevozkiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.perevozkiBindingNavigatorSaveItem});
            this.perevozkiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.perevozkiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.perevozkiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.perevozkiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.perevozkiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.perevozkiBindingNavigator.Name = "perevozkiBindingNavigator";
            this.perevozkiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.perevozkiBindingNavigator.Size = new System.Drawing.Size(563, 25);
            this.perevozkiBindingNavigator.TabIndex = 1;
            this.perevozkiBindingNavigator.Text = "bindingNavigator1";
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
            // perevozkiBindingNavigatorSaveItem
            // 
            this.perevozkiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.perevozkiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("perevozkiBindingNavigatorSaveItem.Image")));
            this.perevozkiBindingNavigatorSaveItem.Name = "perevozkiBindingNavigatorSaveItem";
            this.perevozkiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.perevozkiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.perevozkiBindingNavigatorSaveItem.Click += new System.EventHandler(this.perevozkiBindingNavigatorSaveItem_Click);
            // 
            // dataPostavkiDateTimePicker
            // 
            this.dataPostavkiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.perevozkiBindingSource, "DataPostavki", true));
            this.dataPostavkiDateTimePicker.Location = new System.Drawing.Point(222, 93);
            this.dataPostavkiDateTimePicker.Name = "dataPostavkiDateTimePicker";
            this.dataPostavkiDateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.dataPostavkiDateTimePicker.TabIndex = 3;
            // 
            // iD_PerevozkiTextBox
            // 
            this.iD_PerevozkiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perevozkiBindingSource, "ID_Perevozki", true));
            this.iD_PerevozkiTextBox.Location = new System.Drawing.Point(214, 58);
            this.iD_PerevozkiTextBox.Name = "iD_PerevozkiTextBox";
            this.iD_PerevozkiTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_PerevozkiTextBox.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.perevozkiBindingSource, "ID_Klient", true));
            this.comboBox1.DataSource = this.klientBindingSource;
            this.comboBox1.DisplayMember = "Klient";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "ID_Klient";
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.uPDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.perevozkiBindingSource, "ID_Gruzovik", true));
            this.comboBox2.DataSource = this.gruzovikBindingSource;
            this.comboBox2.DisplayMember = "MarkaAvto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(170, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(243, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.ValueMember = "ID_Gruzovik";
            // 
            // gruzovikBindingSource
            // 
            this.gruzovikBindingSource.DataMember = "Gruzovik";
            this.gruzovikBindingSource.DataSource = this.uPDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.perevozkiBindingSource, "ID_Gruz", true));
            this.comboBox3.DataSource = this.gruzBindingSource;
            this.comboBox3.DisplayMember = "Nazvanie";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(169, 244);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(138, 21);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.ValueMember = "ID_Gruz";
            // 
            // gruzBindingSource
            // 
            this.gruzBindingSource.DataMember = "Gruz";
            this.gruzBindingSource.DataSource = this.uPDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.perevozkiBindingSource, "ID_Gorod", true));
            this.comboBox4.DataSource = this.gorodaBindingSource;
            this.comboBox4.DisplayMember = "Gorod";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(185, 285);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(229, 21);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.ValueMember = "ID_Gorod";
            // 
            // gorodaBindingSource
            // 
            this.gorodaBindingSource.DataMember = "Goroda";
            this.gorodaBindingSource.DataSource = this.uPDataSet;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(214, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(214, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 31);
            this.button3.TabIndex = 18;
            this.button3.Text = "Отправить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.perevozkiBindingSource, "ID_Gruzovik", true));
            this.comboBox5.DataSource = this.gruzovikBindingSource;
            this.comboBox5.DisplayMember = "Gruzopodemnost";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(240, 204);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(173, 21);
            this.comboBox5.TabIndex = 19;
            this.comboBox5.ValueMember = "ID_Gruzovik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Грузоподъемность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Вес,Т";
            // 
            // comboBox6
            // 
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.perevozkiBindingSource, "ID_Gruz", true));
            this.comboBox6.DataSource = this.gruzBindingSource;
            this.comboBox6.DisplayMember = "VesT";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(355, 244);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(59, 21);
            this.comboBox6.TabIndex = 22;
            this.comboBox6.ValueMember = "ID_Gruz";
            // 
            // NovPerevozka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 458);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(iD_GruzovikLabel);
            this.Controls.Add(iD_GorodLabel);
            this.Controls.Add(iD_GruzLabel);
            this.Controls.Add(iD_KlientLabel);
            this.Controls.Add(iD_PerevozkiLabel);
            this.Controls.Add(this.iD_PerevozkiTextBox);
            this.Controls.Add(dataPostavkiLabel);
            this.Controls.Add(this.dataPostavkiDateTimePicker);
            this.Controls.Add(this.perevozkiBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "NovPerevozka";
            this.Text = "Создание перевозки";
            this.Load += new System.EventHandler(this.NovPerevozka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perevozkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perevozkiBindingNavigator)).EndInit();
            this.perevozkiBindingNavigator.ResumeLayout(false);
            this.perevozkiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruzovikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorodaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private UPDataSet uPDataSet;
        private System.Windows.Forms.BindingSource perevozkiBindingSource;
        private UPDataSetTableAdapters.PerevozkiTableAdapter perevozkiTableAdapter;
        private UPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator perevozkiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton perevozkiBindingNavigatorSaveItem;
        private UPDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.DateTimePicker dataPostavkiDateTimePicker;
        private System.Windows.Forms.TextBox iD_PerevozkiTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private UPDataSetTableAdapters.GruzovikTableAdapter gruzovikTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource gruzovikBindingSource;
        private UPDataSetTableAdapters.GruzTableAdapter gruzTableAdapter;
        private System.Windows.Forms.BindingSource gruzBindingSource;
        private UPDataSetTableAdapters.GorodaTableAdapter gorodaTableAdapter;
        private System.Windows.Forms.BindingSource gorodaBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}