using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASL_Project
{
    public class Quiz
    {
        int Quizscore = 0;
      public  double Totalscore, TotalGrade;

        public  void Quizstart()
        {
            
            string Answer;


            Console.WriteLine(" you have launched the Quiz portal");

            Console.WriteLine(" you will answer the following questions");

            Console.WriteLine(" 1. all apples are red, True or False?");

            Answer = Console.ReadLine().ToLower();
                        if (Answer == "false")
                            {
                                    Quizscore = Quizscore + 1;
                            }
            Console.WriteLine(" 2. all apples are cars, True or False?");

            Answer = Console.ReadLine().ToLower();
            if (Answer == "false")
            {
                Quizscore = Quizscore + 1;
            }

            Console.WriteLine("3.  blind can not see , True or False?");

            Answer = Console.ReadLine().ToLower();
            if (Answer == "true")
            {
                Quizscore = Quizscore + 1;
            }

            Console.WriteLine("4.  blind can not walk , True or False?");

            Answer = Console.ReadLine().ToLower();
            if (Answer == "false")
            {
                Quizscore = Quizscore + 1;
            }
             Totalscore = Quizscore ;

            Console.WriteLine(Totalscore); //total score without percentage
             double    QuizScore = (Totalscore / 4) * 100; //percentage canculation for quiz
            TotalGrade = Quizscore; //records the total grade in 

            Console.WriteLine(TotalGrade); //final Quiz score
        }
       

        
    }
}
