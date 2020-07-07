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
            this.dgvCarData = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧：";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Location = new System.Drawing.Point(92, 18);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(200, 19);
            this.dtpCreatedDate.TabIndex = 1;
            // 
            // cbAtuthor
            // 
            this.cbAtuthor.FormattingEnabled = true;
            this.cbAtuthor.Location = new System.Drawing.Point(92, 67);
            this.cbAtuthor.Name = "cbAtuthor";
            this.cbAtuthor.Size = new System.Drawing.Size(121, 20);
            this.cbAtuthor.TabIndex = 2;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(92, 161);
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
            this.tbReport.Location = new System.Drawing.Point(92, 208);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(455, 115);
            this.tbReport.TabIndex = 4;
            // 
            // dgvCarData
            // 
            this.dgvCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarData.Location = new System.Drawing.Point(92, 329);
            this.dgvCarData.Name = "dgvCarData";
            this.dgvCarData.RowTemplate.Height = 21;
            this.dgvCarData.Size = new System.Drawing.Size(790, 150);
            this.dgvCarData.TabIndex = 5;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(11, 355);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(63, 34);
            this.btRead.TabIndex = 6;
            this.btRead.Text = "開く...";
            this.btRead.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(11, 405);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(63, 34);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(92, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 34);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btImageDelete
            // 
            this.btImageDelete.Location = new System.Drawing.Point(751, 18);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(75, 23);
            this.btImageDelete.TabIndex = 10;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            // 
            // btImageOpen
            // 
            this.btImageOpen.Location = new System.Drawing.Point(642, 18);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(75, 23);
            this.btImageOpen.TabIndex = 11;
            this.btImageOpen.Text = "開く...";
            this.btImageOpen.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbImage.Location = new System.Drawing.Point(590, 54);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(260, 225);
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(581, 285);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(75, 23);
            this.btRegister.TabIndex = 13;
            this.btRegister.Text = "追加";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btUpDate
            // 
            this.btUpDate.Location = new System.Drawing.Point(694, 285);
            this.btUpDate.Name = "btUpDate";
            this.btUpDate.Size = new System.Drawing.Size(75, 23);
            this.btUpDate.TabIndex = 13;
            this.btUpDate.Text = "修正";
            this.btUpDate.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(807, 285);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 513);
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
            this.Controls.Add(this.dgvCarData);
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
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCarData;
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
    }
}

