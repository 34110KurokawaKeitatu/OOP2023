using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image; //画像データ

        private double posX; //x座標
        private double posY; //y座標

        private double moveX;//x座標
        private double moveY;//y座標


        //コンストラクター
        public SoccerBall(double xp , double yp) {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            posX = xp;
            posY = yp;
           Random r1= new System.Random();
            moveX = r1.Next(-30, 30);
            moveY = r1.Next(-30, 30);

        }
        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //メソッド
        public void Move() {
            if (posY > 520 || posY < 0)
            {
                moveY = -moveY;
            }
            if (posX > 730 || posX < 0)
            {
                moveX = -moveX;
            }

            posX += moveX;
            posY += moveY;




        }
    }
}
