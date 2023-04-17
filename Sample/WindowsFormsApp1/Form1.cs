using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            int sum = num1 + num2;
            textAns.Text = sum.ToString();
        }

        private void btPow_Click(object sender, EventArgs e) {

          double resul = Math.Pow((double)tx1.Value ,(double)tx2.Value);
            textBox2.Text = resul.ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textAns_TextChanged(object sender, EventArgs e) {

        }
    }
}
