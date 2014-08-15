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


namespace AssassinGame.AssassinControls
{
    /// <summary>
    /// Interaction logic for MissionControl.xaml
    /// </summary>
    public partial class MissionControl : UserControl
    {
        public int testing { get; set; }
        public int UserChoice { get; set; }
        Uri imgsrc;
        BitmapImage bmp;

        public MissionControl()
        {
            InitializeComponent();
        }

        private void ButtonChoice1(object sender, RoutedEventArgs e)
        {
            UserChoice = 1;
            imgsrc = new Uri("pack://application:,,,/Images/FirstMission/AngryJames.jpg");
            bmp = new BitmapImage(imgsrc);
            TheBackground.Source = bmp;
        }
        private void ButtonChoice2(object sender, RoutedEventArgs e)
        {
            UserChoice = 2;
        }
        private void ButtonChoice3(object sender, RoutedEventArgs e)
        {
            UserChoice = 3;
        }

        public void MissionDialog(string setup, string but1, string but2, string but3)
        {
            Label_SetUp.Content = setup;
            Button_Choice1.Content = but1;
            Button_Choice2.Content = but2;
            Button_Choice3.Content = but3;
            
        }

        private void Button_Choice3_MouseEnter_1(object sender, MouseEventArgs e)
        {
            if (this.Button_Choice3.Foreground.Equals(Brushes.Black))
            {
                this.Button_Choice3.Foreground = (Brushes.White);
            }
            else
            {
                this.Button_Choice3.Foreground = (Brushes.Black);
            }
        }
        private void Button_Choice2_MouseEnter_1(object sender, MouseEventArgs e)
        {
            if (this.Button_Choice2.Foreground.Equals(Brushes.Black))
            {
                this.Button_Choice2.Foreground = (Brushes.White);
            }
            else
            {
                this.Button_Choice2.Foreground = (Brushes.Black);
            }
        }
        private void Button_Choice1_MouseEnter_1(object sender, MouseEventArgs e)
        {
            if (this.Button_Choice1.Foreground.Equals(Brushes.Black))
            {
                this.Button_Choice1.Foreground = (Brushes.White);
            }
            else
            {
                this.Button_Choice1.Foreground = (Brushes.Black);
            }
        }


    }
}
