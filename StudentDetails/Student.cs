using System;
using System.Text.RegularExpressions;

namespace StudentDetails {
	class Student: Examination {
		// private data members
		private string rollno;
		private string name;
		private int yearofstudy;
		private string batchNo = "2021BE";  
		
		private bool NameValidation(String validatingString)
		{
			// validate if any character is not a special character or number
			for (int index = 0; index < validatingString.Length; index++) {
				if (!Char.IsLetter(validatingString[index])) {
					return false;
				}
			}
			return true;
		}

		private bool RollNumberValidation(String validatingString)
		{
			// validate if any character is not a special character
			for (int index = 0; index < validatingString.Length; index++) {
				if (!Char.IsLetterOrDigit(validatingString[index])) {
					return false;
				}
			}
			return true;
		}

		private string getStringValue(string msg,string s)
		{
			Boolean status = true;
			string inputVar = "";
			while(status)
			{
				try 
				{
					Console.WriteLine(msg);
					inputVar = Console.ReadLine();
					
					if( s == "name" && ( inputVar == "" || !NameValidation( inputVar ) ) )
					{
						throw new ArithmeticException("!!! Invalid " + s + ", Retry Again!!!");
					}
					if( s == "roll no" && ( inputVar == "" || !RollNumberValidation( inputVar ) ) )
					{
						throw new ArithmeticException("!!! Invalid " + s + "Retry Again!!!");
					}

					status = false;
				}
				catch(Exception e )
				{
					Console.WriteLine(e.Message);
				}
			}
			return inputVar;
		}


			private int yearofstudyValidation(string msg){
			Boolean status = true;
			int inputVar = 0;
			while(status){
				try {
					Console.WriteLine(msg);
					inputVar = Convert.ToInt32(Console.ReadLine());
					if( inputVar < 1 || inputVar > 4){
						throw new ArithmeticException("!!! Invalid Year of Study, Please Enter Between 1 -4 !!!");
					}
					status = false;
				}catch(Exception e ){
					Console.WriteLine(e.Message);
				}
			}
			return inputVar;
		}


			private int getMark(string msg)
			{
			Boolean status = true;
			int inputVar = 0;
			while(status){
				try {
					Console.WriteLine(msg);
					inputVar = Convert.ToInt32(Console.ReadLine());
					if( inputVar < 0 || inputVar > 100 ){
						throw new ArithmeticException("!!! Invalid mark, Please enter Between 1 - 100 !!!");
					}
					status = false;
				}catch(Exception e ){
					Console.WriteLine(e.Message);
				}
			}
			return inputVar;
		}
		
		public void GetData(int referencenumber, Student[] arr) {
			// method to set student details

		
				name = getStringValue("Enter Student Name : ","name");
				rollno = getStringValue("Enter Student ROll Number : ","roll no");
				yearofstudy = yearofstudyValidation("Enter Student Year of Study : ");
				
				Console.WriteLine("\nStudent Id Number is {0}{1}",batchNo, referencenumber+1);
				Console.WriteLine("Reference Number is {0}", referencenumber+1);


				Console.WriteLine("\nEnter the Marks Out of 100");
				elective1 = getMark("Enter Elective1 Mark :");
				elective2 = getMark("Enter Elective2 Mark :");
				elective3 = getMark("Enter Elective3 Mark :");

				Console.WriteLine("Student Record Submitted: ");
		}
		
		public void DisplayData(int i) {
			// method to print student details
			Console.WriteLine("{0,10} {1,12} {2,13} {3,18} {4,10} {5,10} {6,10} {7,10}", name, rollno, yearofstudy, i, totalmarks, grade, percentage, result);

			// Console.WriteLine("\tName     	 : " + name);
			// Console.WriteLine("\tRollNo   	 : " + rollno);
			// Console.WriteLine("\tYear of Study    : " +yearofstudy);
			// Console.WriteLine("\tReference Number : " + i);
			// Console.WriteLine("\tTotal mark 	 : " + totalmarks);
			// Console.WriteLine("\tGrade      	 : " + grade);
			// Console.WriteLine("\tPercentage 	 : " + percentage);
			// Console.WriteLine("\tResult     	 : " + result+"\n");
		}

		
		public bool UpdateData() {
			// method to update the Student details
		try {
				name = getStringValue("Enter Student Name : ","name");
				rollno = getStringValue("Enter Student ROll Number : ","roll no");
				yearofstudy = yearofstudyValidation("Enter Student Year of Study : ");

				Console.WriteLine("Enter the Marks Out of 100");
				elective1 = getMark("Enter Elective1 Mark :");
				elective2 = getMark("Enter Elective2 Mark :");
				elective3 = getMark("Enter Elective3 Mark :");

				Console.WriteLine("Student Record Submitted: ");

			} catch (Exception e) {
				Console.WriteLine(e.Message);
				Console.WriteLine("You have to re enter the detials...");
				return false;
			}
			return true;
			
		}
		
		public void delete() {
			// method to delete the student details
			name = null;
			rollno = null;
	        yearofstudy = '\0';
			elective1 = '\0';
			elective2 = '\0';
			elective3 = '\0';
			grade = null;
			percentage = '\0';

		}

	}
}