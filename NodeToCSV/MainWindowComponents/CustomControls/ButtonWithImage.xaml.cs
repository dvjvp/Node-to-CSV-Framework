using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NodeToCSV.MainWindowComponents.CustomControls
{
	/// <summary>
	/// Taken from:
	/// https://blogs.msdn.microsoft.com/knom/2007/10/31/wpf-control-development-3-ways-to-build-an-imagebutton/
	/// </summary>
	public partial class ButtonWithImage : UserControl
	{
		const double DEFAULT_IMAGE_WIDTH = 40;
		const double DEFAULT_IMAGE_HEIGHT = 40;

		public ImageSource Image
		{
			get { return (ImageSource)GetValue(ImageProperty); }
			set { SetValue(ImageProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Image.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ImageProperty =
			DependencyProperty.Register("Image", typeof(ImageSource), typeof(ButtonWithImage),
				new UIPropertyMetadata(null));

		public double ImageWidth
		{
			get { return (double)GetValue(ImageWidthProperty); }
			set { SetValue(ImageWidthProperty, value); }
		}

		// Using a DependencyProperty as the backing store for ImageWidth.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ImageWidthProperty =
			DependencyProperty.Register("ImageWidth", typeof(double), typeof(ButtonWithImage),
				new UIPropertyMetadata(DEFAULT_IMAGE_WIDTH));

		public double ImageHeight
		{
			get { return (double)GetValue(ImageHeightProperty); }
			set { SetValue(ImageHeightProperty, value); }
		}

		// Using a DependencyProperty as the backing store for ImageHeight.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ImageHeightProperty =
			DependencyProperty.Register("ImageHeight", typeof(double), typeof(ButtonWithImage),
				new UIPropertyMetadata(DEFAULT_IMAGE_HEIGHT));

		public string Text
		{
			get { return (string)GetValue(TextProperty); }
			set { SetValue(TextProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty TextProperty =
			DependencyProperty.Register("Text", typeof(string), typeof(ButtonWithImage),
				new UIPropertyMetadata(""));


		public ButtonWithImage()
		{
			InitializeComponent();
		}
	}
}
