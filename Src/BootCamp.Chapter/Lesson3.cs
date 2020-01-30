using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            var firstName = PromptString("Enter first name: ");
            var lastName = PromptString("Enter last name: ");
            var age = PromptInt("Enter age: ");
            var weight = PromptFloat("Enter weight (in kg): ");
            var height = PromptFloat("Enter height (in cm): ");
            var bmi = CalculateBmi(weight, height);

            var output = $"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm.\n{firstName} has a BMI of {bmi}";

            Console.WriteLine(output);

        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return Int32.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }


    }
}
