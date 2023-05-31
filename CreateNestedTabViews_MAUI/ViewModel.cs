using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateNestedTabViews_MAUI
{
	public class ViewModel
	{
		public ObservableCollection<ContactInfo> ContactList { get; set; }
		public List<Person> Persons { get; set; }
		public List<Product> Products { get; set; }

		public ViewModel()
		{
			ContactList = new ObservableCollection<ContactInfo>()
			{
				new ContactInfo { Name = "Aaron", Number = 7363750 },
				new ContactInfo { Name = "Adam", Number = 7323250 },
				new ContactInfo { Name = "Adrian", Number = 7239121 },
				new ContactInfo { Name = "Alwin", Number = 2329823 },
				new ContactInfo { Name = "Alex", Number = 8013481 },
				new ContactInfo { Name = "Alexander", Number = 7872329 },
				new ContactInfo { Name = "Barry", Number = 7317750 },
				new ContactInfo { Name = "Blexo", Number = 7363750 },
				new ContactInfo { Name = "Cassey", Number = 7323250 },
			};

			Persons = new List<Person>()
			{
			new Person { Name = "David", Height = 170 },
			new Person { Name = "Michael", Height = 96 },
			new Person { Name = "Steve", Height = 65 },
			new Person { Name = "Joel", Height = 182 },
			new Person { Name = "Bob", Height = 134 }
			};

			Products = new List<Product>()
			{
			new Product(){Name = "iPad", SalesRate = 25},
			new Product(){Name = "iPhone", SalesRate = 35},
			new Product(){Name = "MacBook", SalesRate = 15},
			new Product(){Name = "Mac", SalesRate = 5},
			new Product(){Name = "Others", SalesRate = 10},
			};

		}
	}
}
