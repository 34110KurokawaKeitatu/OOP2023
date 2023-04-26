﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall:Obj {

        private static int count;

        public static int Count { get => count; set => count = value; }

        //コンストラクター
        public SoccerBall(double xp , double yp)
            : base(xp,yp, @"pic\soccer_ball.png") {

           Random r1= new System.Random();
            MoveX = r1.Next(-30, 30);
            MoveY = r1.Next(-30, 30);
            Count++;
        }
 
        //メソッド
        public override void Move() {
            if (PosY > 990 || PosY < 0)
            {
                MoveY = -MoveY;
            }
            if (PosX > 1700 || PosX < 0)
            {
                MoveX = -MoveX;
            }

            PosX += MoveX;
            PosY += MoveY;




        }
    }
}
