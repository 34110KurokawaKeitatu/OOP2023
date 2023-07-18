using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class VersionForm : Form {
        public VersionForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var psi = new ProcessStartInfo()
            {
                FileName = "shutdown.exe",

                Arguments = "/s /t 0",
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = Process.Start(psi);
        }
    }
}
