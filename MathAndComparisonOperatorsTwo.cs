using System;


namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: ");
            float pOneHourly = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week: ");
            int pOneHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
            float pTwoHourly = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week: ");
            int pTwoHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Weekly salary of Person 1:");
            float pOneSalary = pOneHourly * pOneHours;
            Console.WriteLine(pOneSalary);

            Console.WriteLine("Weekly salary of Person 1:");
            float pTwoSalary = pTwoHourly * pTwoHours;
            Console.WriteLine(pTwoSalary);

            bool compare = pOneSalary > pTwoSalary;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(compare.ToString());
            Console.ReadLine();


        }
    }
}
