using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Student {
		public String Name { get; set; }
		public Class Class { get; set; }
		public String ContactInfo { get; set; }
		public DateTime? FirstJob { get; set; }
		public int Absences { get; set; }
		public List<Assignment> Assignment = new List<Assignment>();

	}
}
