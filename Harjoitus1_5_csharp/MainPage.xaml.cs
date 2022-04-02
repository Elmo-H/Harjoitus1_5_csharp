using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Harjoitus1_5_csharp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String comboText = ((ComboBoxItem)menu.SelectedItem).Content.ToString();

            switch(comboText)
            {
                case "Kulta":
                    changingText.Text = comboText;
                    SolidColorBrush mySolidColorBrush = new SolidColorBrush(Windows.UI.Colors.Gold);
                    box.Background = mySolidColorBrush;
                    break;

                case "Punainen":
                    changingText.Text = "Punainen";
                    SolidColorBrush mySolidColorBrush2 = new SolidColorBrush(Windows.UI.Colors.Tomato);
                    box.Background = mySolidColorBrush2;
                    break;

                case "Valkoinen":
                    changingText.Text = "Valkoinen";
                    SolidColorBrush mySolidColorBrush3 = new SolidColorBrush(Windows.UI.Colors.SeaShell);
                    box.Background = mySolidColorBrush3;
                    break;

                case "Vihreä":
                    changingText.Text = "Vihreä";
                    SolidColorBrush mySolidColorBrush4 = new SolidColorBrush(Windows.UI.Colors.DarkGreen);
                    box.Background = mySolidColorBrush4;
                    break;

                case "Pinkki":
                    changingText.Text = "Pinkki";
                    SolidColorBrush mySolidColorBrush5 = new SolidColorBrush(Windows.UI.Colors.LightPink);
                    box.Background = mySolidColorBrush5;
                    break;
            }
            
        }
    }
}
