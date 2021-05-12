using System;
using System.Text.RegularExpressions;

namespace StudentDetails {
	class Examination {
		// protected date members
		protected int elective1, elective2, elective3;
		protected int totalmarks;
		protected string grade;
		protected double percentage;
		protected string result;

		public void mark() {
			// method t0 calculate total , grade and percentage
			int total = elective1 + elective2 + elective3;

			double average = total / 3;
			percentage = average;

			if (average > 90) {
				grade = "A";
				totalmarks = total;
			} else if (average > 80 && average <= 90) {
				grade = "B";
				totalmarks = total;
			} else if (average >= 65 && average <= 80) {
				grade = "C";
				totalmarks = total;
			} else if (average >= 45 && average <= 64) {
				grade = "D";
				totalmarks = total;
			} else if (average >= 20 && average <= 44) {
				grade = "E";
				totalmarks = total;
			} else {
				grade = "F";
				totalmarks = total;
			}
			if(grade == "E" || grade == "F")
			{
				result = "FAIL, Work Hard to Get Pass Mark";
			}
			else
			{
				result = "PASS";
			}

		}
	}
}