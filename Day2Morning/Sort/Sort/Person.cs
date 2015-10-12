using System;
using System.Collections;

namespace Sort
{
	public class Person
	{
		public string name{ set;get;}
		public int age{ set; get;}

		public Person ( string name, int age)
		{
			this.name = name;
			this.age = age;
		}
		public static IComparer SortByName
		{
			get
			{
				return((IComparer) new SortByNameClass());
			}
		}
			

		class SortByNameClass: IComparer
		{
			public int Compare(object obj1, object obj2)
			{
				Person p1 = (Person) obj1;
				Person p2 = (Person) obj2;

				return(String.Compare(p1.name, p2.name));
			}
		}

	}
}

