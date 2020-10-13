using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfToolkitChart.Metrologia;

namespace WpfToolkitChart
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          InitializeComponent();
          showColumnChart();
        }

        private void showColumnChart()
        { 
            
            ILaba<double> Laba1 = new Laba1<double>();

            int i = 2;
            switch (i)
            {
                case 1:
                {
                    //Башенками
                    columnChart.Visibility = Visibility.Visible;
                    columnChart.DataContext = Laba1.getAnsver();
                        break;
                }
                case 2:
                {
                    //Кружочком
                    pieChart.Visibility = Visibility.Visible;
                    pieChart.DataContext = Laba1.getAnsver();
                        break;
                }
                case 3:
                {
                    //Типа закрашенный график
                    areaChart.Visibility = Visibility.Visible;
                    areaChart.DataContext = Laba1.getAnsver();
                        break;
                }
                case 4:
                {
                    //Наклонённые башенки
                    barChart.Visibility = Visibility.Visible;
                    barChart.DataContext = Laba1.getAnsver();
                        break;
                }
                case 5:
                {
                    //Типа не закрашенный график
                    lineChart.Visibility = Visibility.Visible;
                    lineChart.DataContext = Laba1.getAnsver();
                        break;
                }
            }
        }
    }
}
