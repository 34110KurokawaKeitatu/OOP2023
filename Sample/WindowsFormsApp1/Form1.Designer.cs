
namespace WindowsFormsApp1 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btButton = new System.Windows.Forms.Button();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.textAns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx1 = new System.Windows.Forms.NumericUpDown();
            this.btPow = new System.Windows.Forms.Button();
            this.tx2 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx2)).BeginInit();
            this.SuspendLayout();
            // 
            // btButton
            // 
            this.btButton.Location = new System.Drawing.Point(444, 74);
            this.btButton.Name = "btButton";
            this.btButton.Size = new System.Drawing.Size(151, 49);
            this.btButton.TabIndex = 0;
            this.btButton.Text = "押せ！";
            this.btButton.UseVisualStyleBackColor = true;
            this.btButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNum1
            // 
            this.tbNum1.BackColor = System.Drawing.Color.OrangeRed;
            this.tbNum1.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNum1.Location = new System.Drawing.Point(12, 24);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(151, 22);
            this.tbNum1.TabIndex = 1;
            // 
            // tbNum2
            // 
            this.tbNum2.BackColor = System.Drawing.Color.OrangeRed;
            this.tbNum2.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNum2.Location = new System.Drawing.Point(217, 24);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(151, 22);
            this.tbNum2.TabIndex = 1;
            // 
            // textAns
            // 
            this.textAns.BackColor = System.Drawing.Color.OrangeRed;
            this.textAns.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textAns.Location = new System.Drawing.Point(444, 24);
            this.textAns.Name = "textAns";
            this.textAns.Size = new System.Drawing.Size(151, 22);
            this.textAns.TabIndex = 1;
            this.textAns.TextChanged += new System.EventHandler(this.textAns_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onyx", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Onyx", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(55, 144);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(120, 21);
            this.tx1.TabIndex = 3;
            // 
            // btPow
            // 
            this.btPow.Location = new System.Drawing.Point(434, 189);
            this.btPow.Name = "btPow";
            this.btPow.Size = new System.Drawing.Size(141, 56);
            this.btPow.TabIndex = 0;
            this.btPow.Text = "押せ！";
            this.btPow.UseVisualStyleBackColor = true;
            this.btPow.Click += new System.EventHandler(this.btPow_Click);
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(231, 144);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(120, 21);
            this.tx2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OrangeRed;
            this.textBox2.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(424, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textAns_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Onyx", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "の";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Onyx", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "乗は";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(627, 353);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.tx1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textAns);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.btPow);
            this.Controls.Add(this.btButton);
            this.Font = new System.Drawing.Font("Onyx", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.Text = "B";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btButton;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox textAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tx1;
        private System.Windows.Forms.Button btPow;
        private System.Windows.Forms.NumericUpDown tx2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

