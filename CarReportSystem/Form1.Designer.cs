namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.cbAtuthor = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.rbMaker6 = new System.Windows.Forms.RadioButton();
            this.rbMaker1 = new System.Windows.Forms.RadioButton();
            this.rbMaker2 = new System.Windows.Forms.RadioButton();
            this.rbMaker3 = new System.Windows.Forms.RadioButton();
            this.rbMaker4 = new System.Windows.Forms.RadioButton();
            this.rbMaker5 = new System.Windows.Forms.RadioButton();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btUpDate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvCarData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202023DataSet = new CarReportSystem.infosys202023DataSet();
            this.tbSearchAtuthor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSearchOr = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.dateTimeSearch = new System.Windows.Forms.DateTimePicker();
            this.rbSearchAnd = new System.Windows.Forms.RadioButton();
            this.btSearchExe = new System.Windows.Forms.Button();
            this.tbSearchCarName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.carReportTableAdapter = new CarReportSystem.infosys202023DataSetTableAdapters.CarReportTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202023DataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202023DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧：";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Location = new System.Drawing.Point(92, 40);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(200, 19);
            this.dtpCreatedDate.TabIndex = 1;
            // 
            // cbAtuthor
            // 
            this.cbAtuthor.FormattingEnabled = true;
            this.cbAtuthor.Location = new System.Drawing.Point(92, 89);
            this.cbAtuthor.Name = "cbAtuthor";
            this.cbAtuthor.Size = new System.Drawing.Size(121, 20);
            this.cbAtuthor.TabIndex = 2;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(92, 183);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 20);
            this.cbName.TabIndex = 2;
            // 
            // rbMaker6
            // 
            this.rbMaker6.AutoSize = true;
            this.rbMaker6.Location = new System.Drawing.Point(400, 12);
            this.rbMaker6.Name = "rbMaker6";
            this.rbMaker6.Size = new System.Drawing.Size(54, 16);
            this.rbMaker6.TabIndex = 3;
            this.rbMaker6.Text = "その他";
            this.rbMaker6.UseVisualStyleBackColor = true;
            // 
            // rbMaker1
            // 
            this.rbMaker1.AutoSize = true;
            this.rbMaker1.Checked = true;
            this.rbMaker1.Location = new System.Drawing.Point(6, 12);
            this.rbMaker1.Name = "rbMaker1";
            this.rbMaker1.Size = new System.Drawing.Size(47, 16);
            this.rbMaker1.TabIndex = 3;
            this.rbMaker1.TabStop = true;
            this.rbMaker1.Text = "トヨタ";
            this.rbMaker1.UseVisualStyleBackColor = true;
            // 
            // rbMaker2
            // 
            this.rbMaker2.AutoSize = true;
            this.rbMaker2.Location = new System.Drawing.Point(83, 12);
            this.rbMaker2.Name = "rbMaker2";
            this.rbMaker2.Size = new System.Drawing.Size(47, 16);
            this.rbMaker2.TabIndex = 3;
            this.rbMaker2.Text = "日産";
            this.rbMaker2.UseVisualStyleBackColor = true;
            // 
            // rbMaker3
            // 
            this.rbMaker3.AutoSize = true;
            this.rbMaker3.Location = new System.Drawing.Point(160, 12);
            this.rbMaker3.Name = "rbMaker3";
            this.rbMaker3.Size = new System.Drawing.Size(51, 16);
            this.rbMaker3.TabIndex = 3;
            this.rbMaker3.Text = "ホンダ";
            this.rbMaker3.UseVisualStyleBackColor = true;
            // 
            // rbMaker4
            // 
            this.rbMaker4.AutoSize = true;
            this.rbMaker4.Location = new System.Drawing.Point(241, 12);
            this.rbMaker4.Name = "rbMaker4";
            this.rbMaker4.Size = new System.Drawing.Size(52, 16);
            this.rbMaker4.TabIndex = 3;
            this.rbMaker4.Text = "スバル";
            this.rbMaker4.UseVisualStyleBackColor = true;
            // 
            // rbMaker5
            // 
            this.rbMaker5.AutoSize = true;
            this.rbMaker5.Location = new System.Drawing.Point(323, 12);
            this.rbMaker5.Name = "rbMaker5";
            this.rbMaker5.Size = new System.Drawing.Size(47, 16);
            this.rbMaker5.TabIndex = 3;
            this.rbMaker5.Text = "外車";
            this.rbMaker5.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(92, 230);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(455, 115);
            this.tbReport.TabIndex = 4;
            // 
            // btRead
            // 
            this.btRead.BackColor = System.Drawing.Color.LightCoral;
            this.btRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRead.Location = new System.Drawing.Point(11, 377);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(63, 34);
            this.btRead.TabIndex = 6;
            this.btRead.Text = "接続";
            this.btRead.UseVisualStyleBackColor = false;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(11, 427);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(63, 34);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "画像：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMaker6);
            this.groupBox1.Controls.Add(this.rbMaker1);
            this.groupBox1.Controls.Add(this.rbMaker2);
            this.groupBox1.Controls.Add(this.rbMaker3);
            this.groupBox1.Controls.Add(this.rbMaker4);
            this.groupBox1.Controls.Add(this.rbMaker5);
            this.groupBox1.Location = new System.Drawing.Point(92, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 34);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btImageDelete
            // 
            this.btImageDelete.Location = new System.Drawing.Point(745, 40);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(75, 23);
            this.btImageDelete.TabIndex = 10;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // btImageOpen
            // 
            this.btImageOpen.Location = new System.Drawing.Point(637, 40);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(75, 23);
            this.btImageOpen.TabIndex = 11;
            this.btImageOpen.Text = "開く...";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbImage.Location = new System.Drawing.Point(590, 76);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(260, 225);
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(581, 307);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(75, 23);
            this.btRegister.TabIndex = 13;
            this.btRegister.Text = "追加";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btUpDate
            // 
            this.btUpDate.Location = new System.Drawing.Point(694, 307);
            this.btUpDate.Name = "btUpDate";
            this.btUpDate.Size = new System.Drawing.Size(75, 23);
            this.btUpDate.TabIndex = 13;
            this.btUpDate.Text = "修正";
            this.btUpDate.UseVisualStyleBackColor = true;
            this.btUpDate.Click += new System.EventHandler(this.btUpDate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(807, 307);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1242, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvCarData
            // 
            this.dgvCarData.AllowUserToAddRows = false;
            this.dgvCarData.AutoGenerateColumns = false;
            this.dgvCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.dgvCarData.DataSource = this.carReportBindingSource;
            this.dgvCarData.Location = new System.Drawing.Point(93, 351);
            this.dgvCarData.MultiSelect = false;
            this.dgvCarData.Name = "dgvCarData";
            this.dgvCarData.ReadOnly = true;
            this.dgvCarData.RowTemplate.Height = 21;
            this.dgvCarData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarData.Size = new System.Drawing.Size(790, 220);
            this.dgvCarData.TabIndex = 22;
            this.dgvCarData.Click += new System.EventHandler(this.dgvCarData_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // carReportBindingSource
            // 
            this.carReportBindingSource.DataMember = "CarReport";
            this.carReportBindingSource.DataSource = this.infosys202023DataSet;
            // 
            // infosys202023DataSet
            // 
            this.infosys202023DataSet.DataSetName = "infosys202023DataSet";
            this.infosys202023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSearchAtuthor
            // 
            this.tbSearchAtuthor.Location = new System.Drawing.Point(61, 46);
            this.tbSearchAtuthor.Name = "tbSearchAtuthor";
            this.tbSearchAtuthor.Size = new System.Drawing.Size(180, 19);
            this.tbSearchAtuthor.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "記録者：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.rbSearchOr);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dateTimeSearch);
            this.groupBox2.Controls.Add(this.rbSearchAnd);
            this.groupBox2.Controls.Add(this.btSearchExe);
            this.groupBox2.Controls.Add(this.tbSearchCarName);
            this.groupBox2.Controls.Add(this.tbSearchAtuthor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(886, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 225);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "検索";
            // 
            // rbSearchOr
            // 
            this.rbSearchOr.AutoSize = true;
            this.rbSearchOr.Location = new System.Drawing.Point(178, 165);
            this.rbSearchOr.Name = "rbSearchOr";
            this.rbSearchOr.Size = new System.Drawing.Size(63, 16);
            this.rbSearchOr.TabIndex = 27;
            this.rbSearchOr.TabStop = true;
            this.rbSearchOr.Text = "OR検索";
            this.rbSearchOr.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Location = new System.Drawing.Point(61, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 59);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(157, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "その他";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "トヨタ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(83, 12);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "日産";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(160, 12);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "ホンダ";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 34);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(52, 16);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.Text = "スバル";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(83, 34);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(47, 16);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.Text = "外車";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // dateTimeSearch
            // 
            this.dateTimeSearch.Location = new System.Drawing.Point(61, 19);
            this.dateTimeSearch.Name = "dateTimeSearch";
            this.dateTimeSearch.Size = new System.Drawing.Size(180, 19);
            this.dateTimeSearch.TabIndex = 25;
            // 
            // rbSearchAnd
            // 
            this.rbSearchAnd.AutoSize = true;
            this.rbSearchAnd.Checked = true;
            this.rbSearchAnd.Location = new System.Drawing.Point(61, 165);
            this.rbSearchAnd.Name = "rbSearchAnd";
            this.rbSearchAnd.Size = new System.Drawing.Size(71, 16);
            this.rbSearchAnd.TabIndex = 26;
            this.rbSearchAnd.TabStop = true;
            this.rbSearchAnd.Text = "AND検索";
            this.rbSearchAnd.UseVisualStyleBackColor = true;
            // 
            // btSearchExe
            // 
            this.btSearchExe.Location = new System.Drawing.Point(107, 196);
            this.btSearchExe.Name = "btSearchExe";
            this.btSearchExe.Size = new System.Drawing.Size(75, 23);
            this.btSearchExe.TabIndex = 24;
            this.btSearchExe.Text = "実行";
            this.btSearchExe.UseVisualStyleBackColor = true;
            this.btSearchExe.Click += new System.EventHandler(this.btSearchExe_Click);
            // 
            // tbSearchCarName
            // 
            this.tbSearchCarName.Location = new System.Drawing.Point(61, 140);
            this.tbSearchCarName.Name = "tbSearchCarName";
            this.tbSearchCarName.Size = new System.Drawing.Size(180, 19);
            this.tbSearchCarName.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "日付：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "車名：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "メーカー：";
            // 
            // carReportTableAdapter
            // 
            this.carReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableAdapter = this.carReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202023DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCarData);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.btUpDate);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbAtuthor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202023DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.ComboBox cbAtuthor;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.RadioButton rbMaker6;
        private System.Windows.Forms.RadioButton rbMaker1;
        private System.Windows.Forms.RadioButton rbMaker2;
        private System.Windows.Forms.RadioButton rbMaker3;
        private System.Windows.Forms.RadioButton rbMaker4;
        private System.Windows.Forms.RadioButton rbMaker5;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btUpDate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private infosys202023DataSet infosys202023DataSet;
        private System.Windows.Forms.BindingSource carReportBindingSource;
        private infosys202023DataSetTableAdapters.CarReportTableAdapter carReportTableAdapter;
        private infosys202023DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvCarData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox tbSearchAtuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSearchExe;
        private System.Windows.Forms.DateTimePicker dateTimeSearch;
        private System.Windows.Forms.RadioButton rbSearchOr;
        private System.Windows.Forms.RadioButton rbSearchAnd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TextBox tbSearchCarName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}

