using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAxisCustomization_MAUI_CartesianChart
{
	public class ViewModel
	{
		public List<Model> Data { get; set; }

		public ViewModel()
		{
			Data = new List<Model>()
			{
				new Model(){Date = new DateTime(2021,7,12), SalesAmount = 1.5},
				new Model(){Date = new DateTime(2021,8,5), SalesAmount = 2.8},
				new Model(){Date = new DateTime(2021,9,21), SalesAmount = 2.3},
				new Model(){Date = new DateTime(2021,10,12), SalesAmount = 3.2},
				new Model(){Date = new DateTime(2021,11,6), SalesAmount = 2.5},
				new Model(){Date = new DateTime(2021,12,23), SalesAmount = 3.6},
				new Model(){Date = new DateTime(2022,1,10), SalesAmount = 3.1},
				new Model(){Date = new DateTime(2022,2,12), SalesAmount = 2.6},
				new Model(){Date = new DateTime(2022,3,4), SalesAmount = 1.8},
				new Model(){Date = new DateTime(2022,4,7), SalesAmount = 1.7},
				new Model(){Date = new DateTime(2022,5,13), SalesAmount = 2.3},
				new Model(){Date = new DateTime(2022,6,21), SalesAmount = 2.1},
			};
		}
	}
}
