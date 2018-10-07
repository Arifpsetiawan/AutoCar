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

namespace NextCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car nextCar;
        public MainWindow()
        {
            InitializeComponent();

            AccubaterryController accubaterryController = new AccubaterryController();
            DoorController doorController = new DoorController();

            nextCar = new Car();
            nextCar.setAccubaterryController(accubaterryController);
            nextCar.setDoorController(doorController);
        }

        private void OnStartButtonClicked(object sender, RoutedEventArgs e)
        {
            Boolean mesinHidup = nextCar.powerIsReady();
            Boolean pintuTertutup = nextCar.doorIsLocked();
            Boolean mesinMati = nextCar.powerIsOff();
            Boolean pintuTerbuka = nextCar.doorIsUnLocked();
           
            if(mesinHidup && pintuTertutup && this.StartButton.Content == "START")
            {
                this.StartButton.Content = "STOP";

                this.nextCar.turnOnPower();
                this.AccuState.Content = "Power is Ready";
                this.AccuButton.Content = "ON";

                this.nextCar.turnOnDoorPower();
                this.DoorState.Content = "Door is Locked";
                this.DoorButton.Content = "ON";
            }
            else if (mesinHidup && pintuTertutup && this.StartButton.Content == "STOP")
            {
                this.StartButton.Content = "START";

                this.nextCar.turnOfPower();
                this.AccuState.Content = "No Power";
                this.AccuButton.Content = "OFF";

                this.nextCar.turnOfDoorPower();
                this.DoorState.Content = "Door is Unlocked";
                this.DoorButton.Content = "OFF";
            }
            else
            {
                this.StartButton.Content = "START";
            }

        }

        private void OnAccuButtonClicked(object sender, RoutedEventArgs e)
        {
            Boolean powerIsOn = nextCar.powerIsReady();
            Boolean powerIsOff = nextCar.powerIsOff();

            if (powerIsOn)
            {
                this.nextCar.turnOfPower();
                this.AccuState.Content = "No Power";
                this.AccuButton.Content = "OFF";
            }
            else
            {
                this.nextCar.turnOnPower();
                this.AccuState.Content = "Power is Ready";
                this.AccuButton.Content = "ON";
            }
            if (powerIsOff && StartButton.Content =="STOP")
            {
                this.nextCar.turnOfPower();
                this.AccuState.Content = "No Power";
                this.AccuButton.Content = "OFF";
                this.StartButton.Content = "START";
                this.nextCar.turnOfDoorPower();
                this.DoorState.Content = "Door is Unlocked";
                this.DoorButton.Content = "OFF";
            }
      

        }

        private void OnDoorButtonClicked(object sender, RoutedEventArgs e)
        {
            Boolean pintuTertutup = nextCar.doorIsLocked();
            Boolean pintuTerbuka = nextCar.doorIsUnLocked();

            if (pintuTertutup)
            {
                this.nextCar.turnOfDoorPower();
                this.DoorState.Content = "Door is Unlocked";
                this.DoorButton.Content = "OFF";
            }
            else
            {
                this.nextCar.turnOnDoorPower();
                this.DoorState.Content = "Door is Locked";
                this.DoorButton.Content = "ON";
            }
            if (pintuTerbuka && StartButton.Content == "STOP")
            {
                this.nextCar.turnOfPower();
                this.AccuState.Content = "No Power";
                this.AccuButton.Content = "OFF";
                this.StartButton.Content = "START";
                this.nextCar.turnOfDoorPower();
                this.DoorState.Content = "Door is Unlocked";
                this.DoorButton.Content = "OFF";
            }


        }
    }
}
