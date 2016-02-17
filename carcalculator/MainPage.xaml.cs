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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace carcalculator
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

        private void trucksbutton_Click(object sender, RoutedEventArgs e)
        {
            // haetaan käyttöliittymästa truckstextblockin sisältämä teksti
            string trucksString = TruckstextBlock.Text;
            int trucks = int.Parse(trucksString);
            // kuorma auto lisääntyy yhdellä
            trucks++;
            // näytetään uusi lukumäärä näytöllä
            TruckstextBlock.Text = trucks.ToString(); //1-> "1"

            
        }

        private void Carsbutton_Click(object sender, RoutedEventArgs e)
        {
            string carsString = CarstextBlock.Text;
            int cars = int.Parse(carsString);
            cars++;
            CarstextBlock.Text = cars.ToString();
        }
    }
}
