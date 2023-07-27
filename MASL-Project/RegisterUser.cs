using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASL_Project
{
   class RegisterUser
    {
       public void registerUser1 ()
        {
            String[] DepartmentList = { "Computer Engineering", "Mechatronics", "Agricultural Science", "Maths"};


            Console.WriteLine(" Please register");
            Console.WriteLine(" Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine(" Enter Your Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("The University Currently Offers the following departments");
            foreach(string department in DepartmentList)
            {
                Console.WriteLine(department);
                //displays department lists
            }


            Console.WriteLine("Enter asipiring department");
           string DepartmentField = Console.ReadLine().ToLower();
            //Enters desired Department

            switch (DepartmentField)
            {
                case "computer engineering":
                  DepartmentField = DepartmentList[0];
            break;

                case "mechatronics":
                    DepartmentField = DepartmentList[1];
                    break;

                case "agricultural science":
                    
                        DepartmentField = DepartmentList[2];

                    break;

                case "maths":

                    DepartmentField = DepartmentList[3];

                    break;




                deafault:
                    Console.WriteLine("Enter a valid department");
                    break;
            }

            Console.Clear(); //clears the prevoius screens and inputs

            Console.WriteLine( " you are applying to the departemnt of "+DepartmentField);
             
            Console.WriteLine(" you will need to take a Quiz for in other to be considered fot this department ");

            Quiz start = new Quiz(); //lauches the Quiz
            start.Quizstart();

            Console.WriteLine("test score " + start.TotalGrade);






            StudentDetails studentDetails = new StudentDetails()
            {
                // to initialize the StudentDetails class
                Name = name,
                Age = age
                
                //to add department
            };


            // Serialize the Person instance to JSON
            string jsonData = JsonConvert.SerializeObject(studentDetails, Formatting.Indented);

            // Define the path and filename where you want to save the JSON data
            string filePath = @"C:\Users\DON JERRY\source\repos\TEsting\TEsting\file.json";

            // Write the JSON data to the file
            File.AppendAllText(filePath, jsonData);

            Console.WriteLine("Data saved to JSON file successfully.");
        }
    }
}
