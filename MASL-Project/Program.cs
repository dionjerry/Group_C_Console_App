// See https://aka.ms/new-console-template for more information

using MASL_Project;

using System;
using Newtonsoft.Json;

class Program { 
public static void Main(string[] args)
{
    Console.WriteLine("++++++Welcome to the MAsl University++++++++");
        RegisterUser StudentRegister = new RegisterUser();
        //initiate RegisterUser class 

        

    Console.WriteLine("Are you a student?");

    Console.WriteLine("Yes or No");

    string UserReply = Console.ReadLine().ToLower();

    // replies Yes or No if the user is a student or not

    if ( UserReply == "yes")
    {
        Console.WriteLine(" Please Enter Matric Number to login");
           

    }
    else if ( UserReply == "no")
    {
            StudentRegister.registerUser1();
            //calls the method in RegisterUser
        }
}

}