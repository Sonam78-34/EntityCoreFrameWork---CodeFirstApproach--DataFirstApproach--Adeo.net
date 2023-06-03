using EntityCoreFrameworkCodeFirstApproach.Data;
using EntityCoreFrameworkCodeFirstApproach.ListColumn;

namespace EntityCoreFrameworkCodeFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using CollegeDBase collegeDB = new CollegeDBase();

            
            //data to be added in student table
            StudentDetails student = new StudentDetails
            {

                studentName = "Sonam",
                semester = 8

            };

            collegeDB.Add(student);
            collegeDB.SaveChanges();



            //data to be added in the department table
            /*
             StudentDepartment studentdepartment = new StudentDepartment
             {
                 dName = "Cse"

             };
             collegeDB.Add(studentdepartment); 
             collegeDB.SaveChanges(); 
             */


            //to update the semester

            var stud = collegeDB.StudentsDetails.Where(s => s.studentName == "sonam").First();
             
                if(stud is StudentDetails)
                {
                    stud.semester = 5;
                    
                }

            collegeDB.SaveChanges();

        }
    }
}