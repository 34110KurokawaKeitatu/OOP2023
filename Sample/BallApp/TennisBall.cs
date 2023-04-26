using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall : Obj {

        private static int count;

        public static int Count { get => count; set => count = value; }
        //コンストラクター
        public TennisBall(double xp, double yp)
            : base(xp, yp, @"pic\DVD.png") {

            Random r1 = new System.Random();
            MoveX = r1.Next(-30, 30);
            MoveY = r1.Next(-30, 30);
            Count++;

        }

        public override void Move() {
            if (PosY > 800 || PosY < -50)
            {
                MoveY = -MoveY;
            }
            if (PosX > 1600|| PosX < -50)
            {
                MoveX = -MoveX;
            }

            PosX += MoveX;
            PosY += MoveY;
        }
        public override void Move(Keys direction) {


        }
    }
}
