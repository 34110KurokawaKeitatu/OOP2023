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
        private List<SoccerBall> balls = new List<SoccerBall>();//ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();//表示用
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
            Random r1 = new System.Random();
            Random r2= new System.Random();
            pb.Size = new Size(r1.Next(20, 50), r1.Next(20, 100));
            pb.SizeMode = PictureBoxSizeMode.StretchImage; //画像を表示モード
            pb.Parent = this;//画像の登録
            
            balls.Add(soccerBall);
            pbs.Add(pb);

            moveTimer.Start();//タイマースタート

        }

        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++) {
            
                balls[i].Move(); //移動
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }
        }
    }
}
