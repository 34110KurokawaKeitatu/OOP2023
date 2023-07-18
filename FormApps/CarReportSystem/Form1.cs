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
            Falsebt();
            tsInfoText.Text = "ここにメッセージを表示できます";

            
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
        //ステータスラベルのテキスト表示/非表示
        private void statasLabelDisp(string msg = "") {
            tsInfoText.Text = msg;
        }

        //追加ボタンが押されたときのイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLabelDisp();
            if (cbAuthor.Text.Equals("")) {
                tsInfoText.Text = "記録者の名前を入力して下さい";
                return;
            }
            else if(cbCarName.Text.Equals("")){
                tsInfoText.Text = "車名を入力してください";
                return;
            }
            else
            {
                tsInfoText.Text = "";
            }
            var carReport = new CarReport()
            {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                CarName = cbCarName.Text,
                Maker = getSelectMaker(),
                Report = tbRP.Text,
                CarImage = pbCarImage.Image,
            };
            cbAuthor.Items.Add(cbAuthor.Text);
            cbCarName.Items.Add(cbCarName.Text);
            CarReports.Add(carReport);
            Clear();
            Falsebt();
            dgvCarReports.CurrentCell = null;
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
                if(dgvCarReports.Rows.Count == 0)
                {
                    Falsebt();
                }
                Clear();
            }
        }

        private void btModyfiReport_Click(object sender, EventArgs e) {
            if (dgvCarReports.SelectedRows.Count <= 0)
            {
                tsInfoText.Text = "行を選択してください";
            }
            else
            { 
                dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Text;
                dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
                dgvCarReports.CurrentRow.Cells[2].Value = getSelectMaker();
                dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
                dgvCarReports.CurrentRow.Cells[4].Value = tbRP.Text;
                dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;
                Clear();
            }
        }

        private void dgvCarReports_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            Truebt();
            dtpDate.Text = dgvCarReports.CurrentRow.Cells[0].Value.ToString();
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            tbRP.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }

        public void Clear() {
            dtpDate.Text = null;
            cbAuthor.Text = null;
            cbCarName.Text = null;
            tbRP.Text = null;
            pbCarImage.Image = null;
            foreach(var item in gbMaker.Controls){

                ((RadioButton)item).Checked = false;
            }


        }
        public void Falsebt() {
            
            btImageDeleteReport.Enabled = false;
            btModyfiReport.Enabled = false;
        }
        public void Truebt() {
            btImageDeleteReport.Enabled = true;
            btModyfiReport.Enabled = true;
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        private void バージョン情報ToolStripMenuItem1_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();

           
        }
    }
}

