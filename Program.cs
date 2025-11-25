using ProgramFolder.CheckLeapYear;
using ProgramFolder.CheckPrimeNumbers;
using ProgramFolder.CountAlphaDigiCharacters;
using ProgramFolder.Divisible_by_N__M;
using ProgramFolder.FactorialOfANumber;
using ProgramFolder.FactorsOrDivisorsOfANumber;
using ProgramFolder.PerfectNumberCheck;
using ProgramFolder.PowerOfNP;
using ProgramFolder.SumOfAllFactors;
using ProgramFolder.SumOfEvenNumbers;
using System.Security.Cryptography.X509Certificates;

namespace ProgramFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat;

            do
            {
                Console.WriteLine("------------ MENU ------------");
                Console.WriteLine("Option 1 : Check Leap Year");
                Console.WriteLine("Option 2 : Is Divisible by N and M");
                Console.WriteLine("Option 3 : Sum of all even numbers between 1 to 100");
                Console.WriteLine("Option 4 : Print Factors/Divisors");
                Console.WriteLine("Option 5 : Sum of Factors");
                Console.WriteLine("Option 6 : Perfect Number");
                Console.WriteLine("Option 7 : Prime Number");
                Console.WriteLine("Option 8 : Find Factorial");
                Console.WriteLine("Option 9 : Find N power P");
                Console.WriteLine("Option 10 : Count Alphabets, Digits, Special Characters");
                Console.WriteLine("------------------------------");

                Console.Write("Please choose an option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (option == 1)
                {
                    printLeap();
                }
                else if (option == 2)
                {
                    printDivibleBy();
                }
                else if (option == 3)
                {
                    printEvenSum();

                }
                else if (option == 4)
                {
                    printFactors();
                }
                else if (option == 5)
                {
                    printSumFactors();
                }
                else if (option == 6)
                {
                    printPerfectNumber();
                }
                else if (option == 7)
                {
                    printPrime();
                }
                else if (option == 8)
                {
                    printFactorial();
                }
                else if (option == 9)
                {
                    printPowerOfN();
                }
                else if (option == 10)
                {
                    printCountAlphanumeric();
                }
                else
                {
                    Console.WriteLine("Invalid option! Try again.");
                }

                Console.WriteLine();
                Console.Write("Do you want to continue? (y/n): ");
                string ans = Console.ReadLine();

                repeat = ans.ToLower() == "y";

                Console.WriteLine();

            } while (repeat);


        }

        public static void printLeap()
        {
            Console.WriteLine("Please Enter The Year : ");
            int year=Convert.ToInt32(Console.ReadLine());
            LeapYear.isLeapYear(year);
        }

        public static void printDivibleBy()
        {
            Console.WriteLine("Enter the number : ");
            int num=Convert.ToInt32(Console.ReadLine());
            DivisibleBy.divisibleBy(num);
        }

        public static void printEvenSum()
        {
            Console.WriteLine("Enter the Number to get Sum of Even number : ");
            int num=Convert.ToInt32(Console.ReadLine());
            EvenNumberSum.SumOfEven(num);
        }

        public static void printFactors()
        {
            Console.WriteLine("please Enter the Number to check factors : ");
            int num= Convert.ToInt32(Console.ReadLine());

            FactorsOrDivisor.factors(num);
        }
        public static void printSumFactors()
        {
            Console.WriteLine("please Enter the Number to Sum the factors : ");
            int num= Convert.ToInt32(Console.ReadLine());

            FactorsSum.sumOfFactors(num);
        }

        public static void printPerfectNumber()
        {
            Console.WriteLine("please Enter the Number to check Perfect number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            PerfectNumber pn=new PerfectNumber();
            bool result = pn.checkPerfectNumber(num);

            if (result)
                Console.WriteLine($"The Number {num} is a Perfect Number");
            else
                Console.WriteLine($"The Number {num} is not a Perfect Number");
        }

        public static void printPrime()
        {
            Console.WriteLine("please Enter the Number to check Prime number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            PrimeNumbers primeNumbers = new PrimeNumbers();
            bool result =primeNumbers.isPrime(num);


            if (result)
                Console.WriteLine($"The Number {num} is a Prime Number");
            else
                Console.WriteLine($"The Number {num} is not a Prime Number");
        }

        public static void printFactorial()
        {
            Console.WriteLine("please Enter the Number for factorial : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Factorial fac=new Factorial();
            long result=fac.factorialOfNumber(num);

            Console.WriteLine($"The Factorial of {num} is {result}");
        }
        public static void printPowerOfN()
        {
            Console.WriteLine("please Enter the Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please Enter the Power : ");
            int pow = Convert.ToInt32(Console.ReadLine());

            NPPower nP=new NPPower();
            long result=nP.powerOfNP(num, pow);

            Console.WriteLine($"The answer is {result}");
        }

        public static void printCountAlphanumeric()
        {
            Console.WriteLine("Enter The AlphaNumeric Characters :");

            String s=Console.ReadLine();
            AlphaDigiCharsCount.countAlphaNumeric(s);
        }
    }
}