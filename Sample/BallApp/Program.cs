using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {

        Bar bar;    //  barインスタンス格納
        PictureBox pbBar; //Bar表示用

        private Timer moveTimer;
        private SoccerBall soccerBall;
        private TennisBall tennisBall;
        private PictureBox pb; //画像をコントロールする

        //リストこれくしょうん
        private List<Obj> balls = new List<Obj>();//ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();//表示用


        private int i = 0;
        static void Main(string[] args) {
           

            Application.Run(new Program());

        }

        public Program() {

            // this.Height = 1080;//高さプロパティ] this.Width = 1920;//幅プロパティ
            this.Size = new Size(1920, 1080);

            this.BackColor = Color.Black;
            this.Text = "BallGame";

            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;

            // Bar インスタンス生成
            bar = new Bar(1000,1000);
            pbBar = new PictureBox();
            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBar.Parent = this;
            
            moveTimer = new Timer();
            moveTimer.Interval = 1;//タイマーのインターバル（ｍｓ
            moveTimer.Tick += MoveTimer_Tick;//デリゲート登録

        }

        private void Program_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyData);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
        }

        private void Program_MouseClick(object sender, MouseEventArgs e) {
            //ボールインスタンス生成

            
            if (e.Button == MouseButtons.Right)
            {
                
                tennisBall = new TennisBall(e.X, e.Y);
                pb = new PictureBox();
                pb.Image = tennisBall.Image;
                pb.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY); //画像の位置
                balls.Add(tennisBall);
                
            }
            if (e.Button == MouseButtons.Left)
            {
                soccerBall = new SoccerBall(e.X, e.Y);
                pb = new PictureBox();
                pb.Image = soccerBall.Image;
                pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY); //画像の位置
                balls.Add(soccerBall);

            }
            Random r1 = new System.Random();
            int a = r1.Next(20, 50);
            pb.Size = new Size(300, 300);
            pb.SizeMode = PictureBoxSizeMode.StretchImage; //画像を表示モード
            pb.Parent = this;//画像の登録
            pbs.Add(pb);
            i = i + 1;

            this.Text = "BallGame soccerball:" + SoccerBall.Count + " " + "tennisball:" + TennisBall.Count;
            moveTimer.Start();//タイマースタート

        }

        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++) {
            
                balls[i].Move(pbBar,pbs[i]); //移動
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }

            }
        }
    }

