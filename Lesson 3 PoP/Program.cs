using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_PoP
{
    class Program
    {
        private static void Task1()
        {
            Console.Write("Side A : ");
            int sideA = int.Parse(Console.ReadLine());

            Console.Write("Side B : ");
            int sideB = int.Parse(Console.ReadLine());

            Console.Write("Side C : ");
            int sideC = int.Parse(Console.ReadLine());

            if(sideA == sideB || sideB==sideC || sideA==sideC)
            {                
                if (sideA == sideB && sideB == sideC)
                {
                    Console.WriteLine("There are 3 equals sides. ");
                    Console.WriteLine("A, B and C are equal.");
                }
                else
                {
                    Console.WriteLine("There are 2 equals sides. ");
                    if (sideA == sideB)
                    {
                        Console.WriteLine("A is equal to B.");
                    }
                    else if (sideA == sideC)
                    {
                        Console.WriteLine("A is equal to C.");
                    }
                    else
                    {
                        Console.WriteLine("B is equal to C.");
                    }
                }                
            } 
            else
            {
                Console.WriteLine("None of the side is equal to another.");
            }
        }

        private static void Task2()
        {
            int counter = 0;
            int sum = 0;

            for(int i = 0; i<=10; i++)
            {
                Console.Write($"Please enter number {i} :");
                int number = Convert.ToInt32(Console.ReadLine());

                if(number>=10 && number<=20)
                {
                    counter++;
                    sum = sum + number;
                }
            }
            Console.WriteLine($"There are {counter} numbers between 10 and 20");
            Console.WriteLine("Sum of numbers between 10 and 20 is : " + sum);
        }

        private static void Task3()
        {
            Console.Write("Please enter your height in centimeters : ");
            int height = Convert.ToInt32(Console.ReadLine());

            if(height > 190)
            {
                Console.Write("Baseball");
            }
            else if (height >175)
            {
                Console.WriteLine("Athletics");
            }
            else
            {
                Console.WriteLine("Horse riding");
            }
              
        }

        private static string Day(int dayDigit)
        {
            switch (dayDigit)
            {
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                case 7: return "Sunday";
                default:
                    return "Error!";

            }
        }

        private static string PeriodDay (int hour)
        {
            string periodDay = " ";
            if (hour < 8 || hour > 21)
            {
                periodDay = "night";
            }
            else if (hour < 12)
            {
                periodDay = "morning";
            }
            else if (hour < 18)
            {
                periodDay = "afternoon";
            }
            else
            {
                periodDay = "evening";
            }
            return periodDay;
        }

        private static void Task4()
        {
            Console.Write("Please enter the digit that correspond to the day of the week : ");
            int dayDigit = Convert.ToInt32(Console.ReadLine());        
            Console.Write("Please enter the hour : ");
            int hour = Convert.ToInt32(Console.ReadLine());
            string day = " ";
            string periodDay = " ";
            int we = 6-dayDigit;

            day = Day(dayDigit);
            periodDay = PeriodDay(hour);

            if(we > 0)
            {
                Console.Write($"Good {periodDay}, it is a lovely {day} today. Weekend is coming in {we} days.");
            }
            else
            {
                Console.Write($"Good {periodDay}, it is a lovely {day} today. Weekend is here!");
            }
        }

        private static void Task4Bis(int dayDigit, int hour)
        {
            string day = " ";
            string periodDay = " ";
            int we = 6 - dayDigit;

            day = Day(dayDigit);
            periodDay = PeriodDay(hour);

            if (we > 0)
            {
                Console.Write($"Good {periodDay}, it is a lovely {day} today. Weekend is coming in {we} days.");
            }
            else
            {
                Console.Write($"Good {periodDay}, it is a lovely {day} today. Weekend is here!");
            }
        }

        private static void Task5()
        {
            int mistakes = 0;
            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();
            if(firstName.Length > 100)
            {
                Console.WriteLine("Your first name is incorrect!");
                    mistakes++;
            }

            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            if (name.Length > 100)
            {
                Console.WriteLine("Your name is incorrect!");
                mistakes++;
            }            

            Console.Write("What's your date of birth? (../../....) ");
            string dateOfBirth = Console.ReadLine();
            string[] birthday = dateOfBirth.Split('/');
            DateTime date = DateTime.Now;
            int year = Convert.ToInt32(birthday[2]);
            int month = Convert.ToInt32(birthday[1]);
            int day = Convert.ToInt32(birthday[0]);
            if(year > date.Year || year < date.Year-100 )
            {
                Console.WriteLine("Wrong year of date of birth");
                mistakes++;
            }
            if (month > 12 || month < 1 || (year == date.Year && month > date.Month))
            {
                Console.WriteLine("Wrong month of date of birth");
                mistakes++;
            }
            if (day > 31 || day < 1 || (year == date.Year && month == date.Month && day > date.Day))
            {
                Console.WriteLine("Wrong day of date of birth");
                mistakes++;
            }

            Console.Write("What's your student number? (YYYYFFSSNNNN) ");
            string studentNumber = Console.ReadLine();
            if (studentNumber.Length != 12)
            {
                Console.WriteLine("Your Student Number is incorrect!");
                mistakes++;
            }
            string yearOfStudy = "";
            string faculty = "";
            string speciality = "";
            string numberSpe = "";
            for(int i = 0; i<studentNumber.Length; i++)
            {
                if(i<4)
                {
                    yearOfStudy = yearOfStudy + studentNumber[i];
                }
                else if (i == 4 || i == 5)
                {
                    faculty = faculty + studentNumber[i];
                }
                else if (i == 6 || i == 7)
                {
                    speciality = speciality + studentNumber[i];
                }
                else if(i>7)
                {
                    numberSpe = numberSpe + studentNumber[i];
                }
            }

            if(Convert.ToInt32(faculty) > 05 || Convert.ToInt32(faculty) < 01)
            {
                Console.WriteLine("Wrong code of faculty!");
                mistakes++;
            }
            if (Convert.ToInt32(speciality) > 09 || Convert.ToInt32(speciality) < 01)
            {
                Console.WriteLine("Wrong code of speciality!");
                mistakes++;
            }

            Console.WriteLine();
            if(mistakes == 0)
            {
                Console.WriteLine($"Your first name is {firstName} and you're name is {name}.");
                Console.WriteLine($"Your date of birth is : {dateOfBirth}");
                Console.WriteLine($"According to your student number, you are on year {yearOfStudy} and the code of your faculty is {faculty}.");
                Console.WriteLine($"The code of your speciality is {speciality} and the number within speciality is {numberSpe}.");
            }
            else
            {
                Console.WriteLine("You made at least one mistake which implies that we can't sum up your information!");
            }            
        }

        static void Main(string[] args)
        {
            //Task1();

            //Task2();

            //Task3();

            //Task4();

            //Task4Bis((int)DateTime.Today.DayOfWeek, DateTime.Today.Hour);

            Task5();

            Console.ReadKey();
        }
    }
}
