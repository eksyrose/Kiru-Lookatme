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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.gMapControl1.Location = new System.Drawing.Point(53, 52);
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
            this.gMapControl1.Size = new System.Drawing.Size(156, 150);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(800, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(915, 170);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            this.panel1.Location = new System.Drawing.Point(894, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 259);
            this.panel1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.MinimumSize = new System.Drawing.Size(800, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 216);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(921, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Прозвон дат";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(848, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Прозвон заявок";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(848, 190);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Визуализация";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1095, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Комментарий";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(12, 244);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(856, 243);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(848, 217);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "О городе";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(848, 217);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "О заявке";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(947, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "+ город";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(947, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "+ заявка";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Город";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2016";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2017";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Статус даты";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Праздник";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Значение";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Числ-ть";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Расст-е";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Область";
            this.Column9.Name = "Column9";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(947, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}

