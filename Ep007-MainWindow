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

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		/// This Method is called a Event Handler. It is the action that  happens when the Button Click Event Happens
		/// </summary>
		/// <param name="sender">The object that sent the button click.</param>
		/// <param name="e">Arguments that come from the routed event</param>
		private void CalcButton_Click(object sender, RoutedEventArgs e)
		{
			decimal minutesLeft = decimal.Parse(txt_MinutesLeft.Text); //Gets mins as a decimal from the user. (Doesn't check if they dont enter a number)
			decimal distanceInMiles = decimal.Parse(txt_Distance.Text); //Gets miles as a decimal from the user. (Doesn't check if they dont enter a number)

			int speedInMPH = SpeedProvider.RequiredSpeedInMPH(distanceInMiles, minutesLeft);
			int speedinKPH = SpeedProvider.ConvertMPHtoKPH(speedInMPH);

			TxtBx_SpeedMph.Text = speedInMPH.ToString();
			TxtBx_SpeedKph.Text = speedinKPH.ToString();
		}
	}
}
