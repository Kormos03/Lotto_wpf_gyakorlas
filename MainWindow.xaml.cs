using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Lotto_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Labels labelek;
        private int count;

        public MainWindow()
        {
            InitializeComponent();
            labelek = new Labels();
        }


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            switch(count) 
            {
                case 1:
                    await labelek.GenerateRandomNumberAsync(this.eredmeny);
                    label1.Text = labelek.ToString();
                    break;
                case 2:
                    await labelek.GenerateRandomNumberAsync(this.eredmeny);
                    label2.Text = labelek.ToString();
                    break;
                case 3:
                    await labelek.GenerateRandomNumberAsync(this.eredmeny);
                    label3.Text = labelek.ToString();
                    break;
                case 4:
                    await labelek.GenerateRandomNumberAsync(this.eredmeny);
                    label4.Text = labelek.ToString();
                    break;
                case 5:
                    await labelek.GenerateRandomNumberAsync(this.eredmeny);
                    label5.Text = labelek.ToString();
                    break;
                    case 6:
                    sorsol.Content = "Rendez";
                    break;
                    case 7:
                    sorbarendez();
                    break;
                case 8:
                    reset();
                    break;

            }
        }
        public void sorbarendez()
        {
            labelek.Exceptions.Sort();
            label1.Text = labelek.Exceptions[0].ToString();
            label2.Text = labelek.Exceptions[1].ToString();
            label3.Text = labelek.Exceptions[2].ToString();
            label4.Text = labelek.Exceptions[3].ToString();
            label5.Text = labelek.Exceptions[4].ToString();
            sorsol.Content = "Sorsol";
        }

        public void reset()
        {
            count = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }
    }
}
