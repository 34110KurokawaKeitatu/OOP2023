using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用のデータ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }
        //追加ボタンが押されたときのイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            var CarReport = new CarReport();
            CarReport.Date = dtpDate.Value;
            CarReport.Author = cbAuthor.Text;
            CarReport.CarName = cbCarName.Text;
            CarReport.Maker = getSelectMaker();

            CarReports.Add(CarReport);

        }
        private CarReport.MakerGroup getSelectMaker() {


            return CarReport.MakerGroup.TOYOTA;
        }
    }
}
