// Description : Student Details Management
// Author : Kamaraj
// Created at : 4/02/2021
// Reviewed by : Anto
// Next Review : 15/2/2021

using System;

namespace StudentDetails 
{
	class Program 
	{
		static void Main() 
		
		{
		// SqlConnection connection = new SqlConnection("data source =. ; database = SampleDB; integrated security = SSPI");

			Top:
			try
			{
				Console.WriteLine("Enter the Number of Students (within 50) :");
				int studentsCount = Convert.ToInt32(Console.ReadLine());

				if(studentsCount < 1 || studentsCount > 50)
					throw new FormatException("Invalid Count, Please Enter Between ( 1 - 50):");

				// creating array of objects
				Student[] studentData = new Student[studentsCount];

				// calling the SetInfo method based on array of objects
				for (int index = 0; index < studentsCount; index++) 
				{
					studentData[index] = new Student();
					studentData[index].GetData(index,studentData);
				}

				var edit = true;

				while (edit) {
					Console.WriteLine("Press 1 to update details \nPress 2 for deleting the record\nPress 3 for Displaying Details\nPress 0 to Exit");
					int update = Convert.ToInt32(Console.ReadLine());

					// calling the update method and mark method
					if (update == 1) 
					{
						Console.WriteLine("Update Record");
						Console.WriteLine("Enter the Reference Number");

						int id = Convert.ToInt32(Console.ReadLine()); 
						studentData[id - 1].UpdateData();
						studentData[id - 1].mark();

						Console.WriteLine("Student DataBase");
					}
					
					else if (update == 2) 
					{
						// calling the delete method and mark method
						Console.WriteLine("Delete Record");
						Console.WriteLine("Enter the Reference Number");

						int id = Convert.ToInt32(Console.ReadLine());
						studentData[id - 1].delete();
						studentData[id - 1].mark();

						Console.WriteLine("Deleted Record From Student DataBase");
						studentsCount -= 1;
					}

					else if(update == 3)
					{
					// calling the printInfo method based on array of objects
						Console.WriteLine("Student DataBase");
						Console.WriteLine("{0,10} {1,10} {2,13} {3,18} {4,10} {5,10} {6,10} {7,10}","NAME","ROLL NUMBER","YEAR OF STUDY","REFERENCE NUMBER", "TOTAL MARK", "GRADE","PERCENTAGE","RESULT");
						for (int index = 0; index < studentsCount; index++) 
						{
							studentData[index].mark();
							studentData[index].DisplayData(index+1);
					    }
					   if(studentsCount == 0)
					   {
						   Console.WriteLine("DataBase is Empty");
					   }
					}

					else if (update == 0) 
					{
						// used to end method
						edit = false;
					}

					else
						Console.WriteLine("Record Saved"); // end of the code:

					Console.WriteLine("Have a Nice Day");
				}

			} 
			catch(Exception e) 
			{
				Console.WriteLine(e.Message);
				goto Top;
			}

		}

	}
}