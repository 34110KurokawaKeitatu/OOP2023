
namespace Section01 {
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
            this.btRunNotepad = new System.Windows.Forms.Button();
            this.RunAndWaitNotepad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRunNotepad
            // 
            this.btRunNotepad.Location = new System.Drawing.Point(178, 82);
            this.btRunNotepad.Name = "btRunNotepad";
            this.btRunNotepad.Size = new System.Drawing.Size(214, 133);
            this.btRunNotepad.TabIndex = 0;
            this.btRunNotepad.Text = "RunNotepad";
            this.btRunNotepad.UseVisualStyleBackColor = true;
            this.btRunNotepad.Click += new System.EventHandler(this.btRunNotepad_Click);
            // 
            // RunAndWaitNotepad
            // 
            this.RunAndWaitNotepad.Location = new System.Drawing.Point(465, 97);
            this.RunAndWaitNotepad.Name = "RunAndWaitNotepad";
            this.RunAndWaitNotepad.Size = new System.Drawing.Size(134, 118);
            this.RunAndWaitNotepad.TabIndex = 1;
            this.RunAndWaitNotepad.Text = "RunAndWaitNotepad";
            this.RunAndWaitNotepad.UseVisualStyleBackColor = true;
            this.RunAndWaitNotepad.Click += new System.EventHandler(this.RunAndWaitNotepad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunAndWaitNotepad);
            this.Controls.Add(this.btRunNotepad);
            this.Name = "Form1";
            this.Text = "14章1節";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRunNotepad;
        private System.Windows.Forms.Button RunAndWaitNotepad;
    }
}

