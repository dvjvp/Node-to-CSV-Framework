using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeToCSV.Files
{
	public class DataStruct
	{
		public string uniqueID;


		override public string ToString()
		{
			return "DataStruct: [" + uniqueID + "]";
		}

		public string Save()
		{
			return uniqueID;
		}

		public string Export()
		{
			return uniqueID;
		}
	}
}
