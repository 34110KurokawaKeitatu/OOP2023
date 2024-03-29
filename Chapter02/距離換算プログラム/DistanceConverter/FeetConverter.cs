﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    //フィートとメートルの単位変換クラス
    public static class FeetConverter {

        /// </summary>定数
        private const double ratio = 0.3048;


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
