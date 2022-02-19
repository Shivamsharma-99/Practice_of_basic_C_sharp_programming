using System;

namespace test
{
    class Program
    {
        static void vote()
        {
            Console.Write("Enter your age: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 18)
            {
                Console.WriteLine("You are not eligible to vote.");

            }
            else
            {
                Console.WriteLine("You are eligible to vote..");
            }
        }

        public void Checkno()
            {
            Console.Write("Enter your Number: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }
        }

        public static void pattern()
        {
            Console.WriteLine("Enter your pattern no..");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void pattern1()
        {
            int b = 5;
            for (int i = 0; i < b; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void Sumno()
        {
            int sum = 0, i;
            for (i = 1;  i< 10; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine(sum);
        }

        public static void cube()
        {
            int c, i;
            for (i = 1; i < 5; i++)
            {
                c = i * i * i;
                Console.WriteLine("Number is:{0} and the Cube of {1} is: {2}", i,i,c);
            }
        }

        static void Marksheet()
        {
            int Rollno = 1111, Math, English, Science, sumofsub;
            string Name = "Shivam";

            Console.Write("Enter your Rollno: ");
            Rollno = int.Parse(Console.ReadLine());
            if (Rollno == 1111)
            {
                Console.Write("Enter Your name: ");
                Name = Console.ReadLine();
                if (Name == "Shivam")
                {
                    Console.Write("Enter Your Math Subject marks:");
                    Math = int.Parse(Console.ReadLine());
                    Console.Write("Enter Your English Subject marks:");
                    English = int.Parse(Console.ReadLine());
                    Console.Write("Enter Your Science Subject marks:");
                    Science = int.Parse(Console.ReadLine());
                    sumofsub = Math + English + Science;
                    Console.WriteLine("The sum of these there subject is: " + sumofsub);
                    float per = (sumofsub / 3);
                    Console.WriteLine("Your percentage is: {0}%", per);

                    if (per < 50)
                    {
                        Console.WriteLine("Your grade is C");
                    }
                    else if (per < 70)
                    {
                        Console.WriteLine("Your grade is B");
                    }
                    else if (per < 90)
                    {
                        Console.WriteLine("Your grade is A");
                    }
                    else if (per > 90)
                    {
                        Console.WriteLine("Your grade is A+");
                    }

                }
                else
                {
                    Console.WriteLine("Username and Rollno is not matched. Try again.!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Rollno.!");
            }
        }

        
        void Calclator()
        {
            int res , num1, num2;
            Console.WriteLine("Enter First Number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Symbol(/,*,+,-):");
            string Symbol = Console.ReadLine();

            switch (Symbol)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Addition: {0}", res);
                    break;

                case "-":
                    res = num1 - num2;
                    Console.WriteLine("Subtraction: {0}", res);
                    break;

                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Multiplication: {0}", res);
                    break;

                case "/":
                    res = num1 / num2;
                    Console.WriteLine("Division: {0}", res);
                    break;
                default:
                    Console.WriteLine("Invalid choice.!");
                    break;
            }

        }

        static void table()
        {
            for (int i = 2; i <= 20; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(j*i);
                }
                Console.WriteLine("\n");
            }
        }
        static void userTable()
        {
            Console.Write("Enter the Number of Table:");
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(t+" X "+i+" = "+t*i);
            }
        }
        static void Main(string[] args)
        {
            //vote();
            //Program checknum = new Program();
            //checknum.Checkno();
            //Program.pattern();
            //pattern1();
            //Program forsum = new Program();
            //forsum.Sumno();
            //Program.cube();
            //Marksheet();
            //Program cal = new Program();
            //cal.Calclator();
            //Program.userTable();

            Console.ReadLine();
        }
    }
}
