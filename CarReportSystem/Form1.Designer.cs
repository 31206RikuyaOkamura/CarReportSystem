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
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規入力ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.carReportTableAdapter = new CarReportSystem.infosys202023DataSetTableAdapters.CarReportTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202023DataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202023DataSet)).BeginInit();
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
            this.dtpCreatedDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "CreatedDate", true));
            this.dtpCreatedDate.Location = new System.Drawing.Point(92, 40);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(200, 19);
            this.dtpCreatedDate.TabIndex = 1;
            // 
            // cbAtuthor
            // 
            this.cbAtuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "Author", true));
            this.cbAtuthor.FormattingEnabled = true;
            this.cbAtuthor.Location = new System.Drawing.Point(92, 89);
            this.cbAtuthor.Name = "cbAtuthor";
            this.cbAtuthor.Size = new System.Drawing.Size(121, 20);
            this.cbAtuthor.TabIndex = 2;
            // 
            // cbName
            // 
            this.cbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "Name", true));
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
            this.tbReport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "Report", true));
            this.tbReport.Location = new System.Drawing.Point(92, 230);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(455, 115);
            this.tbReport.TabIndex = 4;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(11, 377);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(63, 34);
            this.btRead.TabIndex = 6;
            this.btRead.Text = "接続...";
            this.btRead.UseVisualStyleBackColor = true;
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
            this.btImageDelete.Location = new System.Drawing.Point(751, 40);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(75, 23);
            this.btImageDelete.TabIndex = 10;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // btImageOpen
            // 
            this.btImageOpen.Location = new System.Drawing.Point(642, 40);
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規入力ToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.名前を付けて保存ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規入力ToolStripMenuItem
            // 
            this.新規入力ToolStripMenuItem.Name = "新規入力ToolStripMenuItem";
            this.新規入力ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.新規入力ToolStripMenuItem.Text = "新規入力(&N)";
            this.新規入力ToolStripMenuItem.Click += new System.EventHandler(this.新規入力ToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.開くToolStripMenuItem.Text = "開く...(&O)";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            this.名前を付けて保存ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存...";
            this.名前を付けて保存ToolStripMenuItem.Click += new System.EventHandler(this.名前を付けて保存ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.終了ToolStripMenuItem.Text = "終了(&X)";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
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
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(922, 580);
            this.Controls.Add(this.dgvCarData);
            this.Controls.Add(this.btDelete);
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
            this.Controls.Add(this.dtpCreatedDate);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202023DataSet)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規入力ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
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
    }
}

