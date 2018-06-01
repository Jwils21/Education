using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Instructor {
		public string Name { get; set; }
		public int ExperienceInYears { get; set; }
		private string _PrimaryLanguage;
		/// <summary>
		/// Language can only be CSharp or Java
		/// </summary>
		public string PrimaryLanguage {
			get {
				return _PrimaryLanguage; }
			set {
				if(value == "CSharp" || value == "Java") {
					_PrimaryLanguage = value;
				}
			}
		}
		public string Email { get; set; }
		public string Phone { get; set; }
		
		public Assignment CreateAssignment(string name, string assignmentId) {
			Assignment asgn = new Assignment() {
				Comments = null,
				Grade = null,
				Name = name,
				AssignmentId = assignmentId
				
			};
			return asgn;
		}
	}
}
