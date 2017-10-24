using System;
using System.IO;
using System.Text.RegularExpressions;
// Description: CSharp introduktion assignment
// Author: Reza Rezaee


namespace CSharp_Assignment
{
    class Program
    {

        // new method to prompts user for inputs
        static void Say(string something)
        {
            string say = "Please enter your ";
            Console.WriteLine(say + something + ":");
        }

        // Strip user input string from html tags
        static string Uinput()
        {
            string uinputs = Console.ReadLine();
            string uinput = Regex.Replace(uinputs, "<.*?>", String.Empty);
            return uinput;
        }


        static int ValideraBDay(string datum)
        {
            try
            {
                DateTime bDay = DateTime.Parse(datum);
                // Your input string can (and will) be parsed with MM/dd/yyyy format.
                DateTime today = DateTime.Today;
                TimeSpan diff1 = today.Subtract(bDay);

                Console.WriteLine(today.ToShortDateString());
                Console.WriteLine(bDay.ToShortDateString());

                //Console.WriteLine(diff1);

                int age = today.Year - bDay.Year;
                int monad = today.Month - bDay.Month;
                int dag = today.Day - bDay.Day;

                if (age == 17 && monad == 0 && dag < 0)
                {
                    Console.WriteLine("Congrats!!! You will be 18 years old in {1} days and can apply for the job!!", dag * -1);
                }
                else if (monad == 0 && dag == 0)
                {
                    Console.WriteLine("Congrats!! Today is your birthday");
                }

                else if (monad == 0 && dag < 0)
                {
                    age--;
                    monad = 11;
                    dag += 30;
                }
                else if (monad < 0)
                {
                    age--;
                    monad += 12;
                }
                else if (dag < 0)
                {
                    monad -= 1;
                    dag += 30;
                }

                Console.WriteLine("You are {0} years and {1} month and {2} days old", age, monad, dag);

                if (age < 18 && age > 15)
                {

                    int antalYear = 17 - age;
                    int antalMonad = 12 - monad;
                    int antalDag = 30 - dag;
                    Console.WriteLine("Sorry, we are unable to employ talents under 18 years old. You can apply again in about {0} years and {1} months and {2} days", antalYear, antalMonad, antalDag);

                }


                var validage = Convert.ToString(age);
                int validag = Convert.ToInt32(validage);
                return validag;


            }
            catch
            {
                Console.WriteLine("You have inserted wrong format of date. Try again and follow this format: mm/dd/yyyy");
                return 0;
            }


        } // ########### Method Validera BDay Ends here ###################
    




