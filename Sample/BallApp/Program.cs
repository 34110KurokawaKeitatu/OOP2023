using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {

        private Timer moveTimer;
        private SoccerBall soccerBall;
        private PictureBox pb; //画像をコントロールする
        static void Main(string[] args) {
            

            Application.Run(new Program());

        }

        public Program() {

           // this.Width = 1920;//幅プロパティ
           // this.Height = 1080;//高さプロパティ]
            this.Size = new Size(800, 600);
            
            this.BackColor = Color.Green;
            this.Text = "BallGame";
            this.MouseClick += Program_MouseClick;
            
            moveTimer = new Timer();
            moveTimer.Interval = 1;//タイマーのインターバル（ｍｓ
            moveTimer.Tick += MoveTimer_Tick;//デリゲート登録
        }

        private void Program_MouseClick(object sender, MouseEventArgs e) {
            //ボールインスタンス生成
            
            
            soccerBall = new SoccerBall(e.X ,e.Y);
            pb = new PictureBox();
            pb.Image = soccerBall.Image;
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);　//画像の位置
            pb.Size = new Size(50, 50);//画像の表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage; //画像を表示モード
            pb.Parent = this;//画像の登録
            moveTimer.Start();//タイマースタート

        }

        private void MoveTimer_Tick(object sender, EventArgs e) {
            soccerBall.Move();　//移動
            pb.Location = new Point((int)soccerBall.PosX,(int)soccerBall.PosY);
        }
    }
}
