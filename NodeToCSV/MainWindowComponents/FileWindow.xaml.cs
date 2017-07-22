using NodeToCSV.MainWindowComponents.CustomControls;
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
		public List<TabItemWithCloseButton> tabs;

		public FileWindow()
		{
			InitializeComponent();

			graphs = new List<Graph>();
			tabs = new List<TabItemWithCloseButton>();
			AddTab();
			AddTab();
			UpdateTabsDataContext();
			Tabs.SelectedIndex = 0;
		}

		private void UpdateTabsDataContext()
		{
			Tabs.ItemsSource = null;
			Tabs.DataContext = null;
			Tabs.ItemsSource = tabs;
			Tabs.DataContext = tabs;

		}

		public Graph AddTab()
		{
			Graph g = new Graph();
			TabItemWithCloseButton t = new TabItemWithCloseButton();
			t.Content = g;
			t.OnCloseButtonPressed += OnGraphCloseButton_Click;
			graphs.Add(g);
			tabs.Add(t);
			UpdateTabsDataContext();
			return g;
		}

		public Graph GetOpenTab()
		{
			if(graphs.Any() == false)
			{
				return null;
			}
			return (Graph)(Tabs.SelectedItem as TabItemWithCloseButton).Content;
		}

		private void OnGraphCloseButton_Click(TabItemWithCloseButton sender)
		{
			graphs.Remove(sender.Content as Graph);
			tabs.Remove(sender);
			UpdateTabsDataContext();
			if ((Tabs.SelectedIndex >= tabs.Count || Tabs.SelectedIndex < 0)
				&& (tabs.Count > 0))
			{
				Tabs.SelectedIndex = (tabs.Count - 1);
			}
		}
	}
}
