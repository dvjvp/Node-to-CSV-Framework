﻿using System;
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

namespace NodeToCSV.GraphElements.Nodes
{
	/// <summary>
	/// Interaction logic for SampleNode.xaml
	/// </summary>
	public partial class SampleNode : NodeBase
	{
		public SampleNode()
		{
			InitializeComponent();
		}

		public override void LoadFromDataRow(Files.DataStruct dataRow)
		{
			throw new NotImplementedException();
		}

		public override Files.DataStruct ToSaveFileDataRow()
		{
			throw new NotImplementedException();
		}

		public override Files.DataStruct ToExportFileDataRow()
		{
			throw new NotImplementedException();
		}

		public bool IsAmbientPropertyAvailable(string propertyName)
		{
			throw new NotImplementedException();
		}
	}
}
