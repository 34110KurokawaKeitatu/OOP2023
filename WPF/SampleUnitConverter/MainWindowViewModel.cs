using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double metricValue, imperialValue;
        private double gramUnit, lbUnit;


        public double GramValue
        {
            get { return this.gramUnit; }
            set
            {
                this.gramUnit = value;
                this.OnPropertyChanged();
            }
        }
        public double LbValue
        {
            get { return this.lbUnit; }
            set
            {
                this.lbUnit = value;
                this.OnPropertyChanged();
            }
        }

        public double MetricValue {
            get { return this.metricValue; }
            set {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }

        public double ImperialValue {
            get { return this.imperialValue; }
            set {
                this.imperialValue = value;
                this.OnPropertyChanged();
            }
        }

        //上のComboBoxで選択されている値（単位）
        public MetricUnit CurrentMetricUnit { get; set; }
        //下のComboBoxで選択されている値（単位）
        public ImperialUnit CurrentImperialUnit { get; set; }

        public GramUnit CurrentGramUnit { get; set; }
        
        public LbUnit CurrentLbUnit { get; set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }
        //▼ボタンで呼ばれるコマンド
        public ICommand MetricToImperialUnit { get; private set; }

        public ICommand GramUnitToLb { get; private set; }

        public ICommand LbToGramUnit { get; private set; }

        //コンストラクタ
        public MainWindowViewModel() {
            this.CurrentMetricUnit = MetricUnit.Units.First();
            this.CurrentImperialUnit = ImperialUnit.Units.First();
            this.CurrentGramUnit = GramUnit.Units.First();
            this.CurrentLbUnit = LbUnit.Units.First(); 

            this.MetricToImperialUnit = new DelegateCommand(
                () => this.ImperialValue = this.CurrentImperialUnit.FromMetricUnit(
                    this.CurrentMetricUnit, this.MetricValue));

            this.ImperialUnitToMetric = new DelegateCommand(
                () => this.MetricValue = this.CurrentMetricUnit.FromImperialUnit(
                    this.CurrentImperialUnit, this.ImperialValue));

            this.GramUnitToLb = new DelegateCommand(
                () => this.LbValue = this.CurrentLbUnit.FromImperialUnit(
                    this.CurrentGramUnit, this.GramValue));

            this.LbToGramUnit = new DelegateCommand(
                () => this.GramValue = this.CurrentGramUnit.FromImperialUnit(
                    this.CurrentLbUnit, this.LbValue));
        }
    }
}
