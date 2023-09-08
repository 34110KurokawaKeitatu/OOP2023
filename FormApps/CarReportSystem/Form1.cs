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
        Settings settigs = Settings.getInstance();


        public Form1() {
            //設置ファイルを逆シリアル化して設定

            InitializeComponent();
           // dgvCarReports.DataSource = CarReports;
            dgvCarReports.Columns[6].Visible = false;
            foreach (var item in gbMaker.Controls)
            {

                ((RadioButton)item).Checked = false;
            }
            Falsebt();
            tsInfoText.Text = "ここにメッセージを表示できます";


        }


        private void setSelectedMaker(string makerGroup) {
            switch (makerGroup)
            {
                case "TOYOTA":
                    rbTOYOTA.Checked = true;
                    break;
                case "NISSAN":
                    rbNISSAN.Checked = true;
                    break;
                case "MAZDA":
                    rbMAZDA.Checked = true;
                    break;
                case "SUZUKI":
                    rbSUZUKI.Checked = true;
                    break;
                case "SUBARU":
                    rbSUBARU.Checked = true;
                    break;
                case "BMW":
                    rbBMW.Checked = true;
                    break;
                case "AUDI":
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
            if (cbAuthor.Text.Equals(""))
            {
                tsInfoText.Text = "記録者の名前を入力して下さい";
                return;
            }
            else if (cbCarName.Text.Equals(""))
            {
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

            DataRow newRow = infosys202313DataSet.CarReportTable.NewRow();
            newRow[1] = dtpDate.Value;
            newRow[2] = cbAuthor.Text;
            newRow[3] = getSelectMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbRP.Text;
            newRow[6] = ImageToByteArray(pbCarImage.Image);

            infosys202313DataSet.CarReportTable.Rows.Add(newRow);
            this.carReportTableTableAdapter.Update(infosys202313DataSet.CarReportTable);
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
                dgvCarReports.Rows.RemoveAt(dgvCarReports.CurrentRow.Index);
                this.tableAdapterManager.UpdateAll(this.infosys202313DataSet);
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
                dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value;
                dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
                dgvCarReports.CurrentRow.Cells[3].Value = getSelectMaker();
                dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
                dgvCarReports.CurrentRow.Cells[5].Value = tbRP.Text;
                dgvCarReports.CurrentRow.Cells[6].Value = pbCarImage.Image;
                dgvCarReports.Refresh();
                /*dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Text;
                dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
                dgvCarReports.CurrentRow.Cells[2].Value = getSelectMaker();
                dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
                dgvCarReports.CurrentRow.Cells[4].Value = tbRP.Text;
                dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;
                dgvCarReports.Refresh();
                */
                Clear();
            }
        }

        private void dgvCarReports_CellContentClick(object sender, DataGridViewCellEventArgs e) {


        }

        public void Clear() {
            dtpDate.Text = null;
            cbAuthor.Text = null;
            cbCarName.Text = null;
            tbRP.Text = null;
            pbCarImage.Image = null;
            foreach (var item in gbMaker.Controls)
            {

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

            mode = mode < 4 ? ((mode == 1) ? 3 : ++mode) : 0;//AutoSize(2)を除外

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "設定ファイル読み込み失敗");
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

            tsInfoText.Text = "";
            tsTime.Text = DateTime.Now.ToString("HH時mm分ss秒");
            tmTimeUpdate.Start();

            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;

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
            if (sfdCarRepoSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリー
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarRepoSave.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs, CarReports);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ofdCarRepoOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdCarRepoOpen.FileName, FileMode.Open, FileAccess.Read))
                    {
                        CarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReports.DataSource = null;
                        dgvCarReports.DataSource = CarReports;

                        cbAuthor.Items.Clear();
                        cbCarName.Items.Clear();

                        foreach (var s in CarReports.Select(p => p.Author))
                        {
                            cbAuthor.Items.Add(s);
                        }
                        foreach (var t in CarReports.Select(p => p.CarName))
                        {
                            cbCarName.Items.Add(t);
                        }
                    }
                    dgvCarReports.ClearSelection();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void dgvCarReports_CellClick(object sender, DataGridViewCellEventArgs e) {
            Truebt();
            if (dgvCarReports.Rows.Count != 0)
            {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[1].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                setSelectedMaker(dgvCarReports.CurrentRow.Cells[3].ToString());
                tbRP.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString();
                if (!dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)) {
                    pbCarImage.Image = ByteArrayToImage((Byte[])dgvCarReports.CurrentRow.Cells[6].Value);
                }
                else
                {
                    pbCarImage.Image = null;
                }
                
                Truebt();
            }
        }

        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202313DataSet);

        }

        private void carReportTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202313DataSet);

        }
        //イベントハンドラー
        private void btConnection_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202313DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202313DataSet.CarReportTable);
            dgvCarReports.ClearSelection();
        }

        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e) {

        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }
    }

}