    // ################################ Main method #######################################
    static void Main(string[] args)
        {
            string filensplats = @"C:\Users\Admin\Documents\fil\employee.txt";

            if (!File.Exists(filensplats)) // om .txt(text) filen inte finns så är det första vi gör att skapa upp den i angiven map 
            {
                Console.WriteLine("");
                using (StreamWriter streamwriter01 = File.CreateText(filensplats)) // skapar filen med hjälp av strängen 
                {

                }
            }


            Console.WriteLine("########## press 1 for admin and press 2 for new employee ##############");
            int val = Convert.ToInt32(Uinput());
            if (val == 1)
            {
                Say("password if you are admin");
                string pass = Uinput();
                if (pass == "admin")
                {
                    using (StreamReader streamreader = new StreamReader(filensplats)) // Tells that I want to use streamreader and where
                    {
                        string seeResum = streamreader.ReadToEnd(); // Read to the end with help of streamreader
                        Console.WriteLine(seeResum); // 
                    }

                }
                else
                {
                    Console.WriteLine("Password is wrong!");
                }
            }
            else
            {

                Employee n = new Employee();

                // Making an instance of Employee array
                Employee[] nya = new Employee[3];

                string answr = "";

                for (int num = 0; num < nya.Length; num++)
                {
                    nya[num] = new Employee();

                    Console.WriteLine("Welcome user number{0}", num + 1);
                    Say("First Name");
                    nya[num].F_Name = Uinput();

                    Say("Last Name");
                    nya[num].L_Name = Uinput();

                    Say("Birthday, mm/dd/yyyy");
                    string alder = Uinput();
                    var age = ValideraBDay(alder);


                    if (age < 18 && age != 0)
                    {
                        break;

                    }
                    else if (age == 0)
                    {
                        break;
                    }
                    nya[num].Alder = alder;

                    Say("Job title");
                    nya[num].Jobb_title = Uinput();

                    Say("Years of proffessional Experience");
                    //nya[num].Exp_years = Convert.ToInt32(Uinput());
                    int xpr = Convert.ToInt32(Uinput());
                    int diff = age - xpr;

                    if (diff < 18)
                    {
                        int diffxpr = age - 18;

                        nya[num].Exp_years = diffxpr;
                        Console.WriteLine("Sorry, but we count proffessional work from 18 years old, so we change your years of experience here to {0}", diffxpr);
                        
                    }
                    else
                    {
                        nya[num].Exp_years = xpr;
                    }


                    Say("Other Competence Area");
                    nya[num].Kompetens = Uinput();


                    Console.WriteLine(nya[num].F_Name + " " + nya[num].L_Name + " " + nya[num].Alder + " " + nya[num].Jobb_title + " " + nya[num].Exp_years + " " + nya[num].Kompetens);

                    Console.WriteLine("Is your information correct?");



                    answr = Uinput().ToLower();
                    if (answr == "yes")
                    {

                        using (StreamWriter streamwriter = File.AppendText(filensplats)) // AppendText appends userinfo to the file
                        {

                            streamwriter.WriteLine("User number {0}", num + ":" + nya[num].F_Name + " " + nya[num].L_Name + " " + nya[num].Alder + " Interested in JOB: " + nya[num].Jobb_title + " Has " + nya[num].Exp_years + " years of experience and even is familiar with " + nya[num].Kompetens);
                            Console.WriteLine();
                            Console.WriteLine("Your personal info are registerd now!");
                        }
                    }
                    else
                    {
                        break;
                    }

                    // ############ IQ Test #############
                    Console.WriteLine("For applying to this job you nedd to have a good understanding of numbers and mathematic. Answer to these questions:");
                    Console.WriteLine("Please enter the missing number: 4, 8, 14, 22, ?");//32
                    int test1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the missing number: 4, 5, 8, 17, 44, ?");//125
                    int test2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mary, who is sixteen years old, is four times as old as her brother. How old will Mary be when she is twice as old as her brother?");
                    int test3 = Convert.ToInt32(Console.ReadLine()); // 24
                    Console.WriteLine("At the end of a banquet 10 people shake hands with each other. How many handshakes will there be in total? 100, 45, 20, 90, 10"); // 45
                    int test4 = Convert.ToInt32(Console.ReadLine());
                    int iq = 0;
                    if (test1 == 32) iq++;
                    if (test2 == 125) iq++;
                    if (test3 == 24) iq++;
                    if (test4 == 45) iq++;


                    using (StreamWriter streamwriter = File.AppendText(filensplats)) // AppendText lägger till text i den befintliga filen även om text redan finns där eller om det inte skulle finnas någon text där.
                    {

                        streamwriter.WriteLine("IQ-Result for User number {0}", num + ":" + iq * 25); //writeline gör ny rad i text filen. Write skulle skriva direkt efter.
                        Console.WriteLine();
                        Console.WriteLine("Thanks for showing interest in our company. Your test results are registerd now and we will contact you soon for feedback!");
                    }

                } // For loop Ends here

            }

        } // ########### Main Method Ends here ################

    } // ####################################  Class Program Ends here  ##############################################


    // ###################################### Class Employee to make new instances of user/employee ##############################################
    class Employee
    {
        private int exp_year;
        private string fname, lname, komp, jobb, age;

        public string F_Name
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }


        public string L_Name
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }


        public string Kompetens
        {
            get
            {
                return komp;
            }
            set
            {
                komp = value;
            }
        }

        public string Jobb_title
        {
            get
            {
                return jobb;
            }
            set
            {
                jobb = value;
            }
        }

        public string Alder
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }


        public int Exp_years
        {
            get
            {
                return exp_year;
            }
            set
            {
                exp_year = value;
            }
        }

    }// Class Employee Ends here





}
