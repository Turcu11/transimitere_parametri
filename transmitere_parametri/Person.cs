using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transmitere_parametri
{
    class Person
    {
		public Person(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}
		public string FirstName
		{
			get;
			set;
		}

		public string LastName
		{
			get;
			set;
		}

	}
}
