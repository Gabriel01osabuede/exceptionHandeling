using System;

namespace week6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ExceptionClass myExceptionObject = new ExceptionClass();
            Console.WriteLine(myExceptionObject.ExceptionMethod());





            //  We have to calculate the percentage
            // of marks obtained in three subjects (each out of 100) by student A 
            //and in four subjects 
            // (each out of 100) by student B.
            
            // Create an abstract class 'Marks' with an abstract method 'getPercentage'.
            // It is inherited by two other
            //  classes 'A' and 'B' each having a method with the
            // same name which returns the percentage of the students. 
            //The constructor of student A takes  the marks in three subjects as its parameters
            // and the marks in four subjects as its 
            // parameters for student B. 
            //  Create an object for each of the two classes
            // and print the percentage of marks for both the students.


            // Marks FirstStudent = new StudentA(90,80,70);
            // Marks SecondStudent = new StudentB(90,80,70,40);

            // Console.WriteLine($"The Percentage For Student A = {FirstStudent.getPercentage()}%");
            // Console.WriteLine($"The Percentage For Student B = {SecondStudent.getPercentage()}%");
        }
    }
}
