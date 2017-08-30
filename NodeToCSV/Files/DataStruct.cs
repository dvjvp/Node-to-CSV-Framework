using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeToCSV.Files
{
	public enum NodeType
	{
	}

	public static class NodeTypeHelpers
	{
		public static string ToReadableString(this NodeType n)
		{
			throw new NotImplementedException();
		}
		public static string ToDataString(this NodeType n)
		{
			throw new NotImplementedException();
		}
		public static NodeType CreateFromDataString(string data)
		{
			throw new NotImplementedException();
		}
	}

	public class DataStruct
	{
		public string uniqueID;
		public NodeType nodeType;


		override public string ToString()
		{
			string[] temp = new string[]
			   {
				uniqueID,
				nodeType.ToReadableString()
			   };

			return "DataStruct: [" + string.Join(", ", temp) + "]";
		}

		public string Save()
		{
			string[] temp = new string[]
			{
				uniqueID,
				nodeType.ToDataString()
			};

			return string.Join(",", temp);
		}

		public string Export()
		{
			string[] temp = new string[]
			   {
				uniqueID,
				nodeType.ToDataString()
			   };

			return string.Join(",", temp);
		}

		public static DataStruct LoadFrom(string source)
		{
			DataStruct data = new DataStruct();

			throw new NotImplementedException();


			return data;
		}
	}
}
