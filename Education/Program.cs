using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Program {
		static void Main(string[] args) {

			Instructor danTheMan = new Instructor();
			danTheMan.Name = "Dan";
			danTheMan.ExperienceInYears = 17;
			danTheMan.PrimaryLanguage = "CSharp";
			danTheMan.Email = "dantheman@military.gov";
			danTheMan.Phone = "123-456-7890";

			Class dotNetBootCamp4 = new Class();
			dotNetBootCamp4.Capacity = 16;
			dotNetBootCamp4.Code = "DN4";
			dotNetBootCamp4.Language = "CSharpX";
			dotNetBootCamp4.Name = "Dot Net Boot Camp 4";
			dotNetBootCamp4.Instructor = danTheMan;

			Student foster = new Student();
			foster.Absences = 0;
			foster.ContactInfo = "Call Foster";
			foster.FirstJob = null;
			foster.Name = "Foster";
			foster.Class = dotNetBootCamp4;

			Student jj = new Student();
			jj.Absences = 0;
			jj.ContactInfo = "Call JJ";
			jj.FirstJob = DateTime.MinValue;
			jj.Name = "Jonathan";
			jj.Class = dotNetBootCamp4;

			Student mitch = new Student() {
				FirstJob = DateTime.MinValue,
				Name = "Mitch",
				Class = dotNetBootCamp4,
				Absences = 0,
				ContactInfo = "Call Mitch"
			};

			dotNetBootCamp4.Students.Add(foster);
			dotNetBootCamp4.Students.Add(jj);
			dotNetBootCamp4.Students.Add(mitch);

			

			Assignment asg1 = danTheMan.CreateAssignment("First fundamentals assignment", "Fundamentals 12");
			dotNetBootCamp4.DistributeAssignment(asg1);


		}
	}
}
