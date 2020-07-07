using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem
{
    class CarReport
    {
        //作成日
        public DateTime CreatedDate { set; get; }

        //記録者
        public string Atuthor { set; get; }

        //メーカー
        public CarMaker Maker { set; get; }

        //車名
        public string Name { set; get; }

        //レポート
        public string Report { set; get; }

        //画像
        public Image Picture { set; get; }


        public enum CarMaker
        {
            DEFAULT,
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外車,
            その他
        }
    }
}
