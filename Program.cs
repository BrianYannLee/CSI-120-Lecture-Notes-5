//Programmer: Brian Lee
//Date: 04/24/2024

//Title: CSI Notes 120 Lecture Notes 5

namespace CSI_120_Lecture_Notes_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programing Practice Menu!");
            Console.WriteLine("Type \"1\" for Grade Calculator");
            Console.WriteLine("Type \"2\" for Altitude Checker");
            Console.WriteLine("Type \"3\" to Exit Program");

            int userInput;

            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput != 1 && userInput != 2 &&  userInput != 3)
                Console.WriteLine("Invalid Input. Try Again.");

            if (userInput == 1)
            {
                Part2();
            }
            else if(userInput == 2)
            {
                Part1();
            }
            else
            {
                Environment.Exit(0);
            }

            //Questions:
            /*
             * 1. In programing, conditions like if/else if/and else blcok are known as a Decision Structure
             * 2. If you have an if/else if/else structure. HOwe many code block can you run in a single strucutre? You can run 1 code block
             * 3. Which block will run? It would run top to bottom only if the fufill the condition. If one does fulfill the condition, it will skip the rest.
             * 4. Fi you have two if seperate statement, can these both run? It will both run, but not at the same time, unless the second if statement is within the first.
             * 5. How many if else if statement can you have? Unlimited.
             * 6. Can you have else if / eles without an if? NO
             * 7. Can you have an if without and else? Yes
             * 8. Which logical operator do you choose if you have 2 conditions and both need to be true? &&
             * 9. Which logical operator do you choose if you have 2 conditons, but only one need to be true? ||
             * 
             */


        }//end of main
        public static void Part1()
        {
            Console.WriteLine("Part 1");
            Console.WriteLine();

            double height;

            Console.WriteLine("Please enter your height in feet.");
            while (!double.TryParse(Console.ReadLine(), out height))
                Console.WriteLine("Invalid Input. Try Again");

           switch(height)
            {
                case double h when (h >= 305 && h <= 1524):
                    Console.WriteLine($"Your current altitude is {height} feet ({height*0.3048} meters).");
                    Console.WriteLine("Low Alitutude");
                    Console.WriteLine("This altitude is used for takeoof and landing");

                    break;
                case double h when (h > 1524 && h <= 7620):
                    Console.WriteLine($"Your current altitude is {height} feet ({height * 0.3048} meters).");
                    Console.WriteLine("Medium Altitude");
                    Console.WriteLine("This is considered a Good Altitude for a plane to fly at");
                    break;
                case double h when (h > 7620):
                    Console.WriteLine($"Your current altitude is {height} feet ({height * 0.3048} meters).");
                    Console.WriteLine("High Altitude");
                    Console.WriteLine("This altitude is for long-rage, high-speed flight");
                    break;
                default:
                    Console.WriteLine("Your Plane has crashed");
                    break;
            }//end of switch(height)

            Console.WriteLine();
        }//end of Part 1

        public static void Part2()
        {
            Console.WriteLine("Part 2");
            Console.WriteLine();

            int grade;

            Console.WriteLine("Please enter your Numerical Grade");
            while(!int.TryParse(Console.ReadLine(), out grade) || grade <0 || grade>100)
                Console.WriteLine("Invalid Input. Try Again");

            Dictionary<int, string> gradeMap = new Dictionary<int, string>()
            {
                {90, "A" },
                {80,"B" },
                {70,"C" },
                {60, "D" },
                {0,"F" }
            };

            Console.WriteLine(grade);
            string letterGrade = "F";

            foreach(var gradeEntry in gradeMap.Reverse())
            {
                if (grade >= gradeEntry.Key)
                {
                    letterGrade = gradeEntry.Value;
                }
            }
            Console.WriteLine($"Your letter grade is : {letterGrade}");

            Console.WriteLine();
        }//end of Part 2

    }//end of class
}//end of namespace
