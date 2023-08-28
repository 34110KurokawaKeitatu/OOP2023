using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用のデータ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private uint mode;
        //設定情報保存用オブジェクト
        Settings settigs = new Settings();
             

        public Form1() {
            //設置ファイルを逆シリアル化して設定
            
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
            dgvCarReports.Columns[5].Visible = false;
            foreach (var item in gbMaker.Controls)
            {

                ((RadioButton)item).Checked = false;
            }
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
            if (!cbAuthor.Items.Contains(cbAuthor.Text))
            {
                cbAuthor.Items.Add(cbAuthor.Text);
            }
            if (!cbCarName.Items.Contains(cbCarName.Text))
            {
                cbCarName.Items.Add(cbCarName.Text);
            }
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

        private void 背景の色変更ToolStripMenuItem_Click(object sender, EventArgs e) {

            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                BackColor = cdColor.Color;
                settigs.MainFormColor = cdColor.Color.ToArgb();

            }

        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            
            mode = mode < 4 ?((mode == 1) ?3 : ++mode) : 0;//AutoSize(2)を除外

            pbCarImage.SizeMode = (PictureBoxSizeMode)mode;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルシリアル化
            try
            {
                using (var writer = XmlWriter.Create("settings.xml"))
                {
                    var serializer = new XmlSerializer(settigs.MainFormColor.GetType());
                    serializer.Serialize(writer, settigs.MainFormColor);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message +  "設定ファイル読み込み失敗");
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            tsInfoText.Text = "";
            tsTime.Text = DateTime.Now.ToString("HH時mm分ss秒");
            tmTimeUpdate.Start();


            using (var writer = XmlReader.Create("bColor.xml"))
            {
                var serializer = new XmlSerializer(typeof(Settings));
                settigs = serializer.Deserialize(writer) as Settings;
                BackColor = Color.FromArgb(settigs.MainFormColor);
            }
        }

        private void tmTimeUpdate_Tick(object sender, EventArgs e) {
            tsTime.Text = DateTime.Now.ToString("HH時mm分ss秒");
        }

        private void 保存CtrlSToolStripMenuItem_Click(object sender, EventArgs e) {
            if(sfdCarRepoSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリー
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarRepoSave.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs,CarReports);
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            if(ofdCarRepoOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdCarRepoOpen.FileName, FileMode.Open, FileAccess.Read))
                    {
                        CarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReports.DataSource = null;
                        dgvCarReports.DataSource = CarReports;

                        foreach (var s in CarReports)
                        {
                            if (!cbAuthor.Items.Contains(cbAuthor.Text))
                            {
                                cbAuthor.Items.Add(s.Author);
                            }
                            if (!cbCarName.Items.Contains(cbCarName.Text))
                            {
                                cbCarName.Items.Add(s.CarName);
                            }
                        }
                        dgvCarReports.ClearSelection();
                    }
                }catch (Exception ex)
                {

                }
            }
        }
    }
}