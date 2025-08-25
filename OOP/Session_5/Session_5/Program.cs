using Session_5.Classes;

namespace Session_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Question 1:
            What is the primary purpose of an interface in C#?
            b) To define a blueprint for a class


            Question 2:
            Which of the following is NOT a valid access modifier for interface members in C#?
            b) protected


            Question 3:
            Can an interface contain fields in C#?
            b) No


            Question 4:
            In C#, can an interface inherit from another interface?
            b) Yes, interfaces can inherit from multiple interfaces


            Question 5:
            Which keyword is used to implement an interface in a class in C#?
            None of the options are correct. The correct keyword is just a colon (:) 


            Question 6:
            Can an interface contain static methods in C#?
            a) Yes


            Question 7:
            In C#, can an interface have explicit access modifiers for its members?
            b) No, all members are implicitly public


            Question 8:
            What is the purpose of an explicit interface implementation in C#?
            a) To hide the interface members from outside access



            Question 9:
            In C#, can an interface have a constructor?
            b) No, interfaces cannot have constructors
            

            Question 10:
            How can a C# class implement multiple interfaces?
            c) By separating interface names with commas


             */

            Circle C1 = new Circle();
            C1.DisplayShapeInfo();

            Rectangle R1 = new Rectangle();
            R1.DisplayShapeInfo();

        }
    }
}
