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
	/// Interaction logic for FileWindow.xaml
	/// </summary>
	public partial class FileWindow : UserControl
	{
		public List<Graph> graphs;

		public FileWindow()
		{
			InitializeComponent();

			graphs = new List<Graph>();
			AddTab();
			UpdateTabsDataContext();
			Tabs.SelectedIndex = 0;
		}

		private void UpdateTabsDataContext()
		{
			Tabs.DataContext = null;
			Tabs.DataContext = graphs;
		}

		public Graph AddTab()
		{
			Graph g = new Graph();
			g.OnCloseButtonPressed += OnGraphCloseButton_Click;
			graphs.Add(g);
			UpdateTabsDataContext();
			return g;
		}

		private void OnGraphCloseButton_Click(Graph sender)
		{
			graphs.Remove(sender);
			UpdateTabsDataContext();
		}
	}
}
