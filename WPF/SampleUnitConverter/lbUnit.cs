using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class LbUnit : DistanceUnit {
        private static List<LbUnit> units = new List<LbUnit> {
            new LbUnit{Name = "ポンド",Coefficient = 1},
            new LbUnit{Name = "オンス",Coefficient = 1 / 28},

        };
        public static ICollection<LbUnit> Units { get { return units; } }

        /// <summary>
        /// ヤード単位からメートル単位に変換します
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <returns>変換値</returns>
        public double FromImperialUnit(GramUnit unit, double value) {
            return (value * unit.Coefficient) * 25.4 / this.Coefficient;
        }
    }
}
