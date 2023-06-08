namespace WindowsFormsApp1
{
    partial class NovGruz
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
            System.Windows.Forms.Label iD_GruzLabel;
            System.Windows.Forms.Label opisanieLabel;
            System.Windows.Forms.Label vesTLabel;
            System.Windows.Forms.Label nazvanieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovGruz));
            this.uPDataSet = new WindowsFormsApp1.UPDataSet();
            this.gruzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruzTableAdapter = new WindowsFormsApp1.UPDataSetTableAdapters.GruzTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.UPDataSetTableAdapters.TableAdapterManager();
            this.gruzBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gruzBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_GruzTextBox = new System.Windows.Forms.TextBox();
            this.opisanieTextBox = new System.Windows.Forms.TextBox();
            this.vesTTextBox = new System.Windows.Forms.TextBox();
            this.nazvanieTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            iD_GruzLabel = new System.Windows.Forms.Label();
            opisanieLabel = new System.Windows.Forms.Label();
            vesTLabel = new System.Windows.Forms.Label();
            nazvanieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruzBindingNavigator)).BeginInit();
            this.gruzBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_GruzLabel
            // 
            iD_GruzLabel.AutoSize = true;
            iD_GruzLabel.Location = new System.Drawing.Point(46, 68);
            iD_GruzLabel.Name = "iD_GruzLabel";
            iD_GruzLabel.Size = new System.Drawing.Size(53, 13);
            iD_GruzLabel.TabIndex = 1;
            iD_GruzLabel.Text = "ID Груза:";
            // 
            // opisanieLabel
            // 
            opisanieLabel.AutoSize = true;
            opisanieLabel.Location = new System.Drawing.Point(39, 154);
            opisanieLabel.Name = "opisanieLabel";
            opisanieLabel.Size = new System.Drawing.Size(60, 13);
            opisanieLabel.TabIndex = 3;
            opisanieLabel.Text = "Описание:";
            // 
            // vesTLabel
            // 
            vesTLabel.AutoSize = true;
            vesTLabel.Location = new System.Drawing.Point(57, 198);
            vesTLabel.Name = "vesTLabel";
            vesTLabel.Size = new System.Drawing.Size(42, 13);
            vesTLabel.TabIndex = 5;
            vesTLabel.Text = "Вес, Т:";
            // 
            // nazvanieLabel
            // 
            nazvanieLabel.AutoSize = true;
            nazvanieLabel.Location = new System.Drawing.Point(39, 111);
            nazvanieLabel.Name = "nazvanieLabel";
            nazvanieLabel.Size = new System.Drawing.Size(60, 13);
            nazvanieLabel.TabIndex = 7;
            nazvanieLabel.Text = "Название:";
            // 
            // uPDataSet
            // 
            this.uPDataSet.DataSetName = "UPDataSet";
            this.uPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gruzBindingSource
            // 
            this.gruzBindingSource.DataMember = "Gruz";
            this.gruzBindingSource.DataSource = this.uPDataSet;
            // 
            // gruzTableAdapter
            // 
            this.gruzTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GorodaTableAdapter = null;
            this.tableAdapterManager.GruzovikTableAdapter = null;
            this.tableAdapterManager.GruzTableAdapter = this.gruzTableAdapter;
            this.tableAdapterManager.KlientTableAdapter = null;
            this.tableAdapterManager.PerevozkiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.UPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gruzBindingNavigator
            // 
            this.gruzBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gruzBindingNavigator.BindingSource = this.gruzBindingSource;
            this.gruzBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gruzBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gruzBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gruzBindingNavigatorSaveItem});
            this.gruzBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gruzBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gruzBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gruzBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gruzBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gruzBindingNavigator.Name = "gruzBindingNavigator";
            this.gruzBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gruzBindingNavigator.Size = new System.Drawing.Size(556, 25);
            this.gruzBindingNavigator.TabIndex = 0;
            this.gruzBindingNavigator.Text = "bindingNavigator1";
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
            // gruzBindingNavigatorSaveItem
            // 
            this.gruzBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gruzBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gruzBindingNavigatorSaveItem.Image")));
            this.gruzBindingNavigatorSaveItem.Name = "gruzBindingNavigatorSaveItem";
            this.gruzBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gruzBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.gruzBindingNavigatorSaveItem.Click += new System.EventHandler(this.gruzBindingNavigatorSaveItem_Click);
            // 
            // iD_GruzTextBox
            // 
            this.iD_GruzTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruzBindingSource, "ID_Gruz", true));
            this.iD_GruzTextBox.Location = new System.Drawing.Point(105, 65);
            this.iD_GruzTextBox.Name = "iD_GruzTextBox";
            this.iD_GruzTextBox.Size = new System.Drawing.Size(126, 20);
            this.iD_GruzTextBox.TabIndex = 2;
            // 
            // opisanieTextBox
            // 
            this.opisanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruzBindingSource, "Opisanie", true));
            this.opisanieTextBox.Location = new System.Drawing.Point(105, 151);
            this.opisanieTextBox.Name = "opisanieTextBox";
            this.opisanieTextBox.Size = new System.Drawing.Size(333, 20);
            this.opisanieTextBox.TabIndex = 4;
            // 
            // vesTTextBox
            // 
            this.vesTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruzBindingSource, "VesT", true));
            this.vesTTextBox.Location = new System.Drawing.Point(105, 195);
            this.vesTTextBox.Name = "vesTTextBox";
            this.vesTTextBox.Size = new System.Drawing.Size(126, 20);
            this.vesTTextBox.TabIndex = 6;
            // 
            // nazvanieTextBox
            // 
            this.nazvanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruzBindingSource, "Nazvanie", true));
            this.nazvanieTextBox.Location = new System.Drawing.Point(105, 108);
            this.nazvanieTextBox.Name = "nazvanieTextBox";
            this.nazvanieTextBox.Size = new System.Drawing.Size(333, 20);
            this.nazvanieTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(167, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Создать новый товар";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(167, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Сохранить изменения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NovGruz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 389);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nazvanieLabel);
            this.Controls.Add(this.nazvanieTextBox);
            this.Controls.Add(vesTLabel);
            this.Controls.Add(this.vesTTextBox);
            this.Controls.Add(opisanieLabel);
            this.Controls.Add(this.opisanieTextBox);
            this.Controls.Add(iD_GruzLabel);
            this.Controls.Add(this.iD_GruzTextBox);
            this.Controls.Add(this.gruzBindingNavigator);
            this.Name = "NovGruz";
            this.Text = "Добавление нового груза";
            this.Load += new System.EventHandler(this.NovGruz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruzBindingNavigator)).EndInit();
            this.gruzBindingNavigator.ResumeLayout(false);
            this.gruzBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UPDataSet uPDataSet;
        private System.Windows.Forms.BindingSource gruzBindingSource;
        private UPDataSetTableAdapters.GruzTableAdapter gruzTableAdapter;
        private UPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gruzBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gruzBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_GruzTextBox;
        private System.Windows.Forms.TextBox opisanieTextBox;
        private System.Windows.Forms.TextBox vesTTextBox;
        private System.Windows.Forms.TextBox nazvanieTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}