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

namespace NodeToCSV.MainWindowComponents
{
	/// <summary>
	/// Interaction logic for Graph.xaml
	/// </summary>
	public partial class Graph : TabItem
	{
		public delegate void CloseTabEvent(Graph sender);
		public event CloseTabEvent OnCloseButtonPressed;

		public Graph()
		{
			InitializeComponent();
		}

		private void ClosingButton_Click(object sender, RoutedEventArgs e)
		{
			OnCloseButtonPressed?.Invoke(this);
		}
	}
}
