using System;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");


        }

        public static string GetName()
        {
            Console.WriteLine("Please enter your name:");
            return Console.ReadLine();
            //throw new NotImplementedException();
        }

        public static void GreetFriend(string name)
        {
            //Greeting should be: Hello, nameVar. You are my friend
            //Ex: Hello, Jim. You are my friend
            Console.WriteLine($"Hello, {name}. You are my friend");
            //throw new NotImplementedException();
        }

        public static double GetNumber()
        {
            Console.WriteLine("Enter a Number:");
            string s = Console.ReadLine();
            if(Double.TryParse(s,out double validDouble)){
                return validDouble;
            }
            throw new FormatException();
            //Should throw FormatException if the user did not input a number
            //throw new NotImplementedException();
        }

        public static int GetAction()
        {
            while(true){
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("1)add, 2)subtract, 3)multiply, or 4)divide");
            string s = Console.ReadLine();
            if(Int32.TryParse(s,out int input)){
                if(input>0 && input<5){
                    return input;
                }
            }
            }
            //throw new NotImplementedException();
        }

        public static double DoAction(double x, double y, int z)
        {
            if(z<1 || z>4){
            throw new FormatException();
            }
            double val;
            //throw new FormatException();
            switch(z){
                case 1: val =x+y;Console.WriteLine(val); return val;
                case 2: val=y-x;Console.WriteLine(val); return val;
                case 3: val=x*y;Console.WriteLine(val); return (val);
                default: 
                    if(x != 0)
                    {
                        val=y/x;
                        Console.WriteLine(val);
                        return (val);
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }
                    
            }
            //throw new NotImplementedException();
        }
    }
}
