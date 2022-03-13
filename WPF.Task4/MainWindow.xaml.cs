using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.Task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateS.Text);
            double sumDollar = Convert.ToDouble(sumS.Text);
            resS.Text = (rateDollar * sumDollar).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            resE.Text = (rateEuro * sumEuro).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateFrank = Convert.ToDouble(rateF.Text);
            double sumFrank = Convert.ToDouble(sumF.Text);
            resF.Text = (rateFrank * sumFrank).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double ratePounds = Convert.ToDouble(rateP.Text);
            double sumPounds = Convert.ToDouble(sumP.Text);
            resP.Text = (ratePounds * sumPounds).ToString();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateFeet = Convert.ToDouble(lengthFt.Text);
            resFt.Text = (rateFeet * 0.3048).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateMi = Convert.ToDouble(lengthM.Text);
            resM.Text = (rateMi * 1609.34).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateD = Convert.ToDouble(lengthD.Text);
            resD.Text = (rateD * 0.0254).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateV = Convert.ToDouble(lengthV.Text);
            resV.Text = (rateV * 0.000937383).ToString();
        }
    }
}
