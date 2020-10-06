using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCaloriesAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(".................)THIS APPLICATION WRITTEN ACCORDING TO THE MIFFLIN-ST Jeor FORMULA IN  - 2005 (.....Version - 1.0.....");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("                             Choose Your Gender : (1) for Male - (2) for female                                 ");

            Console.WriteLine();
            string genders = Console.ReadLine();

            int Gender = 0;
            try
            {

                Gender = Convert.ToInt16(genders);
            }
            catch
            {
                Console.WriteLine(" Wrong Input ! ");
                Console.WriteLine();

            }

            double Age = 0;
            double Height = 0;
            double Weight = 0;
            double Activity = 0;


            if (Gender == 1)// male
            {

                Console.WriteLine(" Hey you are Male  :)");
                Console.WriteLine();
                //age
                Console.Write("input your Age :  ");
                string age1 = Console.ReadLine();


                //height
                Console.Write("input your Height in Centimeter :  ");
                string height = Console.ReadLine();

                //weight
                Console.Write("input your Weight in Kg :  ");
                string weight = Console.ReadLine();

                //types
                Console.Write("Choose One Type Of Activities: (1)Not Athletic (2)I play a Few Sports (3)Medium Practice (4)I Practice Hard ");
                Console.WriteLine();
                string type = Console.ReadLine();

                try
                {

                    Age = Convert.ToInt16(age1);
                    Height = Convert.ToInt16(height);
                    Weight = Convert.ToInt16(weight);
                    Activity = Convert.ToInt16(type);
                }
                catch
                {
                    Console.WriteLine(" Exit Program ..... ");
                    Console.ReadKey();

                }



                // - - - - - - - - - - - - - -- - - - - - - - - - - - - - - Male Formula - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
                if (Activity == 1)
                {

                    // MIFFLIN - ST JEOR 2005 FORMULA

                    double sum = Math.Round(Weight / (Height / 100 * Height / 100));
                    if (sum < 25) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you need to up your weight)"); }
                    else if (sum > 25) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you need a diet)"); }
                    else { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you are in a good shape)"); }
                    double formula1 = ((Weight * 10) + (Height * 6.25) - (Age * 5) + 5) * 1.25;
                    Console.WriteLine("You Need : " + formula1 + " CALORIES ");
                    Console.WriteLine();





                }
                else if (Activity == 2)
                {

                    double sum = Math.Round(Weight / (Height / 100 * Height / 100));
                    if (sum < 25) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you need to up your weight)"); }
                    else if (sum > 25) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you need a diet)"); }
                    else { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you are in a good shape)"); }
                    double formula2 = ((Weight * 10) + (Height * 6.25) - (Age * 5) + 5) * 1.375;

                    Console.WriteLine("You Need : " + formula2 + " CALORIES ");
                    Console.WriteLine();

                }
                else if (Activity == 3)
                {
                    double sum = Math.Round(Weight / (Height / 100 * Height / 100));
                    if (sum < 25) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you need to up your weight)"); }
                    else if (sum > 25) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you need a diet)"); }
                    else { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you are in a good shape)"); }
                    double formula3 = ((Weight * 10) + (Height * 6.25) - (Age * 5) + 5) * 1.550;

                    Console.WriteLine("You Need : " + formula3 + " CALORIES ");
                    Console.WriteLine();

                }
                else if (Activity == 4)
                {
                    double sum = Math.Round(Weight / (Height / 100 * Height / 100));
                    if (sum < 25) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you need to up your weight)"); }
                    else if (sum > 25) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you need a diet)"); }
                    else { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 25" + " (you are in a good shape)"); }
                    double formula4 = ((Weight * 10) + (Height * 6.25) - (Age * 5) + 5) * 1.725;

                    Console.WriteLine("You Need : " + formula4 + " CALORIES ");
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine(" An ERROR ! ");

                }

                // - - - - - - - - - - - - - -- - - - - - - - - - - - - - - Female Formula - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

            }
            else if (Gender == 2)//Female
            {

                Console.Write(" Hey you are Female ;) ");
                Console.WriteLine();
                Console.WriteLine();
                //age
                Console.Write("input your Age :  ");
                string age1 = Console.ReadLine();


                //height
                Console.Write("input your Height in Centimeter :  ");
                string height = Console.ReadLine();

                //weight
                Console.Write("input your Weight in Kg :  ");
                string weight = Console.ReadLine();

                //types
                Console.Write("Choose One Type Of Activities : (1)Not Athletic (2)I play a Few Sports (3)Medium Practice (4)I Practice Hard ");
                Console.WriteLine();
                string type = Console.ReadLine();

                try
                {

                    Age = Convert.ToInt16(age1);
                    Height = Convert.ToInt16(height);
                    Weight = Convert.ToInt16(weight);
                    Activity = Convert.ToInt16(type);
                }
                catch
                {
                    Console.WriteLine(" Exit Program ..... ");
                    Console.ReadKey();

                }

                if (Activity == 1)
                {

                    // MIFFLIN - ST JEOR 2005 FORMULA

                    double sum = Math.Round(Weight / (Height / 100 * Height / 100));
                    if (sum < 24) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you need to up your weight)"); }
                    else if (sum > 24) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you need a diet)"); }
                    else { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you are in a good shape)"); }
                    double formula1 = ((Weight * 10) + (Height * 6.25) - (Age * 5) - 161) * 1.25;
                    Console.WriteLine("You Need : " + formula1 + " CALORIES ");
                    Console.WriteLine();





                }
                else if (Activity == 2)
                {

                    double sum = Math.Round(Weight / (Height / 100 * Height / 100));
                    if (sum < 24) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you need to up your weight)"); }
                    else if (sum > 24) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you need a diet)"); }
                    else { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you are in a good shape)"); }
                    double formula2 = ((Weight * 10) + (Height * 6.25) - (Age * 5) - 161) * 1.375;

                    Console.WriteLine("You Need : " + formula2 + " CALORIES ");
                    Console.WriteLine();

                }
                else if (Activity == 3)
                {
                    double sum = Math.Round(Weight / (Height / 100 * Height / 100));
                    if (sum < 24) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you need to up your weight)"); }
                    else if (sum > 24) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you need a diet)"); }
                    else { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you are in a good shape)"); }
                    double formula3 = ((Weight * 10) + (Height * 6.25) - (Age * 5) - 161) * 1.550;

                    Console.WriteLine("You Need : " + formula3 + " CALORIES ");
                    Console.WriteLine();

                }
                else if (Activity == 4)
                {
                    double sum = Math.Round(Weight / (Height / 100 * Height / 100));
                    if (sum < 24) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you need to up your weight)"); }
                    else if (sum > 24) { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you need a diet)"); }
                    else { Console.WriteLine("Body Mass Index (BMI) = " + sum + " / 24" + " (you are in a good shape)"); }
                    double formula4 = ((Weight * 10) + (Height * 6.25) - (Age * 5) - 161) * 1.725;

                    Console.WriteLine("You Need : " + formula4 + " CALORIES ");
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine(" An ERROR ! ");

                }



            }
            else
            {
                Console.Write(" We Don't Know What Is That ! ");

            }
            Console.WriteLine();
            Console.ReadKey();


        }
    }
    
}





