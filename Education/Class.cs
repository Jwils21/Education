using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Class {
		public string Name { get; set; }
		private string _Language; 
		/// <summary>
		/// Language accepts only CSharp or Java
		/// </summary>
		public string Language{
			get {
				return _Language;
			}
			set {
				if (value == "CSharp" || value == "Java") {
					_Language = value;
				} else {
					throw new ApplicationException("Language must be C# or Java");
					
				}
			}
		}//C# or Java
		public string Code { get; set; }
		public int Capacity { get; set; }
		public Instructor Instructor { get; set; }
		public List<Student> Students = new List<Student>();

		public void DistributeAssignment(Assignment assignment) {
			foreach (Student student in Students) {
				Assignment asgn = new Assignment();
				asgn.AssignmentId = assignment.AssignmentId;
				asgn.Comments = assignment.Comments;
				asgn.Grade = assignment.Grade;
				asgn.Name = assignment.Name;
				student.Assignment.Add(asgn);
			}

		}
	}
}
