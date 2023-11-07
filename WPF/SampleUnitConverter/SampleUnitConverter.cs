using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double metricValue, imeprialValue;


        public double MetricValue
        {
            get { return this.MetricValue; }
            set
            {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }
        public double ImperialValue
        {
            get { return this.ImperialValue; }
            set
            {
                this.ImperialValue = value;
                this.OnPropertyChanged();
            }
        }
        //上のコンボボックスで選択されている値（単位）
        public MetricUnit CurrentMetricUnit { get; set; }

        public ImperialUnit CurrentImperiarUnit { get; set; }

        //△ボタンで呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }

        //▽ボタンで呼ばれるコマンド
        public ICommand MetricToImperialUnit { get; private set; }

        //コンストラクタ
        public MainWindowViewModel() {
            this.CurrentMetricUnit = MetricUnit.Units.First();
            this.CurrentImperiarUnit = ImperialUnit.Units.First();

            this.MetricToImperialUnit = new DelegateCommand(
                () => this.imeprialValue = this.CurrentImperiarUnit.FromImperialUnit(this.CurrentMetricUnit, this.metricValue));
            this.ImperialUnitToMetric = new DelegateCommand(
                () => this.MetricValue = this.CurrentMetricUnit.FromMetricUnit(this.CurrentImperiarUnit, this.imeprialValue));
        }
    }
}
