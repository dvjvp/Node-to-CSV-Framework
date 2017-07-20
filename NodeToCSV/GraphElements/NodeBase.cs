using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NodeToCSV.GraphElements
{
	public abstract class NodeBase : GraphElementBase
	{
		public abstract void LoadFromDataRow(Files.DataStruct dataRow);
		public abstract Files.DataStruct ToSaveFileDataRow();
		public abstract Files.DataStruct ToExportFileDataRow();

		public void BeginDragnDrop(MouseButtonEventArgs e)
		{

		}
		public void UpdateDragnDrop(MouseEventArgs e)
		{

		}
		public void EndDragnDrop(MouseButtonEventArgs e)
		{

		}
	}
}
