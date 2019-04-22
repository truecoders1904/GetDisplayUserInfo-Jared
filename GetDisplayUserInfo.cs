using System;

namespace GetUserDisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("I have a few questions for you:");
            user.FirstName = user.Question("What is your first name?");
            user.LastName = user.Question("What is your last name?");
            user.HowManyChildren = user.QuestionWithInteger("How many children do you have?");
            //bday?
            user.FavoriteAnimal = user.Question("What is your favorite animal");
            user.FavoriteMovie = user.Question("What is your favorite movie?");
            user.FavoriteNumber = user.QuestionWithInteger("What is your favorite number?");

            Console.WriteLine($"Your name is: {user.FirstName} {user.LastName}");
            Console.WriteLine($"Your favorite animal is: {user.FavoriteAnimal}");
            Console.WriteLine($"Your favorite movie is: {user.FavoriteMovie}");
            Console.Write($"Your favorite number is: ");

            if (user.FavoriteNumber > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }//if
            else if (user.FavoriteNumber < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }//elseif

            Console.Write(user.FavoriteNumber);
            Console.ResetColor();
        }//Main
    }//Program

    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        public string FavoriteAnimal { get; set; }
        public string FavoriteMovie { get; set; }
        public int FavoriteNumber { get; set; }
        public int HowManyChildren { get; set; }
  

        public string Question(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public int QuestionWithInteger(string question)
        {
            string stringAnswer = Question(question);
            return int.Parse(stringAnswer);
        }
    }
}
