using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;

            var no = DateTime.Now - dtp;
            

            now.Text = dtp.ToString("T");
            tbMeesge.Text = "生まれて" + no.Days;
        }

        private void PlusYear_Click(object sender, EventArgs e) {
           
        }

        private void MinusYear_Click(object sender, EventArgs e) {

        }

        private void PlusMonth_Click(object sender, EventArgs e) {

        }

        private void MinusMonth_Click(object sender, EventArgs e) {

        }

        private void PlusDay_Click(object sender, EventArgs e) {

        }

        private void MinusDay_Click(object sender, EventArgs e) {

        }

        private void btAge_Click(object sender, EventArgs e) {
            var today = DateTime.Now;
            var birthDay = dtpDate.Value;
           

            int age = today.Year - birthDay.Year;
            if (today < birthDay.AddYears(age))
                age--;
            tbMeesge.Text = age + "才";
        }

        //タイマーイベントハンドラー
        private void tmTimeDisp_Tick(object sender, EventArgs e) {

            now.Text = DateTime.Now.ToString("yyyy/MM/dd(dddd) HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e) {
            tmTimeDisp.Start();
            
        }
    }
}
