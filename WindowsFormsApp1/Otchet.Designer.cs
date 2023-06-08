namespace WindowsFormsApp1
{
    partial class Otchet
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
            this.button1 = new System.Windows.Forms.Button();
            this.uPDataSet = new WindowsFormsApp1.UPDataSet();
            this.uPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new WindowsFormsApp1.UPDataSetTableAdapters.TableAdapterManager();
            this.gruzovikTableAdapter1 = new WindowsFormsApp1.UPDataSetTableAdapters.GruzovikTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.most_pop_tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.most_pop_tovarTableAdapter = new WindowsFormsApp1.UPDataSetTableAdapters.most_pop_tovarTableAdapter();
            this.most_pop_tovarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.most_pop_cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.most_pop_cityTableAdapter = new WindowsFormsApp1.UPDataSetTableAdapters.most_pop_cityTableAdapter();
            this.most_pop_cityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.most_pop_tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.most_pop_tovarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.most_pop_cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.most_pop_cityDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
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
            // uPDataSetBindingSource
            // 
            this.uPDataSetBindingSource.DataSource = this.uPDataSet;
            this.uPDataSetBindingSource.Position = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GorodaTableAdapter = null;
            this.tableAdapterManager.GruzovikTableAdapter = null;
            this.tableAdapterManager.GruzTableAdapter = null;
            this.tableAdapterManager.KlientTableAdapter = null;
            this.tableAdapterManager.PerevozkiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.UPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gruzovikTableAdapter1
            // 
            this.gruzovikTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.most_pop_tovarDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Самый популярный вид товара";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.most_pop_cityDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(412, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 265);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Самый популярный город ";
            // 
            // most_pop_tovarBindingSource
            // 
            this.most_pop_tovarBindingSource.DataMember = "most_pop_tovar";
            this.most_pop_tovarBindingSource.DataSource = this.uPDataSet;
            // 
            // most_pop_tovarTableAdapter
            // 
            this.most_pop_tovarTableAdapter.ClearBeforeFill = true;
            // 
            // most_pop_tovarDataGridView
            // 
            this.most_pop_tovarDataGridView.AutoGenerateColumns = false;
            this.most_pop_tovarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.most_pop_tovarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.most_pop_tovarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.most_pop_tovarDataGridView.DataSource = this.most_pop_tovarBindingSource;
            this.most_pop_tovarDataGridView.Location = new System.Drawing.Point(6, 19);
            this.most_pop_tovarDataGridView.Name = "most_pop_tovarDataGridView";
            this.most_pop_tovarDataGridView.Size = new System.Drawing.Size(357, 235);
            this.most_pop_tovarDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nazvanie";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cnt";
            this.dataGridViewTextBoxColumn2.HeaderText = "Кол-во отправленных поставок";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // most_pop_cityBindingSource
            // 
            this.most_pop_cityBindingSource.DataMember = "most_pop_city";
            this.most_pop_cityBindingSource.DataSource = this.uPDataSet;
            // 
            // most_pop_cityTableAdapter
            // 
            this.most_pop_cityTableAdapter.ClearBeforeFill = true;
            // 
            // most_pop_cityDataGridView
            // 
            this.most_pop_cityDataGridView.AutoGenerateColumns = false;
            this.most_pop_cityDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.most_pop_cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.most_pop_cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.most_pop_cityDataGridView.DataSource = this.most_pop_cityBindingSource;
            this.most_pop_cityDataGridView.Location = new System.Drawing.Point(6, 19);
            this.most_pop_cityDataGridView.Name = "most_pop_cityDataGridView";
            this.most_pop_cityDataGridView.Size = new System.Drawing.Size(368, 235);
            this.most_pop_cityDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gorod";
            this.dataGridViewTextBoxColumn3.HeaderText = "Город";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cnt";
            this.dataGridViewTextBoxColumn4.HeaderText = "Кол-во отправленных поставок";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Otchet";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Otchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.most_pop_tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.most_pop_tovarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.most_pop_cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.most_pop_cityDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private UPDataSet uPDataSet;
        private System.Windows.Forms.BindingSource uPDataSetBindingSource;
        private UPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private UPDataSetTableAdapters.GruzovikTableAdapter gruzovikTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource most_pop_tovarBindingSource;
        private UPDataSetTableAdapters.most_pop_tovarTableAdapter most_pop_tovarTableAdapter;
        private System.Windows.Forms.DataGridView most_pop_tovarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource most_pop_cityBindingSource;
        private UPDataSetTableAdapters.most_pop_cityTableAdapter most_pop_cityTableAdapter;
        private System.Windows.Forms.DataGridView most_pop_cityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}