using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateNestedTabViews_MAUI
{
	public class ContactInfo
	{
		public string Name { get; set; }
		public long Number { get; set; }
	}

	public class Person
	{
		public string Name { get; set; }
		public double Height { get; set; }
	}

	public class Product
	{
		public string Name { get; set; }
		public double SalesRate { get; set; }
	}
}
