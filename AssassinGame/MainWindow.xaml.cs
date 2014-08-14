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
using AssassinGame.Sceens;

namespace AssassinGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Grid grid1 = new Grid();
        //Button choice1 = new Button();
        //Button choice2 = new Button();
        //Button choice3 = new Button();

        AssassinControls.MissionControl missionControl = new AssassinControls.MissionControl();


        public MainWindow()
        {
            InitializeComponent();
            //MissionGuiSetup();
            MainStackPanel.Children.Add(missionControl);
           
        }       

        #region codeForIfUserControlfails
        public void MissionGuiSetup()
        {
            //MainStackPanel.Children.Clear();

            //grid1.Height = (double)800;
            //grid1.Width = (double)600;
           
            //System.Windows.Thickness MarginThickness = new Thickness();
            //MarginThickness.Equals(10);

            //choice1.Margin = MarginThickness;
            //choice2.Margin = MarginThickness;
            //choice3.Margin = MarginThickness;

            //choice1.Click += ButtonChoice;
            //choice2.Click += ButtonChoice;
            //choice3.Click += ButtonChoice;

            //choice1.Visibility = System.Windows.Visibility.Visible;
            //choice2.Visibility = System.Windows.Visibility.Visible;
            //choice3.Visibility = System.Windows.Visibility.Visible;

            //choice1.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            //choice2.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            //choice3.VerticalAlignment = System.Windows.VerticalAlignment.Center;

            //var col = new ColumnDefinition();
            //col.Width = new GridLength(1, GridUnitType.Star);
            //grid1.ColumnDefinitions.Add(col);
            //var col2 = new ColumnDefinition();
            //col2.Width = new GridLength(1, GridUnitType.Star);
            //grid1.ColumnDefinitions.Add(col2);
            //var col3 = new ColumnDefinition();
            //col3.Width = new GridLength(1, GridUnitType.Star);
            //grid1.ColumnDefinitions.Add(col3);

            //var row = new RowDefinition();
            //row.Height = new GridLength(5, GridUnitType.Star);
            //grid1.RowDefinitions.Add(row);
            //var row2 = new RowDefinition();
            //row2.Height = new GridLength(1, GridUnitType.Star);
            //grid1.RowDefinitions.Add(row2);
            //var row3 = new RowDefinition();
            //row3.Height = new GridLength(1, GridUnitType.Star);
            //grid1.RowDefinitions.Add(row3);
            //var row4 = new RowDefinition();
            //row4.Height = new GridLength(1, GridUnitType.Star);
            //grid1.RowDefinitions.Add(row4);

            //Label Setup = new Label();

            //Grid.SetRow(Setup, 0);
            //Grid.SetRow(choice1, 1);
            //Grid.SetRow(choice2, 2);
            //Grid.SetRow(choice3, 3);

            //MainStackPanel.Children.Add(grid1);
        }

        public void ButtonChoice(object sender, RoutedEventArgs e)
        {
            //not used - new method in usercontrol. may use later if we need to overwrite using missionguisetup method
        }
        #endregion
    }
}
