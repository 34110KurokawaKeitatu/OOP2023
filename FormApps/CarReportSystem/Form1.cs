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
            dgvCarReports.Columns[5].Visible = false;
        }

        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup)
            {
                case CarReport.MakerGroup.TOYOTA:
                    rbTOYOTA.Checked = true;
                    break;
                case CarReport.MakerGroup.NISSAN:
                    rbNISSAN.Checked = true;
                    break;
                case CarReport.MakerGroup.MAZDA:
                    rbMAZDA.Checked = true;
                    break;
                case CarReport.MakerGroup.SUZUKI:
                    rbSUZUKI.Checked = true;
                    break;
                case CarReport.MakerGroup.SUBARU:
                    rbSUBARU.Checked = true;
                    break;
                case CarReport.MakerGroup.BMW:
                    rbBMW.Checked = true;
                    break;
                case CarReport.MakerGroup.AUDI:
                    rbAUDI.Checked = true;
                    break;
            }

        }

        //追加ボタンが押されたときのイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            var carReport = new CarReport()
            {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                CarName = cbCarName.Text,
                Maker = getSelectMaker(),
                Report = tbRP.Text,
                CarImage = pbCarImage.Image,
            };
            CarReports.Add(carReport);

        }
        private CarReport.MakerGroup getSelectMaker() {

            /* foreach (var item in gbMaker.Controls)
             {
                 if (((RadioButton)item).Checked)
                 {
                     int tag = int.Parse(((RadioButton)item).Tag.ToString());
                     break;
                 }

             }
             return CarReport.MakerGroup.そのほか;
             */
            if (rbTOYOTA.Checked)
            {
                return CarReport.MakerGroup.TOYOTA;
            }
            else if (rbNISSAN.Checked)
            {
                return CarReport.MakerGroup.NISSAN;
            }
            else if (rbMAZDA.Checked)
            {
                return CarReport.MakerGroup.MAZDA;
            }
            else if (rbSUZUKI.Checked)
            {
                return CarReport.MakerGroup.SUZUKI;
            }
            else if (rbSUBARU.Checked)
            {
                return CarReport.MakerGroup.SUBARU;
            }
            else if (rbBMW.Checked)
            {
                return CarReport.MakerGroup.BMW;
            }
            else if (rbAUDI.Checked)
            {
                return CarReport.MakerGroup.AUDI;
            }
            return CarReport.MakerGroup.そのほか;
        }

        private void btImageOpenReport_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            pbCarImage.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btImageDeleteReport_Click(object sender, EventArgs e) {
            {
                DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
                for (int i = src.Count - 1; i >= 0; i--)
                {
                    dgvCarReports.Rows.RemoveAt(src[i].Index);
                }

            }
        }

        private void btModyfiReport_Click(object sender, EventArgs e) {

            dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Text;
            dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[2].Value = getSelectMaker();
            dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[4].Value = tbRP.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;
        }

        private void dgvCarReports_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            dtpDate.Text = dgvCarReports.CurrentRow.Cells[0].Value.ToString();
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            tbRP.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }
    }
}

