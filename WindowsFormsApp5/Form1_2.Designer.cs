namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tempDataSet = new WindowsFormsApp5.tempDataSet();
            this.gorodaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorodaTableAdapter = new WindowsFormsApp5.tempDataSetTableAdapters.gorodaTableAdapter();
            this.base666BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempDataSet1 = new WindowsFormsApp5.tempDataSet1();
            this.base666TableAdapter = new WindowsFormsApp5.tempDataSet1TableAdapters.base666TableAdapter();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.tempDataSet2 = new WindowsFormsApp5.tempDataSet2();
            this.base666BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.base666TableAdapter1 = new WindowsFormsApp5.tempDataSet2TableAdapters.base666TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.base666BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tempDataSet3 = new WindowsFormsApp5.tempDataSet3();
            this.base666TableAdapter2 = new WindowsFormsApp5.tempDataSet3TableAdapters.base666TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прозвонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.администрацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.значениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.численностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расстояниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.областьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.районDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.координатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorodaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base666BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base666BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base666BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempDataSet
            // 
            this.tempDataSet.DataSetName = "tempDataSet";
            this.tempDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gorodaBindingSource
            // 
            this.gorodaBindingSource.DataMember = "goroda";
            this.gorodaBindingSource.DataSource = this.tempDataSet;
            // 
            // gorodaTableAdapter
            // 
            this.gorodaTableAdapter.ClearBeforeFill = true;
            // 
            // base666BindingSource
            // 
            this.base666BindingSource.DataMember = "base666";
            this.base666BindingSource.DataSource = this.tempDataSet1;
            // 
            // tempDataSet1
            // 
            this.tempDataSet1.DataSetName = "tempDataSet1";
            this.tempDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // base666TableAdapter
            // 
            this.base666TableAdapter.ClearBeforeFill = true;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(67, 30);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaximumSize = new System.Drawing.Size(300, 300);
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(150, 150);
            this.gMapControl1.TabIndex = 2;
            this.gMapControl1.Zoom = 0D;
            // 
            // tempDataSet2
            // 
            this.tempDataSet2.DataSetName = "tempDataSet2";
            this.tempDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // base666BindingSource1
            // 
            this.base666BindingSource1.DataMember = "base666";
            this.base666BindingSource1.DataSource = this.tempDataSet2;
            // 
            // base666TableAdapter1
            // 
            this.base666TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.городDataGridViewTextBoxColumn,
            this.гDataGridViewTextBoxColumn,
            this.гDataGridViewTextBoxColumn1,
            this.гDataGridViewTextBoxColumn2,
            this.прозвонDataGridViewTextBoxColumn,
            this.администрацияDataGridViewTextBoxColumn,
            this.значениеDataGridViewTextBoxColumn,
            this.численностьDataGridViewTextBoxColumn,
            this.расстояниеDataGridViewTextBoxColumn,
            this.областьDataGridViewTextBoxColumn,
            this.районDataGridViewTextBoxColumn,
            this.координатыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.base666BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(898, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // base666BindingSource2
            // 
            this.base666BindingSource2.DataMember = "base666";
            this.base666BindingSource2.DataSource = this.tempDataSet3;
            // 
            // tempDataSet3
            // 
            this.tempDataSet3.DataSetName = "tempDataSet3";
            this.tempDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // base666TableAdapter2
            // 
            this.base666TableAdapter2.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gMapControl1);
            this.panel1.Location = new System.Drawing.Point(13, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 219);
            this.panel1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "№";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "город";
            this.городDataGridViewTextBoxColumn.HeaderText = "город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            // 
            // гDataGridViewTextBoxColumn
            // 
            this.гDataGridViewTextBoxColumn.DataPropertyName = "2015г";
            this.гDataGridViewTextBoxColumn.HeaderText = "2015г";
            this.гDataGridViewTextBoxColumn.Name = "гDataGridViewTextBoxColumn";
            // 
            // гDataGridViewTextBoxColumn1
            // 
            this.гDataGridViewTextBoxColumn1.DataPropertyName = "2016г";
            this.гDataGridViewTextBoxColumn1.HeaderText = "2016г";
            this.гDataGridViewTextBoxColumn1.Name = "гDataGridViewTextBoxColumn1";
            // 
            // гDataGridViewTextBoxColumn2
            // 
            this.гDataGridViewTextBoxColumn2.DataPropertyName = "2017г";
            this.гDataGridViewTextBoxColumn2.HeaderText = "2017г";
            this.гDataGridViewTextBoxColumn2.Name = "гDataGridViewTextBoxColumn2";
            // 
            // прозвонDataGridViewTextBoxColumn
            // 
            this.прозвонDataGridViewTextBoxColumn.DataPropertyName = "прозвон";
            this.прозвонDataGridViewTextBoxColumn.HeaderText = "прозвон";
            this.прозвонDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "",
            "недозвон",
            "перезвон",
            "отправление заявки",
            "ожидание",
            "одобрено",
            "отказ"});
            this.прозвонDataGridViewTextBoxColumn.Name = "прозвонDataGridViewTextBoxColumn";
            this.прозвонDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.прозвонDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // администрацияDataGridViewTextBoxColumn
            // 
            this.администрацияDataGridViewTextBoxColumn.DataPropertyName = "Администрация";
            this.администрацияDataGridViewTextBoxColumn.HeaderText = "Администрация";
            this.администрацияDataGridViewTextBoxColumn.Name = "администрацияDataGridViewTextBoxColumn";
            // 
            // значениеDataGridViewTextBoxColumn
            // 
            this.значениеDataGridViewTextBoxColumn.DataPropertyName = "значение";
            this.значениеDataGridViewTextBoxColumn.HeaderText = "значение";
            this.значениеDataGridViewTextBoxColumn.Name = "значениеDataGridViewTextBoxColumn";
            // 
            // численностьDataGridViewTextBoxColumn
            // 
            this.численностьDataGridViewTextBoxColumn.DataPropertyName = "численность";
            this.численностьDataGridViewTextBoxColumn.HeaderText = "численность";
            this.численностьDataGridViewTextBoxColumn.Name = "численностьDataGridViewTextBoxColumn";
            // 
            // расстояниеDataGridViewTextBoxColumn
            // 
            this.расстояниеDataGridViewTextBoxColumn.DataPropertyName = "Расстояние";
            this.расстояниеDataGridViewTextBoxColumn.HeaderText = "Расстояние";
            this.расстояниеDataGridViewTextBoxColumn.Name = "расстояниеDataGridViewTextBoxColumn";
            // 
            // областьDataGridViewTextBoxColumn
            // 
            this.областьDataGridViewTextBoxColumn.DataPropertyName = "область";
            this.областьDataGridViewTextBoxColumn.HeaderText = "область";
            this.областьDataGridViewTextBoxColumn.Name = "областьDataGridViewTextBoxColumn";
            // 
            // районDataGridViewTextBoxColumn
            // 
            this.районDataGridViewTextBoxColumn.DataPropertyName = "район";
            this.районDataGridViewTextBoxColumn.HeaderText = "район";
            this.районDataGridViewTextBoxColumn.Name = "районDataGridViewTextBoxColumn";
            // 
            // координатыDataGridViewTextBoxColumn
            // 
            this.координатыDataGridViewTextBoxColumn.DataPropertyName = "координаты";
            this.координатыDataGridViewTextBoxColumn.HeaderText = "координаты";
            this.координатыDataGridViewTextBoxColumn.Name = "координатыDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorodaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base666BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base666BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base666BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private tempDataSet tempDataSet;
        private System.Windows.Forms.BindingSource gorodaBindingSource;
        private tempDataSetTableAdapters.gorodaTableAdapter gorodaTableAdapter;
        private tempDataSet1 tempDataSet1;
        private System.Windows.Forms.BindingSource base666BindingSource;
        private tempDataSet1TableAdapters.base666TableAdapter base666TableAdapter;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private tempDataSet2 tempDataSet2;
        private System.Windows.Forms.BindingSource base666BindingSource1;
        private tempDataSet2TableAdapters.base666TableAdapter base666TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tempDataSet3 tempDataSet3;
        private System.Windows.Forms.BindingSource base666BindingSource2;
        private tempDataSet3TableAdapters.base666TableAdapter base666TableAdapter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn гDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn прозвонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn администрацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn значениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn численностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расстояниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn областьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn районDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn координатыDataGridViewTextBoxColumn;
    }
}

