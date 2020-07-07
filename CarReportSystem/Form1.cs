using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> _Cars = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            dgvCarData.DataSource = _Cars;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {

            CarReport car = new CarReport
            {
                CreatedDate = dtpCreatedDate.Value,
                Atuthor = cbAtuthor.Text,
                Maker = CarMakerCheck(),
                Name = cbName.Text,
                Report = tbReport.Text,
                Picture = pbImage.Image
            };

            _Cars.Insert(0,car);

        }

        private CarReport.CarMaker CarMakerCheck()
        {
            // 指定したグループ内のラジオボタンでチェックされている物を取り出す
            //var RadioButtonChecked_InGroup = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked);
            //return (CarReport.CarMaker)int.Parse(selectMaker.Tag.ToString());

            string maker = "";
            foreach (RadioButton item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    maker = item.Text;
                }
            }

            switch (maker)
            {
                case "トヨタ":
                    return CarReport.CarMaker.トヨタ;

                case "日産":
                    return CarReport.CarMaker.日産;

                case "ホンダ":
                    return CarReport.CarMaker.ホンダ;

                case "スバル":
                    return CarReport.CarMaker.スバル;

                case "外車":
                    return CarReport.CarMaker.外車;

                case "その他":
                    return CarReport.CarMaker.その他;

                default:
                    return CarReport.CarMaker.DEFAULT;
            }
        }
    }
}
