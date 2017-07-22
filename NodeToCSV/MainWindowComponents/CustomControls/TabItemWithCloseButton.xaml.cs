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

namespace NodeToCSV.MainWindowComponents.CustomControls
{
	/// <summary>
	/// Interaction logic for TabItemWithCloseButton.xaml
	/// </summary>
	public partial class TabItemWithCloseButton : TabItem
	{
		public delegate void CloseTabEvent(TabItemWithCloseButton sender);
		public event CloseTabEvent OnCloseButtonPressed;

		public TabItemWithCloseButton()
		{
			InitializeComponent();
		}


		private void ClosingButton_Click(object sender, RoutedEventArgs e)
		{
			OnCloseButtonPressed?.Invoke(this);
		}
	}
}
