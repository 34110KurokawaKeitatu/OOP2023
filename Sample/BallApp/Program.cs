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
        private TennisBall tennisBall;
        private PictureBox pb; //画像をコントロールする
        private List<SoccerBall> balls = new List<SoccerBall>();//ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();//表示用
        private List<TennisBall> balls2 = new List<TennisBall>();//ボールインスタンス格納用
        private List<PictureBox> pbs2 = new List<PictureBox>();//表示用

        private int i = 0;
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

            this.Text = "BallGame" + (i + 1);
            if (e.Button == MouseButtons.Right)
            {
                
                tennisBall = new TennisBall(e.X, e.Y);
                pb = new PictureBox();
                pb.Image = tennisBall.Image;
                pb.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY); //画像の位置
                balls2.Add(tennisBall);
                pbs2.Add(pb);
            }
            if (e.Button == MouseButtons.Left)
            {
                soccerBall = new SoccerBall(e.X, e.Y);
                pb = new PictureBox();
                pb.Image = soccerBall.Image;
                pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY); //画像の位置
                balls.Add(soccerBall);
                pbs.Add(pb);

            }
            Random r1 = new System.Random();
            int a = r1.Next(20, 50);
            pb.Size = new Size(a, a);
            pb.SizeMode = PictureBoxSizeMode.StretchImage; //画像を表示モード
            pb.Parent = this;//画像の登録
            i = i + 1;
            moveTimer.Start();//タイマースタート

        }

        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++) {
            
                balls[i].Move(); //移動
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }
            for(int i = 0; i < balls2.Count; i++)
            {
                balls2[i].Move(); //移動
                pbs2[i].Location = new Point((int)balls2[i].PosX, (int)balls2[i].PosY);

            }
        }
    }
}
