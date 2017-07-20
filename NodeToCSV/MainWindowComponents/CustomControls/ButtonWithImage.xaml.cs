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
	/// Interaction logic for ButtonWithImage.xaml
	/// </summary>
	public partial class ButtonWithImage : Button
	{
		public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
			"Title",
			typeof(string),
			typeof(ButtonWithImage),
			new FrameworkPropertyMetadata(null,
			  FrameworkPropertyMetadataOptions.AffectsRender,
			  new PropertyChangedCallback(OnTitleChanged))
			);

		public string Title
		{
			get { return GetValue(TitleProperty).ToString(); }
			set { SetValue(TitleProperty, value); }
		}


		public ButtonWithImage()
		{
			InitializeComponent();
		}

		static void OnTitleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{

		}
	}
}
