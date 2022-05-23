using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASSIGNMENT");
            Console.WriteLine("************************************************************");
            Tasks obj = new Tasks();
            double rRaiseTo = obj.RaiseTo(5,0);
            Console.WriteLine($"RaiseTo of given numbers are {rRaiseTo}");
            Console.WriteLine("************************************************************");

            double rFactorial = obj.Factorial(8);
            Console.WriteLine($"Factorial of the given no is: { rFactorial}" );
            Console.WriteLine("************************************************************");

            //double Trignomentry = obj.trignomentry("Cos", 0);
            //double Trignomentry = obj.trignomentry("Sin", 0);
            double Trignomentry = obj.trignomentry("Tan", 45);
            Console.WriteLine("Trignomentry=" + Trignomentry);
            Console.WriteLine("************************************************************");

            double Area = obj.area("Square", new double[] { 4 });
            // double Area = obj.area("Circle", new double[] {4,2});
            // double Area = obj.area("Triangle", new double[] { 4 });
            //double Area = obj.area("Rectangle=", new double[] { 4, 2 });
            Console.WriteLine("Area=" + Area);
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************");
            Console.ReadLine();
        }
    }
    public class Tasks
    {
        //private bool Validate(int x, int y)
        //{
        //    if (x == 0 || y == 0)
        //        return false;
        //    else
        //        return true;
        //}
        //private bool Validate(int x,int y)
        //{
        //    if (x > 0 || y > 0)
        //    {
        //        return false;
        //    }
             
        //}

        public double RaiseTo(int x, int y)
        {

            //if (!Validate(x, y))
            //{
            //    return 0;
            //}
            //else if(y==0)
            //{

            //}
            double z = Math.Pow(x, y);
            return z;
        }
        public double Factorial(int num)
        {
            int i, fact;       
            fact = num;
            for (i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
            }          
            return fact;
        }
        public double trignomentry(string x, double y)
        {
            if (x == "Cos")
            {
                double cos = Math.Cos(y);
                return cos;
            }
            if (x == "Sin")
            {
                double sin = Math.Sin(y);
                return sin;
            }
            if (x == "Tan")
            {
                double tan = Math.Tan(y);
                return tan;
            }
            else return 0;
        }
        public double area(string x, double[] arr)
        {
            if (x == "Circle")
            {
                double area = Math.PI * arr[0] * arr[0];
                return area;
            }
            if (x == "Square")
            {
                double area = arr[0] * arr[0];
                return area;
            }
            if (x == "Rectangle")
            {
                double area = arr[0] * arr[1];
                return area;
            }
            if (x == "Tangle")
            {
                double area = 0.5 * arr[0] * arr[1];
                return area;
            }
            else return 0;
        }
    }
    

}
