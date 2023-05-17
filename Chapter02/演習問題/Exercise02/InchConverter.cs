using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    //フィートとメートルの単位変換クラス
    public static class InchConverter {

        /// </summary>定数
        private const double ratio = 0.0254;


        //フィートからメートルを求める
        public static double FromMeter(int feet) {
            return feet * ratio;
        }
        //メートルからフィートを求める
        public static　double ToMeter(int meter) {
            return meter / ratio;
        }
    }
}
