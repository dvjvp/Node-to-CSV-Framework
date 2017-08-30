using NodeToCSV.Files;
using NodeToCSV.GraphElements;
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
	public partial class Graph : UserControl
	{


		public Graph()
		{
			InitializeComponent();
			
		}


		public NodeBase CreateNode(DataStruct data)
		{
			NodeBase node;


			throw new NotImplementedException();


			node.LoadFromDataRow(data);
			ForegroundCanvas.Children.Add(node);
			return node;
		}

		#region Transform utility

		public Point ViewCenter
		{
			get
			{
				return TotalTransform.Inverse.Transform(
					new Point(ViewportBorders.ActualWidth / 2, ViewportBorders.ActualHeight / 2));
			}
		}

		#endregion

		#region Panning graph

		private bool panCanvasInProgress = false;
		private Point panCanvasStartingMousePosition;
		private Point panCavasStartingTranslation;

		public void PanCanvas(Vector panOffset)
		{
			double X = Math.Min(GraphTranslation.X + panOffset.X, 0);
			double Y = Math.Min(GraphTranslation.Y + panOffset.Y, 0);

			//for math and utility functions to work properly
			GraphTranslation.X = X;
			GraphTranslation.Y = Y;

			//actual view offset
			var margin = CanvasContainer.Margin;
			margin.Left = X;
			margin.Top = Y;
			CanvasContainer.Margin = margin;
		}
		public void SetCanvasPosition(Point leftUpCorner)
		{
			double X = Math.Min(leftUpCorner.X, 0);
			double Y = Math.Min(leftUpCorner.Y, 0);

			//for math and utility functions to work properly
			GraphTranslation.X = X;
			GraphTranslation.Y = Y;

			//actual view offset
			var margin = CanvasContainer.Margin;
			margin.Left = X;
			margin.Top = Y;
			CanvasContainer.Margin = margin;
		}

		private void StartPanCanvas(object sender, MouseButtonEventArgs e)
		{
			//pan only with right mouse button
			if (e.RightButton != MouseButtonState.Pressed)
			{
				return;
			}

			BackgroundCanvas.CaptureMouse();

			panCanvasInProgress = true;
			panCanvasStartingMousePosition = e.GetPosition(this);
			panCavasStartingTranslation = new Point(GraphTranslation.X, GraphTranslation.Y);

			CanvasContainer.MouseMove += PanCanvas_MouseMoved;
			CanvasContainer.Cursor = Cursors.ScrollAll;
		}

		private void PanCanvas_MouseMoved(object sender, MouseEventArgs e)
		{
			Vector totalCursorMovement = e.GetPosition(this) - panCanvasStartingMousePosition;
			SetCanvasPosition(panCavasStartingTranslation + totalCursorMovement);
		}

		private void EndPanCanvas(object sender, MouseButtonEventArgs e)
		{
			if(panCanvasInProgress)
			{
				BackgroundCanvas.ReleaseMouseCapture();

				panCanvasInProgress = false;

				CanvasContainer.MouseMove -= PanCanvas_MouseMoved;
				CanvasContainer.Cursor = Cursors.Arrow;
			}
		}

		#endregion

		#region Zooming graph

		const double ZOOM_SPEED = 0.05;
		const double ZOOM_MIN = 0.15;
		const double ZOOM_MAX = 3.0;

		private void ZoomCanvasToMouseOrFromCenter(object sender, MouseWheelEventArgs e)
		{
			bool zoomingIn = e.Delta > 0;
			Point oldCenter = zoomingIn ? e.GetPosition(CanvasContainer) : ViewCenter;
			double newZoom = GraphScale.ScaleX;

			if (zoomingIn)
			{
				newZoom += ZOOM_SPEED;
			}
			else
			{
				newZoom -= ZOOM_SPEED;
			}

			SetZoom(newZoom);

			Vector offset = oldCenter - (zoomingIn ? e.GetPosition(CanvasContainer) : ViewCenter);
			PanCanvas(offset);
		}

		public void SetZoom(double newValue)
		{
			newValue = Math.Max(newValue, ZOOM_MIN);
			newValue = Math.Min(newValue, ZOOM_MAX);

			GraphScale.ScaleX = newValue;
			GraphScale.ScaleY = newValue;

			Console.WriteLine("Zoom: " + newValue);
		}

		#endregion
	}
}
