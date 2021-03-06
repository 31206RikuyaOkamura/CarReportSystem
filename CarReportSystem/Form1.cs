﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> _Cars = new BindingList<CarReport>();

        int cell = -1;

        public Form1()
        {
            InitializeComponent();
            //dgvCarData.DataSource = _Cars;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            /*
            CarReport car = new CarReport
            {
                CreatedDate = dtpCreatedDate.Value,
                Atuthor = cbAtuthor.Text,
                //Maker = CarMakerCheck(),
                Name = cbName.Text,
                Report = tbReport.Text,
                Picture = pbImage.Image
            };
            //メーカーのコンボボックスの入力候補に登録
            setConboBoxAtuthor(cbAtuthor.Text);
            setConboBoxName(cbName.Text);

            //車名がないとき警告
            if (car.Name != "")
            {
                _Cars.Insert(0, car);
            }
            else
            {
                MessageBox.Show("車名を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dgvCarData.ClearSelection(); //選択解除

            btMaskNull();

            //画像の高さを自動調整
            dgvCarData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //次の入力に備えて各項目をクリア
            inputItemAllClear();

            btImageDelete.Enabled = false;
            */
        }

        private void setConboBoxAtuthor(string maker)
        {
            if (!cbAtuthor.Items.Contains(maker))
            {
                //コンボボックスの追加
                cbAtuthor.Items.Add(maker);
            }
        }

        private void setConboBoxName(string maker)
        {
            if (!cbName.Items.Contains(maker))
            {
                //コンボボックスの追加
                cbName.Items.Add(maker);
            }
        }

        private string CarMakerCheck(GroupBox box)
        {
            // 指定したグループ内のラジオボタンでチェックされている物を取り出す
            //var RadioButtonChecked_InGroup = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked);
            //return (CarReport.CarMaker)int.Parse(selectMaker.Tag.ToString());

            string maker = "";
            foreach (RadioButton item in box.Controls)
            {
                if (item.Checked)
                {
                    maker = item.Text;
                }
            }

            switch (maker)
            {
                case "トヨタ":
                    return "トヨタ";

                case "日産":
                    return "日産";

                case "ホンダ":
                    return "ホンダ";

                case "スバル":
                    return "スバル";

                case "外車":
                    return "外車";

                case "その他":
                    return "その他";

                default:
                    return "DEFAULT";
            }
        }

        private void inputItemAllClear()
        {
            cbAtuthor.Text = "";
            rbMaker1.Checked = true;
            cbName.Text = "";
            tbReport.Text = "";
            pbImage.Image = null;
        }

        private void btImageOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbImage.Image = Image.FromFile(openFileDialog.FileName);

                //ピクチャーボックスのサイズに画像を調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

                btImageDelete.Enabled = true;


            }
        }

        private void btImageDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                pbImage.Image = null;
                btImageDelete.Enabled = false;
            }
        }

        private void btMask()
        {
            if (dgvCarData.Rows.Count > 0)
            {
                btUpDate.Enabled = true;
                btDelete.Enabled = true;
            }
            else
            {
                btUpDate.Enabled = false;
                btDelete.Enabled = false;
            }
        }

        private void btMaskNull()
        {
            btUpDate.Enabled = false;
            btDelete.Enabled = false;
        }

        private void btUpDate_Click(object sender, EventArgs e)
        {
            dgvCarData.CurrentRow.Cells[1].Value = dtpCreatedDate.Value;
            dgvCarData.CurrentRow.Cells[2].Value = cbAtuthor.Text;
            dgvCarData.CurrentRow.Cells[3].Value = CarMakerCheck(groupBox1);
            dgvCarData.CurrentRow.Cells[4].Value = cbName.Text;
            dgvCarData.CurrentRow.Cells[5].Value = tbReport.Text;
            if (pbImage.Image == null)
            {
                dgvCarData.CurrentRow.Cells[6].Value = null;
            }
            else
            {
                dgvCarData.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);
            }

            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202023DataSet);
        }

        private void dgvMaker(string maker)
        {
            switch (maker)
            {
                case "トヨタ":
                    rbMaker1.Checked = true;
                    break;

                case "日産":
                    rbMaker2.Checked = true;
                    break;

                case "ホンダ":
                    rbMaker3.Checked = true;
                    break;

                case "スバル":
                    rbMaker4.Checked = true;
                    break;

                case "外車":
                    rbMaker5.Checked = true;
                    break;

                case "その他":
                    rbMaker6.Checked = true;
                    break;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (cell >= 0)
            {

                DialogResult result = MessageBox.Show("本当に削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _Cars.RemoveAt(cell);

                    dgvCarData.ClearSelection();//選択解除

                    //次の入力に備えて各項目をクリア
                    inputItemAllClear();

                    dgvCarData.Refresh(); //データグリッドビューの再描画

                    btMaskNull();
                    btImageDelete.Enabled = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCarData.Columns[0].Visible = false;
            btMask();
            btImageDelete.Enabled = false;

        }

        private void btRead_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202023DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202023DataSet.CarReport);
            dgvCarData.Columns[0].Visible = false;

            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            setValue();

            btMask();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202023DataSet);
        }

        private void 新規入力ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputItemAllClear();
            for (int i = 0; i < _Cars.Count + 1; i++)
            {
                _Cars.RemoveAt(0);
            }
            dgvCarData.Refresh(); //データグリッドビューの再描画

            btMask();
            btImageDelete.Enabled = false;
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //オープンファイルダイアログを表示
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();

                        //逆シリアル化して読み込む
                        _Cars = (BindingList<CarReport>)formatter.Deserialize(fs);

                        dgvCarData.DataSource = _Cars;

                        dtpCreatedDate.Value = _Cars[0].CreatedDate;
                        cbAtuthor.Text = _Cars[0].Atuthor;
                        //dgvMaker(_Cars[0].Maker);
                        cbName.Text = _Cars[0].Name;
                        tbReport.Text = _Cars[0].Report;
                        pbImage.Image = _Cars[0].Picture;

                        //ピクチャーボックスのサイズに画像を調整
                        pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

                        if (pbImage.Image != null)
                        {
                            btImageDelete.Enabled = true;
                        }
                        else
                        {
                            btImageDelete.Enabled = false;
                        }
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //セーブファイルダイアログを表示
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                //FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create);

                //クローズされる
                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, _Cars);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        MessageBox.Show("正しいファイルを選択してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202023DataSet);

        }

        private void dgvCarData_Click(object sender, EventArgs e)
        {
            if (dgvCarData.Rows.Count > 0)
            {
                btImageDelete.Enabled = false;
                setValue();
                btMask();
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }

        private void setValue()
        {
            dtpCreatedDate.Value = (DateTime)dgvCarData.CurrentRow.Cells[1].Value;
            cbAtuthor.Text = dgvCarData.CurrentRow.Cells[2].Value.ToString();
            dgvMaker(dgvCarData.CurrentRow.Cells[3].Value.ToString());
            cbName.Text = dgvCarData.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = dgvCarData.CurrentRow.Cells[5].Value.ToString();
            if (dgvCarData.CurrentRow.Cells[6].Value.ToString() == "")
            {
                pbImage.Image = null;
            }
            else
            {
                pbImage.Image = ByteArrayToImage((byte[])dgvCarData.CurrentRow.Cells[6].Value);
                btImageDelete.Enabled = true;
            }
        }

        private void btSearchExe_Click(object sender, EventArgs e)
        {
            CarMakerCheck(groupBox3);
            //OR検索
            if (rbSearchOr.Checked)
            {
                if (tbSearchCarName.Text == "" && tbSearchAtuthor.Text == "")
                {
                    this.carReportTableAdapter.FillByOrDefault(this.infosys202023DataSet.CarReport, dateTimeSearch.Value.ToString(), CarMakerCheck(groupBox3));
                }
                else if (tbSearchCarName.Text == "")
                {
                    this.carReportTableAdapter.FillByOrAuthor(this.infosys202023DataSet.CarReport, dateTimeSearch.Value.ToString(), tbSearchAtuthor.Text, CarMakerCheck(groupBox3));
                }
                else if (tbSearchAtuthor.Text == "")
                {
                    this.carReportTableAdapter.FillByOrCarName(this.infosys202023DataSet.CarReport, dateTimeSearch.Value.ToString(), CarMakerCheck(groupBox3), tbSearchCarName.Text);
                }
                else
                {
                    this.carReportTableAdapter.FillByOrAll(this.infosys202023DataSet.CarReport, dateTimeSearch.Value.ToString(), tbSearchAtuthor.Text, CarMakerCheck(groupBox3), tbSearchCarName.Text);
                }
            }
            //AND検索
            else
            {
                if (tbSearchCarName.Text == "" && tbSearchAtuthor.Text == "")
                {
                    this.carReportTableAdapter.FillByAndDefault(this.infosys202023DataSet.CarReport, dateTimeSearch.Value.ToString(), CarMakerCheck(groupBox3));
                }
                else if (tbSearchCarName.Text == "")
                {
                    this.carReportTableAdapter.FillByAndAuthor(this.infosys202023DataSet.CarReport, dateTimeSearch.Value.ToString(), CarMakerCheck(groupBox3), tbSearchAtuthor.Text);
                }
                else if (tbSearchAtuthor.Text == "")
                {
                    this.carReportTableAdapter.FillByAndCarName(this.infosys202023DataSet.CarReport, dateTimeSearch.Value.ToString(), CarMakerCheck(groupBox3), tbSearchCarName.Text);
                }
                else
                {
                    this.carReportTableAdapter.FillByAndAll(this.infosys202023DataSet.CarReport, dateTimeSearch.Value.ToString(), tbSearchAtuthor.Text, CarMakerCheck(groupBox3), tbSearchCarName.Text);
                }
            }
        }
    }
}

